using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{

    public partial class recive_second_hand : Form
    {
        string role;
        public recive_second_hand(string r)
        {
            InitializeComponent();
            foreach(Genere v in Enum.GetValues(typeof(Genere)))
            {
                comboBox1.Items.Add(v);
            }
            this.role = r;
        }

        private void main_menu_button_Click(object sender, EventArgs e)
        {
            ReciveInventory_form rif = new ReciveInventory_form(role);
            rif.Show();
            this.Hide();
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
            textBox3.Text = barCode.ToString();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)// allow only digits
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

        private void record_name_KeyPress(object sender, KeyPressEventArgs e)// allow only letter
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back );
        }

        private void Add_record_Click(object sender, EventArgs e)
        {
            if (Allfilled())
            {
                Record record = new Record(Convert.ToInt32(textBox3.Text), record_name.Text, textBox2.Text, (Genere)comboBox1.SelectedItem, (float)Convert.ToInt32(textBox1.Text),
                (int)numericUpDown1.Value, 0, true);
                string message = "Record added to inventory";
                string title = "Amazing!";
                MessageBox.Show(message, title);
                textBox3.Clear();
                record_name.Clear();
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedItem = null;
                numericUpDown1.Value = 0;

            
            }
            else
            {
                string message = "Please fill all fields";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }

        public bool Allfilled()
        {
            
            if(!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox3.Text.Equals("") && !record_name.Text.Equals("")&&
              comboBox1.SelectedItem != null) 
            return true;
            return false;
        }

        private void recive_second_hand_Load(object sender, EventArgs e)
        {

        }
    }
}
