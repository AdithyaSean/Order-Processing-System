using System.Windows.Forms;

namespace Order_Processing_System
{
    partial class AddCustomers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCustomerID = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxTelephone = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone";
            // 
            // TextBoxCustomerID
            // 
            this.TextBoxCustomerID.Location = new System.Drawing.Point(94, 57);
            this.TextBoxCustomerID.Name = "TextBoxCustomerID";
            this.TextBoxCustomerID.Size = new System.Drawing.Size(86, 20);
            this.TextBoxCustomerID.TabIndex = 3;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(94, 83);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(86, 20);
            this.TextBoxName.TabIndex = 4;
            // 
            // TextBoxTelephone
            // 
            this.TextBoxTelephone.Location = new System.Drawing.Point(94, 108);
            this.TextBoxTelephone.Name = "TextBoxTelephone";
            this.TextBoxTelephone.Size = new System.Drawing.Size(86, 20);
            this.TextBoxTelephone.TabIndex = 5;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(116, 134);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(64, 20);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // AddCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 179);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxTelephone);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomers";
            this.ShowIcon = false;
            this.Text = "Add Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextBoxCustomerID;
        private TextBox TextBoxName;
        private TextBox TextBoxTelephone;
        private Button ButtonSave;
    }
}