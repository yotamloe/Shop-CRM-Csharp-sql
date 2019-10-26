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
    public partial class MAIN_Form_worker : Form
    {
        string role;
        public MAIN_Form_worker(string r)
        {
            InitializeComponent();
            this.role = r;
        }

        private void Sales_button_Click(object sender, EventArgs e)
        {
            Sale_Form SF = new Sale_Form(role);
            SF.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewLending_Form LF = new NewLending_Form(role);
            LF.Show();
            this.Hide();
        }

        private void Returning_button_Click(object sender, EventArgs e)
        {
          
        }

        private void Match_record_button_Click(object sender, EventArgs e)
        {
            Mach_Record_Form mrf = new Mach_Record_Form(role);
            mrf.Show();
            this.Hide();
        }

        private void Log_out_button_Click(object sender, EventArgs e)
        {
            Conect_Form cf = new Conect_Form();
            cf.Show();
            this.Hide();
        }
    }
}
