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
    public partial class Mach_Record_Form : Form
    {
        List<Record> records;
        string role;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
        }
        public Mach_Record_Form(string r)
        {
            InitializeComponent();
            this.role = r;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.Items.Clear();

            }
            if (ID_TextBox.Text.ToString() == "" || ID_TextBox.Text.ToString() == "Customer ID...")
            {
                string message1 = "Please fill ID";
                string title1 = "Error";
                MessageBox.Show(message1, title1);
                return;
            }
            int ID = int.Parse(ID_TextBox.Text.ToString());
            foreach (Customer c in Program.Customers)
                if (ID == c.getCustomerID())
                {
                    MachRecord(c);
                    return;
                }

            string message2 = "Customer not found";
            string title2 = "Error";
            MessageBox.Show(message2, title2);
        }

        private void MachRecord(Customer c)
        {
            records = new List<Record>();
            foreach (Record r in Program.Records)
            {
                if (r.getGener().Equals(c.getFavoriteGenere()) && r.getQuantityInStock() > 0)
                {
                    records.Add(r);
                    comboBox1.Items.Add(r.getRecordName());
                    continue;
                }
                foreach (Sale sale in c.getSales())
                {
                    foreach (Record_in_sale ris in sale.getRecords())
                    {
                        if (ris.getRecord().getGener().Equals(r.getGener()) && r.getQuantityInStock() > 0)
                        {
                            records.Add(r);
                            comboBox1.Items.Add(r.getRecordName());
                        }
                    }
                }
            }

            string message = records.Count + " records were found";
            string title = "";
            MessageBox.Show(message, title);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox1.SelectedItem.ToString();
            Record record;
            foreach (Record r in records)
            {
                if (r.getRecordName().Equals(temp))
                {
                    record = r;
                    string s = "";
                    s.Replace("\n", Environment.NewLine);
                    richTextBox1.Text = "Name: "+record.getRecordName()+"\n"+"Artist: "+record.getArtist()+ "\n"+"Genere: "+record.getGener()+ "\n"+"Price: " +record.getPrice()+ " ₪";
                    break;
                }
            }
        }
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ID_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Mach_Record_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
