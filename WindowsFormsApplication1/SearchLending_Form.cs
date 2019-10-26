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
    public partial class SearchLending_Form : Form
    {
        string role;
        public SearchLending_Form(string r)
        {
            InitializeComponent();
            this.role = r;
        }

        private void ManeMenu_Button_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton1_Click(object sender, EventArgs e)
        {
            if (LendingID_TextBox.Text.ToString() == "") 
            {
                string message1 = "Please fill ID";
                string title1 = "Error";
                MessageBox.Show(message1, title1);
                return;
            }
            int ID = int.Parse(LendingID_TextBox.Text.ToString());
            foreach (Lending l in Program.Lendings)
                if (ID == l.getLendingID())
                {
                    Lend_Form lf = new Lend_Form(l,role);
                    lf.Show();
                    this.Hide();
                    return;
                }

            string message2 = "Lending not found";
            string title2 = "Error";
            MessageBox.Show(message2, title2);

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton2_Click(object sender, EventArgs e)
        {
            if (CustomerID_TextBox.Text.ToString() == "")
            {
                string message1 = "Please fill ID";
                string title1 = "Error";
                MessageBox.Show(message1, title1);
                return;
            }
            int id = int.Parse(CustomerID_TextBox.Text.ToString());
            DateTime dt = dateTimePicker.Value.Date;
            foreach (Lending l in Program.Lendings)
                if (id == l.getCustomer().getCustomerID() && dt==l.getStartDate().Date)
                {
                    Lend_Form lf = new Lend_Form(l,role);
                    lf.Show();
                    this.Hide();
                    return;
                }

            string message2 = "Lending not found";
            string title2 = "Error";
            MessageBox.Show(message2, title2);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchLending_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
