namespace IOOP_Assignment
{
    partial class addStaff
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.txtBxStaffD = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Contact);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.txtBxStaffD);
            this.groupBox1.Controls.Add(this.txtBxName);
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblStaffID);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(31, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Staff";
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Location = new System.Drawing.Point(90, 141);
            this.textBox_Contact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.PlaceholderText = "Contact Number";
            this.textBox_Contact.Size = new System.Drawing.Size(301, 27);
            this.textBox_Contact.TabIndex = 19;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(90, 93);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.PlaceholderText = "Email";
            this.textBox_Email.Size = new System.Drawing.Size(301, 27);
            this.textBox_Email.TabIndex = 18;
            // 
            // txtBxStaffD
            // 
            this.txtBxStaffD.Enabled = false;
            this.txtBxStaffD.Location = new System.Drawing.Point(90, 59);
            this.txtBxStaffD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxStaffD.Name = "txtBxStaffD";
            this.txtBxStaffD.PlaceholderText = "ID";
            this.txtBxStaffD.ReadOnly = true;
            this.txtBxStaffD.Size = new System.Drawing.Size(301, 27);
            this.txtBxStaffD.TabIndex = 17;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(90, 27);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.PlaceholderText = "Name";
            this.txtBxName.Size = new System.Drawing.Size(301, 27);
            this.txtBxName.TabIndex = 16;
            // 
            // lblContact
            // 
            this.lblContact.Location = new System.Drawing.Point(12, 129);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(64, 43);
            this.lblContact.TabIndex = 15;
            this.lblContact.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 20);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(12, 63);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(27, 20);
            this.lblStaffID.TabIndex = 13;
            this.lblStaffID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // addTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(481, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "addTutor";
            this.Text = "addTutor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_Contact;
        private TextBox textBox_Email;
        private TextBox txtBxStaffD;
        private TextBox txtBxName;
        private Label lblContact;
        private Label lblEmail;
        private Label lblStaffID;
        private Label lblName;
    }
}