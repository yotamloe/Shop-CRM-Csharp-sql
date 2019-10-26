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
    public partial class Lendings_Form : Form
    {
        string role;
        public Lendings_Form(string r)
        {
            InitializeComponent();
            this.role = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchLending_Form slf = new SearchLending_Form(role);
            slf.Show();
            this.Hide();
        }

        private void CreateLending_Button_Click(object sender, EventArgs e)
        {
            NewLending_Form NLF = new NewLending_Form(role);
            NLF.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
