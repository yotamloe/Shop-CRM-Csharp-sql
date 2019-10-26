namespace WindowsFormsApplication1
{
    partial class Recieve_new_inventiry_form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recieve_new_inventiry_form3));
            this.submit_button = new System.Windows.Forms.Button();
            this.recieve_inventory_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ADD_button = new System.Windows.Forms.Button();
            this.recordlist = new System.Windows.Forms.RichTextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.submit_button.Location = new System.Drawing.Point(596, 490);
            this.submit_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(100, 39);
            this.submit_button.TabIndex = 5;
            this.submit_button.Text = "SUBMIT";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // recieve_inventory_label
            // 
            this.recieve_inventory_label.AutoSize = true;
            this.recieve_inventory_label.Font = new System.Drawing.Font("Aharoni", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.recieve_inventory_label.ForeColor = System.Drawing.Color.Goldenrod;
            this.recieve_inventory_label.Location = new System.Drawing.Point(148, 30);
            this.recieve_inventory_label.Name = "recieve_inventory_label";
            this.recieve_inventory_label.Size = new System.Drawing.Size(413, 28);
            this.recieve_inventory_label.TabIndex = 6;
            this.recieve_inventory_label.Text = "Recieve New Record In Store";
            this.recieve_inventory_label.Click += new System.EventHandler(this.recieve_inventory_label_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 121);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 156);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 25);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 198);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 25);
            this.textBox3.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(224, 275);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 25);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(30, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Record Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(30, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Record Artist:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(30, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Record Genere:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(30, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Record Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(30, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantity:";
            // 
            // ADD_button
            // 
            this.ADD_button.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ADD_button.Location = new System.Drawing.Point(240, 376);
            this.ADD_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(82, 33);
            this.ADD_button.TabIndex = 19;
            this.ADD_button.Text = "ADD";
            this.ADD_button.UseVisualStyleBackColor = true;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // recordlist
            // 
            this.recordlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.recordlist.Location = new System.Drawing.Point(380, 119);
            this.recordlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recordlist.Name = "recordlist";
            this.recordlist.Size = new System.Drawing.Size(310, 268);
            this.recordlist.TabIndex = 20;
            this.recordlist.Text = "";
            this.recordlist.TextChanged += new System.EventHandler(this.recordlist_TextChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(224, 240);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(116, 25);
            this.comboBox4.TabIndex = 21;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(224, 313);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(117, 25);
            this.numericUpDown6.TabIndex = 22;
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.Transparent;
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.generate.Location = new System.Drawing.Point(142, 118);
            this.generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(71, 27);
            this.generate.TabIndex = 23;
            this.generate.Text = "bar-code";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(30, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Record barcode:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(222, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "If record doesn\'t exist in system, add it now:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 152);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Recieve_new_inventiry_form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(712, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.recordlist);
            this.Controls.Add(this.ADD_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.recieve_inventory_label);
            this.Controls.Add(this.submit_button);
            this.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Recieve_new_inventiry_form3";
            this.Text = "Recieve_New_inventiry_form";
            this.Load += new System.EventHandler(this.Recieve_new_inventiry_form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label recieve_inventory_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.RichTextBox recordlist;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}