using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NewLending_Form : Form
    {
        string role;
        private bool IsCustomer;
        private bool IsBarCode;
        List<TextBox> textBoxes;
        Record record;
        List<Record> records;
        Customer customer;
        bool isSubmit = false;

        public NewLending_Form(string r)
        {
            InitializeComponent();
            V1_Picture.Hide();
            V2_Picture.Hide();
            textBoxes = new List<TextBox>();
            records = new List<Record>();
            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);
            textBoxes.Add(textBox3);
            textBoxes.Add(textBox4);
            textBoxes.Add(textBox5);
            textBoxes.Add(textBox6);
            textBoxes.Add(textBox7);
            textBoxes.Add(textBox8);
            textBoxes.Add(textBox9);
            textBoxes.Add(textBox10);
            textBoxes.Add(textBox11);
            textBoxes.Add(textBox12);
            textBoxes.Add(textBox13);
            textBoxes.Add(textBox14);
            textBoxes.Add(textBox15);
            textBoxes.Add(textBox16);
            textBoxes.Add(textBox17);
            textBoxes.Add(textBox18);
            textBoxes.Add(textBox19);
            textBoxes.Add(textBox20);
            this.role = r;

            foreach(TextBox tb in textBoxes)
            {
                tb.ReadOnly = true;
            }
        }

        private void date_lable_Click(object sender, EventArgs e)
        {

        }

        private void Lending_Form_Load(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {

            if (isSubmit == false)
            {
                Record r;
                for (int i = 0; i < textBoxes.Count(); i = i + 4)
                {
                    if (textBoxes[i].Text != "")
                    {
                        r = Program.GetRecordByQR(int.Parse(textBoxes[i].Text));
                        r.setQuantityInStock(r.getQuantityInStock() + int.Parse(textBoxes[i + 3].Text));
                    }
                }
           
            }

            foreach (TextBox tb in textBoxes)
            {
                tb.Clear();
            }

            V1_Picture.Hide();
            V2_Picture.Hide();
            CheckID_button.Show();
            records.Clear();
            customer = null;
            record = null;
            IsCustomer = false;
            IsBarCode = false;
            isSubmit = false;
            customer_ID_textbox.Text = "Customer ID";
            Barcode_textbox.Text = "BarCode";
            submit_button.Show();

            // this.Hide();
            // Lending_Form lf=new Lending_Form();

        }

        private void table_table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void date_piker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Main_menu_button_Click(object sender, EventArgs e)
        {

            if (isSubmit == false)
            {
                Record r;
                for (int i = 0; i < textBoxes.Count(); i = i + 4)
                {
                    if (textBoxes[i].Text != "")
                    {
                        r = Program.GetRecordByQR(int.Parse(textBoxes[i].Text));
                        r.setQuantityInStock(r.getQuantityInStock() + int.Parse(textBoxes[i + 3].Text));
                    }
                }

            }
            Lendings_Form LF = new Lendings_Form(role);
            LF.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckCustomerID();
        }
                
        private void Barcode_textbox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private bool CheckCustomerID()
        {
            if (customer_ID_textbox.Text.ToString() == "" || customer_ID_textbox.Text.ToString() == "Customer ID")
            {
                string message1 = "Please fill ID";
                string title1 = "Error";
                MessageBox.Show(message1, title1);
                return false;
            }
            int ID1 = int.Parse(customer_ID_textbox.Text.ToString());
            foreach (Customer c in Program.Customers)
                if (ID1 == c.getCustomerID())
                {
                    if (c.getHasLendingTab() == true && DateTime.Compare(c.getLendingEndDate(), DateTime.Now) > 0)
                    {
                        V1_Picture.Show();
                        IsCustomer = true;
                        customer = c;
                        CheckID_button.Hide();
                        return true;
                    }
                    string message1 = "The Customer doesn't have valid lending tab";
                    string title1 = "Error";
                    IsCustomer = false;
                    MessageBox.Show(message1, title1);
                    return false;
                }

            string message2 = "Customer not found";
            string title2 = "Error";
            MessageBox.Show(message2, title2);
            IsCustomer = false;
            return false;


        }
        private bool CheckBarCode()
        {
            if (Barcode_textbox.Text.ToString() == "" || Barcode_textbox.Text.ToString() == "BarCode")
            {
                string message1 = "Please fill BarCode";
                string title1 = "Error";
                MessageBox.Show(message1, title1);
                IsBarCode = false;
                return false;
            }
            int ID2 = int.Parse(Barcode_textbox.Text.ToString());
            foreach (Record r in Program.Records)
            {
                if (ID2 == r.getQrCode())
                {
                    if (r.getQuantityInStock() > 0)
                    {
                        V2_Picture.Show();
                        record = r;
                        IsBarCode = true;
                        return true;
                    }
                    string message4 = "The record doesn't exist in stock";
                    string title4 = "Error";
                    MessageBox.Show(message4, title4);
                    IsBarCode = false;
                    return false;
                }
            }

            string message3 = "Record not found";
            string title3 = "Error";
            MessageBox.Show(message3, title3);
            IsBarCode = false;
            return false;


        }

        private void ADD_button_Click(object sender, EventArgs e)
        {
            if (IsCustomer)
            {
                CheckBarCode();
            }
            if (IsCustomer == false)
            {
                string message5 = "Please enter confirmed customer";
                string title5 = "Error";
                MessageBox.Show(message5, title5);
            }
            if (IsCustomer && IsBarCode)
            {
                bool isIn = false;
                for (int i = 0; i < textBoxes.Count(); i = i + 4)
                {
                    if (textBoxes[i].Text.Equals(record.getQrCode().ToString()))
                    {
                        textBoxes[i + 3].Text = (int.Parse(textBoxes[i + 3].Text) + 1).ToString();
                        isIn = true;
                        records.Add(record);
                        record.setQuantityInStock(record.getQuantityInStock() - 1);
                        break;
                    }
                }
                if (isIn == false)
                {
                    for (int i = 0; i < textBoxes.Count(); i = i + 4)
                    {

                        if (textBoxes[i].Text == "")
                        {
                            textBoxes[i].Text = record.getQrCode().ToString();
                            textBoxes[i + 1].Text = record.getRecordName();
                            textBoxes[i + 2].Text = record.getArtist();
                            textBoxes[i + 3].Text = "1";
                            records.Add(record);
                            record.setQuantityInStock(record.getQuantityInStock() - 1);
                            break;
                        }
                    }
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (IsCustomer && IsBarCode && records.Count() > 0)
            {
                if (date_piker.Value.Date.CompareTo(DateTime.Now.Date) < 0)
                {
                    string message3 = "Date invalid";
                    string title3 = "Error";
                    MessageBox.Show(message3, title3);
                }
                else
                {
                    if (date_piker.Value.Date.CompareTo(customer.getLendingEndDate().Date)>0)
                    {
                        string message4 = "End date is after customers lending tab expired";
                        string title4 = "Error";
                        MessageBox.Show(message4, title4);
                    }


                    else
                    {
                        isSubmit = true;
                        DateTime dt = date_piker.Value;
                        Lending l = new Lending(Program.Lendings.Count() + 1, DateTime.Now, dt, (LendingStatus)Enum.Parse(typeof(LendingStatus), "inLending".ToString()), customer, DateTime.MinValue, true);
                        Record r;
                        int q;

                        for (int i = 0; i < textBoxes.Count(); i = i + 4)
                        {
                            if (textBoxes[i].Text != "")
                            {
                                r = Program.GetRecordByQR(int.Parse(textBoxes[i].Text));
                                q = int.Parse(textBoxes[i + 3].Text);
                                Record_in_lending ril = new Record_in_lending(l, r, q, true);
                                l.addRecord(ril);
                                r.addRecordInLending(ril);
                                r.setQuantityInLending(r.getQuantityInLending() + q);
                            }
                        }
                        customer.add_lending(l);
                        string message1 = "Lent Succsessful";
                        string title1 = "";
                        MessageBox.Show(message1, title1);
                        submit_button.Hide();
                    }
                }
            }
            else
            {
                string message2 = "Please fill all details";
                string title2 = "Error";
                MessageBox.Show(message2, title2);
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void customer_ID_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Record r = Program.GetRecordByQR(int.Parse(textBox1.Text));
                r.setQuantityInStock(r.getQuantityInStock() + int.Parse(textBox4.Text));
                records.RemoveAll(x => x.getQrCode() == r.getQrCode());
                for (int i = 0; i < 4; i++)
                {
                    textBoxes[i].Clear();
                }
            }
              
        }

        private void Remove_button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                Record r = Program.GetRecordByQR(int.Parse(textBox5.Text));
                records.RemoveAll(x => x.getQrCode() == r.getQrCode());
                r.setQuantityInStock(r.getQuantityInStock() + int.Parse(textBox8.Text));
                for (int i = 4; i < 8; i++)
                {
                    textBoxes[i].Clear();
                }
            }

        }

        private void Remove_button3_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                Record r = Program.GetRecordByQR(int.Parse(textBox9.Text));
                records.RemoveAll(x => x.getQrCode() == r.getQrCode());
                r.setQuantityInStock(r.getQuantityInStock() + int.Parse(textBox12.Text));
                for (int i = 8; i < 12; i++)
                {
                    textBoxes[i].Clear();
                }
            }
        }

        private void Remove_button4_Click(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                Record r = Program.GetRecordByQR(int.Parse(textBox13.Text));
                records.RemoveAll(x => x.getQrCode() == r.getQrCode());
                r.setQuantityInStock(r.getQuantityInStock() + int.Parse(textBox20.Text));
                for (int i = 12; i < 16; i++)
                {
                    textBoxes[i].Clear();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
 
        }

        private void Remove_button5_Click(object sender, EventArgs e)
        {
            if (textBox17.Text != "")
            {
                Record r = Program.GetRecordByQR(int.Parse(textBox17.Text));
                records.RemoveAll(x => x.getQrCode() == r.getQrCode());
                r.setQuantityInStock(r.getQuantityInStock() + int.Parse(textBox20.Text));
                for (int i = 16; i < 20; i++)
                {
                    textBoxes[i].Clear();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
    
}
