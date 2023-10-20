namespace IOOP_Assignment
{
    partial class ReceptionReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionReceipt));
            this.label_Logo = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Role = new System.Windows.Forms.Label();
            this.pictureBox_Account = new System.Windows.Forms.PictureBox();
            this.groupBox_Receipt = new System.Windows.Forms.GroupBox();
            this.label_Paid = new System.Windows.Forms.Label();
            this.label_Due = new System.Windows.Forms.Label();
            this.label_ETC = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Sign = new System.Windows.Forms.Label();
            this.label_Received = new System.Windows.Forms.Label();
            this.label_ToReceive = new System.Windows.Forms.Label();
            this.label_PaidTo = new System.Windows.Forms.Label();
            this.label_PaidBy = new System.Windows.Forms.Label();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Account)).BeginInit();
            this.groupBox_Receipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Logo
            // 
            this.label_Logo.AutoSize = true;
            this.label_Logo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Logo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_Logo.Location = new System.Drawing.Point(12, 9);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(62, 37);
            this.label_Logo.TabIndex = 26;
            this.label_Logo.Text = "ETC";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(241, 34);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(41, 15);
            this.label_Username.TabIndex = 25;
            this.label_Username.Text = "NAME";
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Role.Location = new System.Drawing.Point(219, 9);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(85, 21);
            this.label_Role.TabIndex = 28;
            this.label_Role.Text = "Reception";
            // 
            // pictureBox_Account
            // 
            this.pictureBox_Account.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Account.Image")));
            this.pictureBox_Account.ImageLocation = "\"Resources/img_UserIcon.png\"";
            this.pictureBox_Account.Location = new System.Drawing.Point(310, 9);
            this.pictureBox_Account.Name = "pictureBox_Account";
            this.pictureBox_Account.Size = new System.Drawing.Size(45, 45);
            this.pictureBox_Account.TabIndex = 24;
            this.pictureBox_Account.TabStop = false;
            // 
            // groupBox_Receipt
            // 
            this.groupBox_Receipt.Controls.Add(this.label_Paid);
            this.groupBox_Receipt.Controls.Add(this.label_Due);
            this.groupBox_Receipt.Controls.Add(this.label_ETC);
            this.groupBox_Receipt.Controls.Add(this.label_Name);
            this.groupBox_Receipt.Controls.Add(this.label_Sign);
            this.groupBox_Receipt.Controls.Add(this.label_Received);
            this.groupBox_Receipt.Controls.Add(this.label_ToReceive);
            this.groupBox_Receipt.Controls.Add(this.label_PaidTo);
            this.groupBox_Receipt.Controls.Add(this.label_PaidBy);
            this.groupBox_Receipt.Location = new System.Drawing.Point(13, 60);
            this.groupBox_Receipt.Name = "groupBox_Receipt";
            this.groupBox_Receipt.Size = new System.Drawing.Size(342, 234);
            this.groupBox_Receipt.TabIndex = 29;
            this.groupBox_Receipt.TabStop = false;
            this.groupBox_Receipt.Text = "Receipt";
            // 
            // label_Paid
            // 
            this.label_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Paid.Location = new System.Drawing.Point(173, 109);
            this.label_Paid.Name = "label_Paid";
            this.label_Paid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Paid.Size = new System.Drawing.Size(163, 15);
            this.label_Paid.TabIndex = 8;
            this.label_Paid.Text = "$88888";
            this.label_Paid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Due
            // 
            this.label_Due.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Due.Location = new System.Drawing.Point(191, 81);
            this.label_Due.Name = "label_Due";
            this.label_Due.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Due.Size = new System.Drawing.Size(145, 15);
            this.label_Due.TabIndex = 7;
            this.label_Due.Text = "$88888";
            this.label_Due.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ETC
            // 
            this.label_ETC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ETC.AutoSize = true;
            this.label_ETC.Location = new System.Drawing.Point(204, 56);
            this.label_ETC.Name = "label_ETC";
            this.label_ETC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_ETC.Size = new System.Drawing.Size(132, 15);
            this.label_ETC.TabIndex = 6;
            this.label_ETC.Text = "Excellent Tuition Centre";
            this.label_ETC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Name
            // 
            this.label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Name.Location = new System.Drawing.Point(154, 29);
            this.label_Name.Name = "label_Name";
            this.label_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Name.Size = new System.Drawing.Size(182, 15);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "Student Name";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Sign
            // 
            this.label_Sign.AutoSize = true;
            this.label_Sign.Location = new System.Drawing.Point(7, 136);
            this.label_Sign.Name = "label_Sign";
            this.label_Sign.Size = new System.Drawing.Size(60, 15);
            this.label_Sign.TabIndex = 4;
            this.label_Sign.Text = "Signature:";
            // 
            // label_Received
            // 
            this.label_Received.AutoSize = true;
            this.label_Received.Location = new System.Drawing.Point(7, 109);
            this.label_Received.Name = "label_Received";
            this.label_Received.Size = new System.Drawing.Size(132, 15);
            this.label_Received.TabIndex = 3;
            this.label_Received.Text = "Total Amount Received:";
            // 
            // label_ToReceive
            // 
            this.label_ToReceive.AutoSize = true;
            this.label_ToReceive.Location = new System.Drawing.Point(7, 81);
            this.label_ToReceive.Name = "label_ToReceive";
            this.label_ToReceive.Size = new System.Drawing.Size(139, 15);
            this.label_ToReceive.TabIndex = 2;
            this.label_ToReceive.Text = "Total Amount to Receive:";
            // 
            // label_PaidTo
            // 
            this.label_PaidTo.AutoSize = true;
            this.label_PaidTo.Location = new System.Drawing.Point(6, 56);
            this.label_PaidTo.Name = "label_PaidTo";
            this.label_PaidTo.Size = new System.Drawing.Size(48, 15);
            this.label_PaidTo.TabIndex = 1;
            this.label_PaidTo.Text = "Paid To:";
            // 
            // label_PaidBy
            // 
            this.label_PaidBy.AutoSize = true;
            this.label_PaidBy.Location = new System.Drawing.Point(6, 29);
            this.label_PaidBy.Name = "label_PaidBy";
            this.label_PaidBy.Size = new System.Drawing.Size(49, 15);
            this.label_PaidBy.TabIndex = 0;
            this.label_PaidBy.Text = "Paid By:";
            // 
            // button_Print
            // 
            this.button_Print.Location = new System.Drawing.Point(216, 300);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(111, 23);
            this.button_Print.TabIndex = 31;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(38, 300);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(111, 23);
            this.button_Back.TabIndex = 30;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // ReceptionReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 335);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.groupBox_Receipt);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_Logo);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.pictureBox_Account);
            this.Name = "ReceptionReceipt";
            this.Text = "ReceptionReceipt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Account)).EndInit();
            this.groupBox_Receipt.ResumeLayout(false);
            this.groupBox_Receipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Logo;
        private Label label_Username;
        private Label label_Role;
        private PictureBox pictureBox_Account;
        private GroupBox groupBox_Receipt;
        private Label label_Received;
        private Label label_ToReceive;
        private Label label_PaidTo;
        private Label label_PaidBy;
        private Label label_Sign;
        private Label label_Paid;
        private Label label_Due;
        private Label label_ETC;
        private Label label_Name;
        private Button button_Print;
        private Button button_Back;
    }
}