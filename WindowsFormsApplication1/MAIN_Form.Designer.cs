namespace WindowsFormsApplication1
{
    partial class MAIN_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sales_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Match_record_button = new System.Windows.Forms.Button();
            this.Recive_inventory_button = new System.Windows.Forms.Button();
            this.Email_form_button = new System.Windows.Forms.Button();
            this.Log_out_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 29.94059F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(172, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to B-SIDE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(248, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please select your relevant option:";
            // 
            // Sales_button
            // 
            this.Sales_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Sales_button.Location = new System.Drawing.Point(132, 193);
            this.Sales_button.Name = "Sales_button";
            this.Sales_button.Size = new System.Drawing.Size(149, 64);
            this.Sales_button.TabIndex = 2;
            this.Sales_button.Text = "Sales";
            this.Sales_button.UseVisualStyleBackColor = true;
            this.Sales_button.Click += new System.EventHandler(this.Sales_button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(288, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lending";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Match_record_button
            // 
            this.Match_record_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Match_record_button.Location = new System.Drawing.Point(207, 269);
            this.Match_record_button.Name = "Match_record_button";
            this.Match_record_button.Size = new System.Drawing.Size(149, 64);
            this.Match_record_button.TabIndex = 5;
            this.Match_record_button.Text = "Match a record to customer";
            this.Match_record_button.UseVisualStyleBackColor = true;
            this.Match_record_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Recive_inventory_button
            // 
            this.Recive_inventory_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Recive_inventory_button.Location = new System.Drawing.Point(444, 193);
            this.Recive_inventory_button.Name = "Recive_inventory_button";
            this.Recive_inventory_button.Size = new System.Drawing.Size(149, 64);
            this.Recive_inventory_button.TabIndex = 6;
            this.Recive_inventory_button.Text = "Receive inventory";
            this.Recive_inventory_button.UseVisualStyleBackColor = true;
            this.Recive_inventory_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // Email_form_button
            // 
            this.Email_form_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Email_form_button.Location = new System.Drawing.Point(364, 269);
            this.Email_form_button.Name = "Email_form_button";
            this.Email_form_button.Size = new System.Drawing.Size(149, 64);
            this.Email_form_button.TabIndex = 7;
            this.Email_form_button.Text = "Distribution message";
            this.Email_form_button.UseVisualStyleBackColor = true;
            this.Email_form_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // Log_out_button
            // 
            this.Log_out_button.Location = new System.Drawing.Point(606, 476);
            this.Log_out_button.Name = "Log_out_button";
            this.Log_out_button.Size = new System.Drawing.Size(106, 31);
            this.Log_out_button.TabIndex = 11;
            this.Log_out_button.Text = "Log out";
            this.Log_out_button.UseVisualStyleBackColor = true;
            this.Log_out_button.Click += new System.EventHandler(this.Log_out_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 154);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, -35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 121);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(645, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 121);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(53, 440);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 121);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // MAIN_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(728, 520);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Log_out_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Email_form_button);
            this.Controls.Add(this.Recive_inventory_button);
            this.Controls.Add(this.Match_record_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sales_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "MAIN_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sales_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Match_record_button;
        private System.Windows.Forms.Button Recive_inventory_button;
        private System.Windows.Forms.Button Email_form_button;
        private System.Windows.Forms.Button Log_out_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

