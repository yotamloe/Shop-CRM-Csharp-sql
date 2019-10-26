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
    public partial class MAIN_Form : Form
    {

        string role;
            public MAIN_Form(string r)
        {
            InitializeComponent();
            this.role = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void Log_out_button_Click(object sender, EventArgs e)
        {
            Conect_Form cf = new Conect_Form();
            cf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mach_Record_Form mrf = new Mach_Record_Form(role);
            mrf.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Email_Form EF = new Email_Form(role);
            EF.Show();
            this.Hide();
        }

        private void Sales_button_Click(object sender, EventArgs e)
        {
            Sale_Form SF = new Sale_Form(role);
            SF.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lendings_Form LF = new Lendings_Form(role);
            LF.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReciveInventory_form rif = new ReciveInventory_form(role);
            rif.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void l_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
