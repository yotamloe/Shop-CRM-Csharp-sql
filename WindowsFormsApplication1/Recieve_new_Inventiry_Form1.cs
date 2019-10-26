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
    public partial class Recieve_new_Inventiry_Form1 : Form
    {
        string role;
        private Order order;
        private Record record;
        private Dictionary<Record, int> map = new Dictionary<Record, int>();


        public Recieve_new_Inventiry_Form1(string r)
        {
            InitializeComponent();
            records_richTextBox1.ReadOnly = true;
            this.role = r;

        }

        private void main_menu_button_Click(object sender, EventArgs e)
        {
            ReciveInventory_form RI = new ReciveInventory_form(role);
            RI.Show();
            this.Hide();
        }

        private void choose_order_button_Click(object sender, EventArgs e)
        {
            int orderID;
            string orderNumber;
            orderNumber = order_number_textbox.Text.ToString();

            if (orderNumber == "" || orderNumber == "Order Number")
            {
                string message = "Please fill Order number";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            else
            {
                orderID = int.Parse(orderNumber);
                foreach (Order o in Program.Orders)
                {
                    if (o.getID() == orderID)
                    {
                        order = o;
                        break;
                    }
                }
                if (order != null)
                {
                    showDetails(order);
                }
                else
                {
                    string message = "Incorrect record id";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }

            }
        }

        public void showDetails(Order o)
        {
            foreach (Record_in_order rio in o.getRecords())
            {
                comboBox1.Items.Add(rio.ToString());
            }


        }

        private void order_number_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clik = comboBox1.SelectedItem.ToString();
            foreach (Record_in_order rio in order.getRecords())
            {
                if(clik == rio.ToString())
                {
                   Quantity_record_in_order.Text = rio.getRequiredQ().ToString();
                    record = rio.getRecord();
                }

            }
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public Dictionary<Record, int> getMap()
        {
            return map;
        }
        public Order getorder()
        {
            return order;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ADD_button_Click(object sender, EventArgs e)
        {
           if(Record_textBox.Text == "" || Record_textBox.Text == null || cheakRecord() == false)
            {
                string message = "Please fill Record required and Order number";
                string title = "Error";
                MessageBox.Show(message, title);
            }
           else
            {
                string s = "";
                s.Replace("\n", Environment.NewLine);
                records_richTextBox1.Text = records_richTextBox1.Text+ "\n" + "   "+ record.ToString()+" NUMBER:   "+ Record_textBox.Text;
                map.Add(record,int.Parse(Record_textBox.Text));


            }

        }

      private Boolean cheakRecord()
        {
            foreach (Record r in Program.Records)
            {
                if (r.ToString() == record.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void records_richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                string massage1 = "Please fill Order number";
                string titel2 = "Error";
                MessageBox.Show(massage1, titel2);
            }
            else
            {
                foreach (Order o in Program.Orders)
                {

                    if (order.ToString() == o.ToString())
                    {
                        Recieve_new_inventiry_form3 RNI = new Recieve_new_inventiry_form3(this, role);
                        RNI.Show();
                        this.Hide();
                        return;
                    }
                }
                string massage = "Please fill Order number";
                string titel = "Error";
                MessageBox.Show(massage, titel);
            }
        }

        private void recieve_inventory_label_Click(object sender, EventArgs e)
        {
          
        }

        private void Recieve_new_Inventiry_Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
