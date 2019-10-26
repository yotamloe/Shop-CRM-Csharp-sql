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
    public partial class ReciveInventory_form : Form
    {
        string role;
        public ReciveInventory_form(string r)
        {
            InitializeComponent();
            this.role = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recieve_new_Inventiry_Form1 rnif = new Recieve_new_Inventiry_Form1(role);
            rnif.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recive_second_hand rsh = new recive_second_hand(role);
            rsh.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
