namespace WindowsFormsApplication1
{
    partial class Sale_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale_Form));
            this.Main_Menu_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.ADD_button = new System.Windows.Forms.Button();
            this.sale_label = new System.Windows.Forms.Label();
            this.barcode_textbox = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.total_cost_label = new System.Windows.Forms.Label();
            this.symbol_label = new System.Windows.Forms.Label();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.V1_Picture = new System.Windows.Forms.PictureBox();
            this.V2_Picture = new System.Windows.Forms.PictureBox();
            this.CheckID_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.Thanks_label = new System.Windows.Forms.Label();
            this.newCustumer_label = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V1_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V2_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Menu_button
            // 
            this.Main_Menu_button.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Main_Menu_button.Location = new System.Drawing.Point(6, 4);
            this.Main_Menu_button.Name = "Main_Menu_button";
            this.Main_Menu_button.Size = new System.Drawing.Size(105, 36);
            this.Main_Menu_button.TabIndex = 0;
            this.Main_Menu_button.Text = "Main Menu";
            this.Main_Menu_button.UseVisualStyleBackColor = true;
            this.Main_Menu_button.Click += new System.EventHandler(this.Main_Menu_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.submit_button.Location = new System.Drawing.Point(484, 500);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(100, 37);
            this.submit_button.TabIndex = 1;
            this.submit_button.Text = "SUBMIT";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // ADD_button
            // 
            this.ADD_button.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ADD_button.Location = new System.Drawing.Point(235, 199);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(98, 28);
            this.ADD_button.TabIndex = 2;
            this.ADD_button.Text = "ADD";
            this.ADD_button.UseVisualStyleBackColor = true;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // sale_label
            // 
            this.sale_label.AutoSize = true;
            this.sale_label.Font = new System.Drawing.Font("Aharoni", 24.23762F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sale_label.ForeColor = System.Drawing.Color.Goldenrod;
            this.sale_label.Location = new System.Drawing.Point(220, 14);
            this.sale_label.Name = "sale_label";
            this.sale_label.Size = new System.Drawing.Size(178, 34);
            this.sale_label.TabIndex = 3;
            this.sale_label.Text = "New Sale ";
            this.sale_label.Click += new System.EventHandler(this.sale_label_Click);
            // 
            // barcode_textbox
            // 
            this.barcode_textbox.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.barcode_textbox.ForeColor = System.Drawing.Color.Gray;
            this.barcode_textbox.Location = new System.Drawing.Point(178, 98);
            this.barcode_textbox.Name = "barcode_textbox";
            this.barcode_textbox.Size = new System.Drawing.Size(203, 26);
            this.barcode_textbox.TabIndex = 4;
            this.barcode_textbox.Text = "BarCode";
            this.barcode_textbox.TextChanged += new System.EventHandler(this.barcode_textbox_TextChanged);
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.quantity_label.Location = new System.Drawing.Point(222, 167);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(75, 21);
            this.quantity_label.TabIndex = 5;
            this.quantity_label.Text = "Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numericUpDown1.Location = new System.Drawing.Point(304, 165);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 28);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // total_cost_label
            // 
            this.total_cost_label.AutoSize = true;
            this.total_cost_label.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.total_cost_label.Location = new System.Drawing.Point(220, 461);
            this.total_cost_label.Name = "total_cost_label";
            this.total_cost_label.Size = new System.Drawing.Size(83, 21);
            this.total_cost_label.TabIndex = 8;
            this.total_cost_label.Text = "Total Cost:";
            // 
            // symbol_label
            // 
            this.symbol_label.AutoSize = true;
            this.symbol_label.Font = new System.Drawing.Font("Calibri", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.symbol_label.Location = new System.Drawing.Point(369, 460);
            this.symbol_label.Name = "symbol_label";
            this.symbol_label.Size = new System.Drawing.Size(23, 22);
            this.symbol_label.TabIndex = 9;
            this.symbol_label.Text = "₪";
            // 
            // price_textbox
            // 
            this.price_textbox.Font = new System.Drawing.Font("Calibri", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.price_textbox.Location = new System.Drawing.Point(309, 455);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(57, 32);
            this.price_textbox.TabIndex = 10;
            this.price_textbox.TextChanged += new System.EventHandler(this.price_textbox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 500);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 29);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Payment Method";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 149);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox1.Location = new System.Drawing.Point(27, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(557, 168);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID_TextBox.ForeColor = System.Drawing.Color.Gray;
            this.ID_TextBox.Location = new System.Drawing.Point(178, 63);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(203, 26);
            this.ID_TextBox.TabIndex = 16;
            this.ID_TextBox.Text = "Customer ID";
            this.ID_TextBox.TextChanged += new System.EventHandler(this.ID_TextBox_TextChanged);
            // 
            // V1_Picture
            // 
            this.V1_Picture.Image = ((System.Drawing.Image)(resources.GetObject("V1_Picture.Image")));
            this.V1_Picture.Location = new System.Drawing.Point(140, 61);
            this.V1_Picture.Name = "V1_Picture";
            this.V1_Picture.Size = new System.Drawing.Size(27, 30);
            this.V1_Picture.TabIndex = 18;
            this.V1_Picture.TabStop = false;
            this.V1_Picture.Click += new System.EventHandler(this.V1_Picture_Click);
            // 
            // V2_Picture
            // 
            this.V2_Picture.Image = ((System.Drawing.Image)(resources.GetObject("V2_Picture.Image")));
            this.V2_Picture.Location = new System.Drawing.Point(140, 100);
            this.V2_Picture.Name = "V2_Picture";
            this.V2_Picture.Size = new System.Drawing.Size(27, 30);
            this.V2_Picture.TabIndex = 19;
            this.V2_Picture.TabStop = false;
            this.V2_Picture.Click += new System.EventHandler(this.V2_Picture_Click);
            // 
            // CheckID_button
            // 
            this.CheckID_button.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CheckID_button.Location = new System.Drawing.Point(387, 64);
            this.CheckID_button.Name = "CheckID_button";
            this.CheckID_button.Size = new System.Drawing.Size(75, 23);
            this.CheckID_button.TabIndex = 20;
            this.CheckID_button.Text = "Check";
            this.CheckID_button.UseVisualStyleBackColor = true;
            this.CheckID_button.Click += new System.EventHandler(this.CheckID_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clear_button.Location = new System.Drawing.Point(510, 10);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(85, 26);
            this.clear_button.TabIndex = 22;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Thanks_label
            // 
            this.Thanks_label.AutoSize = true;
            this.Thanks_label.Font = new System.Drawing.Font("Aharoni", 47.76237F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Thanks_label.ForeColor = System.Drawing.Color.Goldenrod;
            this.Thanks_label.Location = new System.Drawing.Point(103, 242);
            this.Thanks_label.Name = "Thanks_label";
            this.Thanks_label.Size = new System.Drawing.Size(381, 66);
            this.Thanks_label.TabIndex = 23;
            this.Thanks_label.Text = "Thank You!";
            // 
            // newCustumer_label
            // 
            this.newCustumer_label.AutoSize = true;
            this.newCustumer_label.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newCustumer_label.LinkColor = System.Drawing.Color.Black;
            this.newCustumer_label.Location = new System.Drawing.Point(218, 128);
            this.newCustumer_label.Name = "newCustumer_label";
            this.newCustumer_label.Size = new System.Drawing.Size(132, 17);
            this.newCustumer_label.TabIndex = 24;
            this.newCustumer_label.TabStop = true;
            this.newCustumer_label.Text = "create new customer";
            this.newCustumer_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newCustumer_label_LinkClicked);
            // 
            // Sale_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(607, 560);
            this.Controls.Add(this.newCustumer_label);
            this.Controls.Add(this.Thanks_label);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.CheckID_button);
            this.Controls.Add(this.V2_Picture);
            this.Controls.Add(this.V1_Picture);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.symbol_label);
            this.Controls.Add(this.total_cost_label);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.barcode_textbox);
            this.Controls.Add(this.sale_label);
            this.Controls.Add(this.ADD_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.Main_Menu_button);
            this.Name = "Sale_Form";
            this.Text = "Sale_Form";
            this.Load += new System.EventHandler(this.Sale_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V1_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V2_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Main_Menu_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.Label sale_label;
        private System.Windows.Forms.TextBox barcode_textbox;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label total_cost_label;
        private System.Windows.Forms.Label symbol_label;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.PictureBox V1_Picture;
        private System.Windows.Forms.PictureBox V2_Picture;
        private System.Windows.Forms.Button CheckID_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label Thanks_label;
        private System.Windows.Forms.LinkLabel newCustumer_label;
    }
}