namespace WindowsFormsApplication1
{
    partial class SearchLending_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchLending_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LendingID_TextBox = new System.Windows.Forms.TextBox();
            this.CustomerID_TextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchButton1 = new System.Windows.Forms.Button();
            this.SearchButton2 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 17.82178F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(162, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Lending";
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Back_Button.Location = new System.Drawing.Point(389, 433);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(92, 28);
            this.Back_Button.TabIndex = 2;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.ManeMenu_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by lending ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search by Customer ID:";
            // 
            // LendingID_TextBox
            // 
            this.LendingID_TextBox.Location = new System.Drawing.Point(175, 130);
            this.LendingID_TextBox.Name = "LendingID_TextBox";
            this.LendingID_TextBox.Size = new System.Drawing.Size(139, 20);
            this.LendingID_TextBox.TabIndex = 5;
            this.LendingID_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CustomerID_TextBox
            // 
            this.CustomerID_TextBox.Location = new System.Drawing.Point(175, 242);
            this.CustomerID_TextBox.Name = "CustomerID_TextBox";
            this.CustomerID_TextBox.Size = new System.Drawing.Size(139, 20);
            this.CustomerID_TextBox.TabIndex = 6;
            this.CustomerID_TextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 151);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SearchButton1
            // 
            this.SearchButton1.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SearchButton1.Location = new System.Drawing.Point(215, 164);
            this.SearchButton1.Name = "SearchButton1";
            this.SearchButton1.Size = new System.Drawing.Size(59, 29);
            this.SearchButton1.TabIndex = 8;
            this.SearchButton1.Text = "Search";
            this.SearchButton1.UseVisualStyleBackColor = true;
            this.SearchButton1.Click += new System.EventHandler(this.SearchButton1_Click);
            // 
            // SearchButton2
            // 
            this.SearchButton2.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SearchButton2.Location = new System.Drawing.Point(214, 297);
            this.SearchButton2.Name = "SearchButton2";
            this.SearchButton2.Size = new System.Drawing.Size(59, 29);
            this.SearchButton2.TabIndex = 9;
            this.SearchButton2.Text = "Search";
            this.SearchButton2.UseVisualStyleBackColor = true;
            this.SearchButton2.Click += new System.EventHandler(this.SearchButton2_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(143, 268);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // SearchLending_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(493, 473);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.SearchButton2);
            this.Controls.Add(this.SearchButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CustomerID_TextBox);
            this.Controls.Add(this.LendingID_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.label1);
            this.Name = "SearchLending_Form";
            this.Text = "SearchLending_Form";
            this.Load += new System.EventHandler(this.SearchLending_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LendingID_TextBox;
        private System.Windows.Forms.TextBox CustomerID_TextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SearchButton1;
        private System.Windows.Forms.Button SearchButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}