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
    public partial class Recieve_new_Inventiry_Form2 : Form

    {
        string role;
        RichTextBox RTB;
        Order order;
        private Dictionary<Record, int> map;
        public Recieve_new_Inventiry_Form2(Recieve_new_inventiry_form3 f1, Recieve_new_Inventiry_Form1 f2, string r)
        {
            InitializeComponent();
            records_richTextBox2.ReadOnly = true;
            map = f2.getMap();
            order = f2.getorder();
            RTB = f1.getTextBox();
            this.role = r;


            Fillbox();
        }

        private void main_menu_button_Click(object sender, EventArgs e)
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

        private void records_richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Fillbox()
        {
            foreach(Record_in_order rio in order.getRecords())
            {
                foreach (var item in map)
                {
                    if(item.Key.ToString() == rio.ToString())
                    {
                        rio.setarrivedQuantity(item.Value);
                        int update = rio.getRecord().getQuantityInStock() + item.Value;
                        rio.getRecord().setQuantityInStock(update);
                        break;
                    }
                }

                records_richTextBox2.Text = records_richTextBox2.Text + "\n" + rio.ToString() + "  " + rio.getRecord().getArtist() +
                "  required Quantity: " + rio.getRequiredQ().ToString() + "  arrived Quantity: " + rio.getarrivedQ().ToString();

             }
            
            records_richTextBox2.Text += "\n" + "\n" + CheckStatus();
            records_richTextBox2.Text += "\n" + "\n" + RTB.Text;




        }
        private String CheckStatus()
        {
           
            foreach (Record_in_order rio in order.getRecords())
            {
            if(rio.getRequiredQ() > rio.getarrivedQ())
                {
                    OrderStatus s = (OrderStatus)Enum.Parse(typeof(OrderStatus), "missingItems");
                    order.setStatus(s);
                    return "Order status: Missing Items";
                }

            }
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "complete");
            order.setStatus(os);
            return "Order status : complete";
        }

        private void Recieve_new_Inventiry_Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
