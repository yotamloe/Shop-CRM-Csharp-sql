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
    public partial class Lend_Form : Form
    {
        string role;
        Lending l;
        List<TextBox> textBoxes;

        public Lend_Form(Lending l,string r)
        {
            this.l = l;
                InitializeComponent();
            //if (LendingID != 0)
            //{
            //    this.l = Program.GetLendingByID(LendingID);
           // }
           // else
           // {
            //    this.l = GetLending_ByCustomerAndDate(CustomerID, DateTime);
           // }
                textBoxes = new List<TextBox>();
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
            foreach (TextBox tb in textBoxes)
            {
                tb.ReadOnly = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Status_comboBox.Hide();
            Status_comboBox.Items.Add("inLending");
            Status_comboBox.Items.Add("overDue");
            Status_comboBox.Items.Add("completed");
            dateTimePicker.Hide();
            dateTimePicker1.Hide();
            Save_button.Hide();
            LendingID_label.Text = l.getLendingID().ToString();
            CustomerID_label.Text = l.getCustomer().getCustomerID().ToString();
            CustomerName_label.Text = l.getCustomer().getCustomerName();
            StartDate_label.Text = l.getStartDate().ToString();
            EndDate_label.Text = l.getEndDate().ToString();
            Status_label.Text = l.getStatus().ToString();
            ReturnDate_label.Text = l.getReturnDate().ToString();
            Title_label.Text = "Lending " +"#"+ l.getLendingID().ToString() + " Details";

            for (int i = 0, j = 0; i < textBoxes.Count() && j < l.getRecords().Count(); i = i + 4, j++)
            {

                textBoxes[i].Text = l.getRecords()[j].getRecord().getQrCode().ToString();
                textBoxes[i + 1].Text = l.getRecords()[j].getRecord().getRecordName().ToString();
                textBoxes[i + 2].Text = l.getRecords()[j].getRecord().getArtist().ToString();
                textBoxes[i + 3].Text = l.getRecords()[j].getQuantity().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchLending_Form slf = new SearchLending_Form(role);
            slf.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EndDate_label.Hide();
            Status_label.Hide();
            Status_comboBox.Show();
            dateTimePicker.Show();
            dateTimePicker.Value = l.getEndDate();
            Status_comboBox.Text = l.getStatus().ToString();
            Save_button.Show();
            dateTimePicker1.Show();
            ReturnDate_label.Hide();
   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Status_comboBox.SelectedItem.ToString() == "completed")
            {
                 dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dateTimePicker.Value.Date.CompareTo(l.getCustomer().getLendingEndDate().Date) > 0)
            {
                string message4 = "End date is after customers lending tab expired";
                string title4 = "Error";
                MessageBox.Show(message4, title4);
                return;
            }

            if (dateTimePicker.Value.Date.CompareTo(DateTime.Now.Date) < 0)
            {
                string message3 = "Date invalid";
                string title3 = "Error";
                MessageBox.Show(message3, title3);
                return;
            }



                LendingStatus ls = (LendingStatus)Enum.Parse(typeof(LendingStatus), Status_comboBox.SelectedItem.ToString());
                l.setStatus(ls);
                l.setEndDate(dateTimePicker.Value);
                l.setReturnDate(dateTimePicker1.Value);
                if (Status_comboBox.SelectedItem.ToString() == "completed")
                {
                    foreach (Record_in_lending ril in l.getRecords())
                    {
                        ril.getRecord().setQuantityInStock(ril.getRecord().getQuantityInStock() + ril.getQuantity());
                        ril.getRecord().setQuantityInLending(ril.getRecord().getQuantityInLending() + ril.getQuantity());
                    }
                }
                string message2 = "Update succeed";
                string title2 = "";
                MessageBox.Show(message2, title2);
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private Lending GetLending_ByCustomerAndDate (int id, DateTime dt)
        {
            Lending temp = Program.Lendings.First();
            foreach (Lending l in Program.Lendings)
            {
                if (l.getCustomer().getCustomerID() == id && l.getStartDate() == dt)
                
                    temp = l;    
            }
            return temp;
        }
       
    }
}