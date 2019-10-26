using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    
    public partial class Email_Form : Form
    {
        string role;

        public Email_Form(string r)
        {
           
            InitializeComponent();
            foreach(Customer c in Program.Customers) {
                mailing_list.Items.Add(c);
                mailing_list.SelectionMode = SelectionMode.MultiExtended;
                this.role = r;
               

            }

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

        private void Send_Click(object sender, EventArgs e)
        {
            Email email = new Email(Email_box.Text, sub.Text, dateTimePicker1.Value);
            try
            {
                if(mailing_list.SelectedItems.Count != 0)
                if (checkBox1.Checked == true)
                {
                    foreach (Customer customer in mailing_list.SelectedItems)
                    {

                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                            if (!textBox1.Text.Equals(""))
                            {
                                Attachment data = new Attachment(textBox1.Text);
                                mail.Attachments.Add(data);
                                
                            }
                        mail.From = new MailAddress("bsiderecords13@gmail.com");
                        mail.To.Add(customer.getEmail());
                        mail.Subject = email.getSubject();                    
                        mail.IsBodyHtml = true;
                        string htmlBody;
                        htmlBody = email.getContent();
                        mail.Body = htmlBody;
                        SmtpServer.UseDefaultCredentials = false;
                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("bsiderecords13@gmail.com", "yooms153");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);

                    }
                    MessageBox.Show("mail Sent");
                }
                else
                    MessageBox.Show("Email will be sent at " + dateTimePicker1.Value.ToString());
            
                else
                    MessageBox.Show("Please add at least one customer to the mailing list");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true)
            for (int x = 0; x < mailing_list.Items.Count; x++)
            {
                // Determine if the item is selected.
                if (mailing_list.GetSelected(x) == false)
                    // Deselect all items that are selected.
                    mailing_list.SetSelected(x, true); 
            }
            else
            for (int x = 0; x < mailing_list.Items.Count; x++)
            {
                   mailing_list.SetSelected(x, false);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if ( dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("Can not select past date");
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void Email_box_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
            string loacation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    loacation = dialog.FileName;
                    textBox1.Text = loacation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                Email_box.Font = fd.Font;
        }

        private void Email_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
