namespace WindowsFormsApplication1
{
    partial class Recieve_new_Inventiry_Form2
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
            this.recieve_inventory_label = new System.Windows.Forms.Label();
            this.main_menu_button = new System.Windows.Forms.Button();
            this.records_richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // recieve_inventory_label
            // 
            this.recieve_inventory_label.AutoSize = true;
            this.recieve_inventory_label.Font = new System.Drawing.Font("Aharoni", 22.09901F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.recieve_inventory_label.ForeColor = System.Drawing.Color.Goldenrod;
            this.recieve_inventory_label.Location = new System.Drawing.Point(155, 37);
            this.recieve_inventory_label.Name = "recieve_inventory_label";
            this.recieve_inventory_label.Size = new System.Drawing.Size(368, 32);
            this.recieve_inventory_label.TabIndex = 1;
            this.recieve_inventory_label.Text = "Recieve New Inventory";
            // 
            // main_menu_button
            // 
            this.main_menu_button.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.main_menu_button.Location = new System.Drawing.Point(266, 374);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(120, 35);
            this.main_menu_button.TabIndex = 7;
            this.main_menu_button.Text = "Main Menu";
            this.main_menu_button.UseVisualStyleBackColor = true;
            this.main_menu_button.Click += new System.EventHandler(this.main_menu_button_Click);
            // 
            // records_richTextBox2
            // 
            this.records_richTextBox2.BackColor = System.Drawing.Color.White;
            this.records_richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.records_richTextBox2.Location = new System.Drawing.Point(55, 95);
            this.records_richTextBox2.Name = "records_richTextBox2";
            this.records_richTextBox2.Size = new System.Drawing.Size(563, 225);
            this.records_richTextBox2.TabIndex = 14;
            this.records_richTextBox2.Text = "";
            this.records_richTextBox2.TextChanged += new System.EventHandler(this.records_richTextBox2_TextChanged);
            // 
            // Recieve_new_Inventiry_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(672, 471);
            this.Controls.Add(this.records_richTextBox2);
            this.Controls.Add(this.main_menu_button);
            this.Controls.Add(this.recieve_inventory_label);
            this.Name = "Recieve_new_Inventiry_Form2";
            this.Text = "Recieve_Inventiry_Form2";
            this.Load += new System.EventHandler(this.Recieve_new_Inventiry_Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recieve_inventory_label;
        private System.Windows.Forms.Button main_menu_button;
        private System.Windows.Forms.RichTextBox records_richTextBox2;
    }
}