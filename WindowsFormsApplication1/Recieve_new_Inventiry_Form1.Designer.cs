namespace WindowsFormsApplication1
{
    partial class Recieve_new_Inventiry_Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recieve_new_Inventiry_Form1));
            this.recieve_inventory_label = new System.Windows.Forms.Label();
            this.choose_order_button = new System.Windows.Forms.Button();
            this.order_number_textbox = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Quantity_record_in_order = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Record_textBox = new System.Windows.Forms.TextBox();
            this.ADD_button = new System.Windows.Forms.Button();
            this.records_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.main_menu_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // recieve_inventory_label
            // 
            this.recieve_inventory_label.AutoSize = true;
            this.recieve_inventory_label.Font = new System.Drawing.Font("Aharoni", 22.09901F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.recieve_inventory_label.ForeColor = System.Drawing.Color.Goldenrod;
            this.recieve_inventory_label.Location = new System.Drawing.Point(149, 27);
            this.recieve_inventory_label.Name = "recieve_inventory_label";
            this.recieve_inventory_label.Size = new System.Drawing.Size(368, 32);
            this.recieve_inventory_label.TabIndex = 0;
            this.recieve_inventory_label.Text = "Recieve New Inventory";
            this.recieve_inventory_label.Click += new System.EventHandler(this.recieve_inventory_label_Click);
            // 
            // choose_order_button
            // 
            this.choose_order_button.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.choose_order_button.Location = new System.Drawing.Point(32, 84);
            this.choose_order_button.Name = "choose_order_button";
            this.choose_order_button.Size = new System.Drawing.Size(113, 34);
            this.choose_order_button.TabIndex = 1;
            this.choose_order_button.Text = "Choose Order";
            this.choose_order_button.UseVisualStyleBackColor = true;
            this.choose_order_button.Click += new System.EventHandler(this.choose_order_button_Click);
            // 
            // order_number_textbox
            // 
            this.order_number_textbox.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.order_number_textbox.ForeColor = System.Drawing.Color.Gray;
            this.order_number_textbox.Location = new System.Drawing.Point(168, 89);
            this.order_number_textbox.Name = "order_number_textbox";
            this.order_number_textbox.Size = new System.Drawing.Size(161, 28);
            this.order_number_textbox.TabIndex = 2;
            this.order_number_textbox.Text = "Order Number";
            this.order_number_textbox.TextChanged += new System.EventHandler(this.order_number_textbox_TextChanged);
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Calibri", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.submit_button.Location = new System.Drawing.Point(467, 484);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(142, 44);
            this.submit_button.TabIndex = 4;
            this.submit_button.Text = "SUBMIT";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 152);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.ForeColor = System.Drawing.Color.Gray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 25);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Items...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Quantity_record_in_order
            // 
            this.Quantity_record_in_order.AutoSize = true;
            this.Quantity_record_in_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Quantity_record_in_order.Location = new System.Drawing.Point(315, 221);
            this.Quantity_record_in_order.Name = "Quantity_record_in_order";
            this.Quantity_record_in_order.Size = new System.Drawing.Size(17, 18);
            this.Quantity_record_in_order.TabIndex = 8;
            this.Quantity_record_in_order.Text = "0";
            this.Quantity_record_in_order.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(29, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Record required quantity:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(29, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Record arrived quantity:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Record_textBox
            // 
            this.Record_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Record_textBox.ForeColor = System.Drawing.Color.Gray;
            this.Record_textBox.Location = new System.Drawing.Point(309, 276);
            this.Record_textBox.Name = "Record_textBox";
            this.Record_textBox.Size = new System.Drawing.Size(23, 23);
            this.Record_textBox.TabIndex = 11;
            this.Record_textBox.Text = "0";
            // 
            // ADD_button
            // 
            this.ADD_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ADD_button.Location = new System.Drawing.Point(168, 343);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(134, 38);
            this.ADD_button.TabIndex = 12;
            this.ADD_button.Text = "ADD";
            this.ADD_button.UseVisualStyleBackColor = true;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // records_richTextBox1
            // 
            this.records_richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.records_richTextBox1.Location = new System.Drawing.Point(415, 175);
            this.records_richTextBox1.Name = "records_richTextBox1";
            this.records_richTextBox1.Size = new System.Drawing.Size(180, 206);
            this.records_richTextBox1.TabIndex = 13;
            this.records_richTextBox1.Text = "";
            this.records_richTextBox1.TextChanged += new System.EventHandler(this.records_richTextBox1_TextChanged);
            // 
            // main_menu_button
            // 
            this.main_menu_button.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu_button.Location = new System.Drawing.Point(12, 12);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(76, 26);
            this.main_menu_button.TabIndex = 6;
            this.main_menu_button.Text = "Back";
            this.main_menu_button.UseVisualStyleBackColor = true;
            this.main_menu_button.Click += new System.EventHandler(this.main_menu_button_Click);
            // 
            // Recieve_new_Inventiry_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(621, 540);
            this.Controls.Add(this.records_richTextBox1);
            this.Controls.Add(this.ADD_button);
            this.Controls.Add(this.Record_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantity_record_in_order);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.main_menu_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.order_number_textbox);
            this.Controls.Add(this.choose_order_button);
            this.Controls.Add(this.recieve_inventory_label);
            this.Name = "Recieve_new_Inventiry_Form1";
            this.Text = "Recieve_Inventiry_Form";
            this.Load += new System.EventHandler(this.Recieve_new_Inventiry_Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recieve_inventory_label;
        private System.Windows.Forms.Button choose_order_button;
        private System.Windows.Forms.TextBox order_number_textbox;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Quantity_record_in_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Record_textBox;
        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.RichTextBox records_richTextBox1;
        private System.Windows.Forms.Button main_menu_button;
    }
}