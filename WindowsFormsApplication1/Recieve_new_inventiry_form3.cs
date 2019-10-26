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
    public partial class Recieve_new_inventiry_form3 : Form
    
    {
        string role;
        Recieve_new_Inventiry_Form1 form;
        public Recieve_new_inventiry_form3(Recieve_new_Inventiry_Form1 f,string r)
        {
            InitializeComponent();
            recordlist.ReadOnly = true; 
            recordlist.Text += "NEW RECORDS:";
           this.form = f;
            foreach (Genere v in Enum.GetValues(typeof(Genere)))
            {
                comboBox4.Items.Add(v);
            }
            this.role = r;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Recieve_new_Inventiry_Form2 RIF = new Recieve_new_Inventiry_Form2(this,form,role);
            RIF.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void recieve_inventory_label_Click(object sender, EventArgs e)
        {

        }

        private void ADD_button_Click(object sender, EventArgs e)
        {
            if (Allfilled())
            {
                Genere g = (Genere)Enum.Parse(typeof(Genere), comboBox4.SelectedItem.ToString());
                Record record = new Record(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, g,
                float.Parse(textBox5.Text), int.Parse(numericUpDown6.Value.ToString()), 0, true);
                form.getMap().Add(record, int.Parse(numericUpDown6.Value.ToString()));

                string s = "";
                s.Replace("\n", Environment.NewLine);

                recordlist.Text += "\n" + "Record name: " + textBox2.Text + " Quantity: " + numericUpDown6.Value.ToString();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                numericUpDown6.Value = 0;
            }
            else
            {
                string message = "Please fill all fields";
                string title = "Error";
                MessageBox.Show(message, title);
            }

        }
        private void recordlist_TextChanged(object sender, EventArgs e)
        {

        }
        public RichTextBox getTextBox()
        {
            return this.recordlist;
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            int barCode;
            while (true)
            {
                int count = 0;
                int _min = 10000;
                int _max = 99999;
                Random _rdm = new Random();
                barCode = _rdm.Next(_min, _max);
                foreach (Record r in Program.Records)
                {
                    if (r.getQrCode() != barCode)
                        count++;
                }
                if (count == Program.Records.Count())
                    break;
            }
            textBox1.Text = barCode.ToString();
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)// allow only digits
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)// allow only letters
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || (Keys)e.KeyChar == Keys.Space);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)// allow only letters
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || (Keys)e.KeyChar == Keys.Space);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public bool Allfilled()
        {

            if (!textBox2.Text.Equals("") && !textBox3.Text.Equals("") && !textBox5.Text.Equals("") &&
                !textBox1.Text.Equals("") && comboBox4.SelectedItem != null && numericUpDown6.Value != 0)
                return true;
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recieve_new_inventiry_form3_Load(object sender, EventArgs e)
        {

        }
    }
}
