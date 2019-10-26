using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Sale_Form : Form
    {
        string role;
        private bool IsCustomer = false;
        private bool IsBarCode=false;
        List<Record> records;
        Record_in_sale ris;
        List<Record_in_sale> recordsINsale;
        Customer customer;
        float totalPrice = 0;   
        decimal Rquantity;
        int quantity;
        private Dictionary<Record, int> map = new Dictionary<Record, int>();
        public Sale_Form(string r)
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            CheckID_button.Show();
            Thanks_label.Hide();
            V1_Picture.Hide();
            V2_Picture.Hide();
            comboBox1.DataSource = Enum.GetValues(typeof(PaymentMethod));
            records = new List<Record>();
            ID_TextBox.ReadOnly = false;
            this.role = r;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Sale_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sale_label_Click(object sender, EventArgs e)
        {

        }

        private void Main_Menu_button_Click(object sender, EventArgs e)
        {
            if (role != "worker")
            {
                MAIN_Form MF = new MAIN_Form(role);
                MF.Show();
                this.Hide();
            }
            else
            {
                MAIN_Form_worker MFW = new MAIN_Form_worker(role);
                MFW.Show();
                this.Hide();
            }
        }


       
     
        private void barcode_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }
       
        private void ADD_button_Click(object sender, EventArgs e)
        {
            if (IsCustomer)
            {
                CheckBarCode();
            }

            if (!IsCustomer)
            {
                string message7 = "Please fill ID number";
                string title7 = "Error";
                MessageBox.Show(message7, title7);
            }


            if (IsBarCode && IsCustomer)
            {
                ID_TextBox.ReadOnly = true;
                Rquantity = numericUpDown1.Value;
                quantity = (int)Rquantity;
                customer = Program.GetCustomerByID(int.Parse(ID_TextBox.Text));
                Record record = Program.GetRecordByQR(int.Parse(barcode_textbox.Text));


                if (quantity <= record.getQuantityInStock())
                {
                    string s = "";
                    s.Replace("\n", Environment.NewLine);
                    richTextBox1.Text = richTextBox1.Text + "\n" + "Name: " + record.getRecordName().ToString() + "   x " + quantity + "     By: " + record.getArtist().ToString() + ",    " + "Price: " + (quantity * record.getPrice());
                    totalPrice = totalPrice + quantity * record.getPrice();
                    price_textbox.Text = totalPrice.ToString();
                    record.setQuantityInStock(record.getQuantityInStock() - quantity);
                   if (!records.Contains(record))
                    {
                        map.Add(record, quantity);
                    }
                    else
                    {
                        foreach (var item in map)
                    {
                        int q = item.Value;
                        if (map.ContainsKey(record))
                        {
                            q = q + 1;
                        }
                        else
                        {
                            map.Add(record, quantity);
                        }

                    }
                    }
                    

                    

                    records.Add(record);
                    IsBarCode = false;
                }

                if (quantity > record.getQuantityInStock() && record.getQuantityInStock() != 0)
                {
                    string message4 = "There are only " + record.getQuantityInStock() + " records in stock";
                    string title4 = "Error";
                    MessageBox.Show(message4, title4);
                }

            }
        }
    



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ID_TextBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void price_textbox_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void CheckID_button_Click(object sender, EventArgs e)
        {
            CheckCustomerID();
        }

        private void checkBarCode_button_Click(object sender, EventArgs e)
        {
            CheckBarCode();
        }
        private bool CheckCustomerID()
        {
            if (ID_TextBox.Text.ToString() == "" || ID_TextBox.Text.ToString() == "Customer ID")
            {
                string message1 = "Please fill ID";
                string title1 = "Error";
                MessageBox.Show(message1, title1);
                return false;
            }
            int ID1 = int.Parse(ID_TextBox.Text.ToString());
            foreach (Customer c in Program.Customers)
                if (ID1 == c.getCustomerID() )
                {
                    V1_Picture.Show();
                    CheckID_button.Hide();
                    IsCustomer = true;
                    return true;
                }
            string message2 = "Customer not found, please create new customer";
            string title2 = "Error";
            MessageBox.Show(message2, title2);
            V1_Picture.Hide();
            IsCustomer = false;
            return false;
        }

        private bool CheckBarCode()
        {
            if (barcode_textbox.Text.ToString() == "" || barcode_textbox.Text.ToString() == "BarCode")
            {
                string message1 = "Please fill BarCode";
                string title1 = "Error";
                MessageBox.Show(message1, title1);
                IsBarCode = false;
                return false;
            }
            int ID2 = int.Parse(barcode_textbox.Text.ToString());
            foreach (Record r in Program.Records)
            {
                if (ID2 == r.getQrCode())
                {
                    if (r.getQuantityInStock() > 0)
                    {
                        V2_Picture.Show();
                        IsBarCode = true;
                        return true;
                    }
                    string message4 = "The record doesn't exist in stock";
                    string title4 = "Error";
                    MessageBox.Show(message4, title4);
                    V2_Picture.Hide();
                    IsBarCode = false;
                    return false;

                }
                
            }

            string message3 = "Record not found";
            string title3 = "Error";
            MessageBox.Show(message3, title3);
            V2_Picture.Hide();
            IsBarCode = false;
            return false;
        }


        private void V1_Picture_Click(object sender, EventArgs e)
        {

        }

        private void V2_Picture_Click(object sender, EventArgs e)
        {

        }

        public Dictionary<Record, int> getMap()
        {
            return map;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (price_textbox.Text == "")
            {
                string message5 = "Please enter sale details";
                string title5 = "Error";
                MessageBox.Show(message5, title5);

            }
            else
            {
                PaymentMethod pm = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), comboBox1.SelectedItem.ToString());
                Sale s = new Sale(Program.Sales.Count()+1, DateTime.Now, pm, customer, true);
                recordsINsale = new List<Record_in_sale>();

                foreach (var item in map)
                {
                    Record rec = item.Key;
                    int q = item.Value;



                    foreach (Record r in records)
                    {
                        if (rec.ToString() == r.ToString())
                        {
                            ris = new Record_in_sale(r, s , q , true);
                            recordsINsale.Add(ris);
                            r.addRecordInSale(ris);
                            s.addRecord(ris);
                            ID_TextBox.ReadOnly = false;
                            break;
                        }


                    }
              

               }
                s.updateTotalCost();
                customer.add_sale(s);
                sale_label.Hide();
                ID_TextBox.Hide();
                barcode_textbox.Hide();
                V1_Picture.Hide();
                V2_Picture.Hide();
                CheckID_button.Hide();
                quantity_label.Hide();
                numericUpDown1.Hide();
                richTextBox1.Hide();
                comboBox1.Hide();
                price_textbox.Hide();
                total_cost_label.Hide();
                ADD_button.Hide();
                clear_button.Hide();
                symbol_label.Hide();
                newCustumer_label.Hide();
                submit_button.Hide();
                Thanks_label.Show();
            }

        }

        private void clear_button_Click(object sender, EventArgs e)
        {

                foreach(Record r in records)
                {
                    r.setQuantityInStock(r.getQuantityInStock() + quantity);
                   
                }
                
                customer = null;
            IsCustomer = false;
            IsBarCode = false;

            V1_Picture.Hide();
            V2_Picture.Hide();
            CheckID_button.Show();
            ID_TextBox.Text = "Customer ID";
            barcode_textbox.Text = "BarCode";
            richTextBox1.Text = "";
            price_textbox.Text = "";
            numericUpDown1.Value=1;
            totalPrice = 0;
            ID_TextBox.ReadOnly = false;
            map.Clear();
            records.Clear();

        }

        private void newCustumer_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
