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
    public partial class Conect_Form : Form
    {
         private string role;
      
        public Conect_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckConection())
            {
                if (role != "worker") {
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

        private Boolean CheckConection()//אימות שם משתמש וסיסמאנכונים
        {
            string id;
            id = User_Name_text.Text.ToString();
            string password;
            password = Password_text.Text.ToString();
            if (id == "Email" || password == "Password"|| id == "" || password == "") {
                string message = "Please fill id and password";
                string title = "Error";
                MessageBox.Show(message, title);
                return false;}
            foreach (Employee e in Program.Employees){
                if (e.getID() == int.Parse(id) && e.getPassword() == password)
                {
                  role = e.getRole().ToString();
                    return true;
                }
            }
            string message2 = "Incorrect id and password";
            string title2 = "Error";
            MessageBox.Show(message2, title2);
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
