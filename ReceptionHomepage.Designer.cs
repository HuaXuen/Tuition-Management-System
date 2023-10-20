namespace IOOP_Assignment
{
    partial class ReceptionHomepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionHomepage));
            this.groupBox_Manage = new System.Windows.Forms.GroupBox();
            this.label_Subject = new System.Windows.Forms.Label();
            this.listBox_Subject = new System.Windows.Forms.ListBox();
            this.button_Receipt = new System.Windows.Forms.Button();
            this.button_EditSubject = new System.Windows.Forms.Button();
            this.button_Enroll = new System.Windows.Forms.Button();
            this.button_EditDetails = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_StudentID = new System.Windows.Forms.Label();
            this.label_StudentName = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.pictureBox_Student = new System.Windows.Forms.PictureBox();
            this.groupBox_Fee = new System.Windows.Forms.GroupBox();
            this.label_FeeOutstand = new System.Windows.Forms.Label();
            this.label_FeePaid = new System.Windows.Forms.Label();
            this.label_FeeDue = new System.Windows.Forms.Label();
            this.groupBox_Detail = new System.Windows.Forms.GroupBox();
            this.label_IC = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Level = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Contact = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.pictureBox_Account = new System.Windows.Forms.PictureBox();
            this.label_Role = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.button_Profile = new System.Windows.Forms.Button();
            this.label_Logo = new System.Windows.Forms.Label();
            this.groupBox_Manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Student)).BeginInit();
            this.groupBox_Fee.SuspendLayout();
            this.groupBox_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Manage
            // 
            this.groupBox_Manage.Controls.Add(this.label_Subject);
            this.groupBox_Manage.Controls.Add(this.listBox_Subject);
            this.groupBox_Manage.Controls.Add(this.button_Receipt);
            this.groupBox_Manage.Controls.Add(this.button_EditSubject);
            this.groupBox_Manage.Controls.Add(this.button_Enroll);
            this.groupBox_Manage.Controls.Add(this.button_EditDetails);
            this.groupBox_Manage.Controls.Add(this.button_Delete);
            this.groupBox_Manage.Controls.Add(this.label_StudentID);
            this.groupBox_Manage.Controls.Add(this.label_StudentName);
            this.groupBox_Manage.Controls.Add(this.button_Search);
            this.groupBox_Manage.Controls.Add(this.textBox_Search);
            this.groupBox_Manage.Controls.Add(this.pictureBox_Student);
            this.groupBox_Manage.Controls.Add(this.groupBox_Fee);
            this.groupBox_Manage.Controls.Add(this.groupBox_Detail);
            this.groupBox_Manage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Manage.Location = new System.Drawing.Point(12, 50);
            this.groupBox_Manage.Name = "groupBox_Manage";
            this.groupBox_Manage.Size = new System.Drawing.Size(572, 340);
            this.groupBox_Manage.TabIndex = 0;
            this.groupBox_Manage.TabStop = false;
            this.groupBox_Manage.Text = "Student Manager";
            // 
            // label_Subject
            // 
            this.label_Subject.AutoSize = true;
            this.label_Subject.Location = new System.Drawing.Point(215, 199);
            this.label_Subject.Name = "label_Subject";
            this.label_Subject.Size = new System.Drawing.Size(98, 15);
            this.label_Subject.TabIndex = 8;
            this.label_Subject.Text = "Subjects Enrolled";
            // 
            // listBox_Subject
            // 
            this.listBox_Subject.Enabled = false;
            this.listBox_Subject.FormattingEnabled = true;
            this.listBox_Subject.ItemHeight = 15;
            this.listBox_Subject.Location = new System.Drawing.Point(215, 214);
            this.listBox_Subject.Name = "listBox_Subject";
            this.listBox_Subject.Size = new System.Drawing.Size(174, 79);
            this.listBox_Subject.TabIndex = 13;
            // 
            // button_Receipt
            // 
            this.button_Receipt.Location = new System.Drawing.Point(422, 305);
            this.button_Receipt.Name = "button_Receipt";
            this.button_Receipt.Size = new System.Drawing.Size(123, 23);
            this.button_Receipt.TabIndex = 12;
            this.button_Receipt.Text = "Generate Receipt";
            this.button_Receipt.UseVisualStyleBackColor = true;
            this.button_Receipt.Click += new System.EventHandler(this.button_Receipt_Click);
            // 
            // button_EditSubject
            // 
            this.button_EditSubject.Location = new System.Drawing.Point(242, 305);
            this.button_EditSubject.Name = "button_EditSubject";
            this.button_EditSubject.Size = new System.Drawing.Size(123, 23);
            this.button_EditSubject.TabIndex = 11;
            this.button_EditSubject.Text = "Edit Subjects";
            this.button_EditSubject.UseVisualStyleBackColor = true;
            this.button_EditSubject.Click += new System.EventHandler(this.button_EditSubject_Click);
            // 
            // button_Enroll
            // 
            this.button_Enroll.Location = new System.Drawing.Point(44, 21);
            this.button_Enroll.Name = "button_Enroll";
            this.button_Enroll.Size = new System.Drawing.Size(123, 29);
            this.button_Enroll.TabIndex = 10;
            this.button_Enroll.Text = "Enroll New Student";
            this.button_Enroll.UseVisualStyleBackColor = true;
            this.button_Enroll.Click += new System.EventHandler(this.button_Enroll_Click);
            // 
            // button_EditDetails
            // 
            this.button_EditDetails.Location = new System.Drawing.Point(82, 293);
            this.button_EditDetails.Name = "button_EditDetails";
            this.button_EditDetails.Size = new System.Drawing.Size(123, 35);
            this.button_EditDetails.TabIndex = 9;
            this.button_EditDetails.Text = "Edit Student Details";
            this.button_EditDetails.UseVisualStyleBackColor = true;
            this.button_EditDetails.Click += new System.EventHandler(this.button_EditDetails_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Delete.Location = new System.Drawing.Point(15, 303);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(65, 17);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Delete Record";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_StudentID
            // 
            this.label_StudentID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_StudentID.Location = new System.Drawing.Point(47, 260);
            this.label_StudentID.Name = "label_StudentID";
            this.label_StudentID.Size = new System.Drawing.Size(122, 21);
            this.label_StudentID.TabIndex = 7;
            this.label_StudentID.Text = "Student ID";
            this.label_StudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_StudentName
            // 
            this.label_StudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_StudentName.Location = new System.Drawing.Point(6, 239);
            this.label_StudentName.Name = "label_StudentName";
            this.label_StudentName.Size = new System.Drawing.Size(203, 21);
            this.label_StudentName.TabIndex = 6;
            this.label_StudentName.Text = "NAME";
            this.label_StudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(144, 56);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(65, 23);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(6, 57);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.PlaceholderText = "Search Student ID";
            this.textBox_Search.Size = new System.Drawing.Size(132, 23);
            this.textBox_Search.TabIndex = 4;
            // 
            // pictureBox_Student
            // 
            this.pictureBox_Student.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Student.Image")));
            this.pictureBox_Student.ImageLocation = "\"Resources/img_UserIcon.png\"";
            this.pictureBox_Student.Location = new System.Drawing.Point(31, 86);
            this.pictureBox_Student.Name = "pictureBox_Student";
            this.pictureBox_Student.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_Student.TabIndex = 1;
            this.pictureBox_Student.TabStop = false;
            // 
            // groupBox_Fee
            // 
            this.groupBox_Fee.Controls.Add(this.label_FeeOutstand);
            this.groupBox_Fee.Controls.Add(this.label_FeePaid);
            this.groupBox_Fee.Controls.Add(this.label_FeeDue);
            this.groupBox_Fee.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Fee.Location = new System.Drawing.Point(395, 199);
            this.groupBox_Fee.Name = "groupBox_Fee";
            this.groupBox_Fee.Size = new System.Drawing.Size(171, 100);
            this.groupBox_Fee.TabIndex = 3;
            this.groupBox_Fee.TabStop = false;
            this.groupBox_Fee.Text = "Fees";
            // 
            // label_FeeOutstand
            // 
            this.label_FeeOutstand.AutoSize = true;
            this.label_FeeOutstand.Location = new System.Drawing.Point(6, 71);
            this.label_FeeOutstand.Name = "label_FeeOutstand";
            this.label_FeeOutstand.Size = new System.Drawing.Size(79, 15);
            this.label_FeeOutstand.TabIndex = 13;
            this.label_FeeOutstand.Text = "Outstanding: ";
            // 
            // label_FeePaid
            // 
            this.label_FeePaid.AutoSize = true;
            this.label_FeePaid.Location = new System.Drawing.Point(6, 46);
            this.label_FeePaid.Name = "label_FeePaid";
            this.label_FeePaid.Size = new System.Drawing.Size(65, 15);
            this.label_FeePaid.TabIndex = 12;
            this.label_FeePaid.Text = "Total Paid: ";
            // 
            // label_FeeDue
            // 
            this.label_FeeDue.AutoSize = true;
            this.label_FeeDue.Location = new System.Drawing.Point(6, 22);
            this.label_FeeDue.Name = "label_FeeDue";
            this.label_FeeDue.Size = new System.Drawing.Size(64, 15);
            this.label_FeeDue.TabIndex = 11;
            this.label_FeeDue.Text = "Total Due: ";
            // 
            // groupBox_Detail
            // 
            this.groupBox_Detail.Controls.Add(this.label_IC);
            this.groupBox_Detail.Controls.Add(this.label_Address);
            this.groupBox_Detail.Controls.Add(this.label_Level);
            this.groupBox_Detail.Controls.Add(this.label_Date);
            this.groupBox_Detail.Controls.Add(this.label_Contact);
            this.groupBox_Detail.Controls.Add(this.label_Email);
            this.groupBox_Detail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Detail.Location = new System.Drawing.Point(215, 22);
            this.groupBox_Detail.Name = "groupBox_Detail";
            this.groupBox_Detail.Size = new System.Drawing.Size(351, 171);
            this.groupBox_Detail.TabIndex = 1;
            this.groupBox_Detail.TabStop = false;
            this.groupBox_Detail.Text = "Student Details";
            // 
            // label_IC
            // 
            this.label_IC.AutoSize = true;
            this.label_IC.Location = new System.Drawing.Point(6, 124);
            this.label_IC.Name = "label_IC";
            this.label_IC.Size = new System.Drawing.Size(68, 15);
            this.label_IC.TabIndex = 7;
            this.label_IC.Text = "IC Number:";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(6, 102);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(52, 15);
            this.label_Address.TabIndex = 6;
            this.label_Address.Text = "Address:";
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.Location = new System.Drawing.Point(6, 59);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(37, 15);
            this.label_Level.TabIndex = 5;
            this.label_Level.Text = "Level:";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(6, 80);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(81, 15);
            this.label_Date.TabIndex = 2;
            this.label_Date.Text = "Date Enrolled:";
            // 
            // label_Contact
            // 
            this.label_Contact.AutoSize = true;
            this.label_Contact.Location = new System.Drawing.Point(6, 38);
            this.label_Contact.Name = "label_Contact";
            this.label_Contact.Size = new System.Drawing.Size(98, 15);
            this.label_Contact.TabIndex = 1;
            this.label_Contact.Text = "Contact Number:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(6, 18);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(44, 15);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "E-mail:";
            // 
            // pictureBox_Account
            // 
            this.pictureBox_Account.Image = global::IOOP_Assignment.Properties.Resources.img_5251621;
            this.pictureBox_Account.ImageLocation = "";
            this.pictureBox_Account.Location = new System.Drawing.Point(532, 7);
            this.pictureBox_Account.Name = "pictureBox_Account";
            this.pictureBox_Account.Size = new System.Drawing.Size(45, 45);
            this.pictureBox_Account.TabIndex = 0;
            this.pictureBox_Account.TabStop = false;
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Role.Location = new System.Drawing.Point(441, 7);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(85, 21);
            this.label_Role.TabIndex = 13;
            this.label_Role.Text = "Reception";
            // 
            // label_Username
            // 
            this.label_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Username.Location = new System.Drawing.Point(434, 32);
            this.label_Username.Name = "label_Username";
            this.label_Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Username.Size = new System.Drawing.Size(92, 15);
            this.label_Username.TabIndex = 8;
            this.label_Username.Text = "NAME";
            this.label_Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Profile
            // 
            this.button_Profile.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Profile.Location = new System.Drawing.Point(362, 21);
            this.button_Profile.Name = "button_Profile";
            this.button_Profile.Size = new System.Drawing.Size(73, 19);
            this.button_Profile.TabIndex = 13;
            this.button_Profile.Text = "Edit Profile";
            this.button_Profile.UseVisualStyleBackColor = true;
            this.button_Profile.Click += new System.EventHandler(this.button_Profile_Click);
            // 
            // label_Logo
            // 
            this.label_Logo.AutoSize = true;
            this.label_Logo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Logo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_Logo.Location = new System.Drawing.Point(12, 7);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(62, 37);
            this.label_Logo.TabIndex = 13;
            this.label_Logo.Text = "ETC";
            // 
            // ReceptionHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 400);
            this.Controls.Add(this.label_Logo);
            this.Controls.Add(this.button_Profile);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.pictureBox_Account);
            this.Controls.Add(this.groupBox_Manage);
            this.Name = "ReceptionHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox_Manage.ResumeLayout(false);
            this.groupBox_Manage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Student)).EndInit();
            this.groupBox_Fee.ResumeLayout(false);
            this.groupBox_Fee.PerformLayout();
            this.groupBox_Detail.ResumeLayout(false);
            this.groupBox_Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox_Manage;
        private PictureBox pictureBox_Account;
        private PictureBox pictureBox_Student;
        private GroupBox groupBox_Fee;
        private GroupBox groupBox_Detail;
        private Button button_Search;
        private TextBox textBox_Search;
        private Label label_StudentName;
        private Button button_Enroll;
        private Button button_EditDetails;
        private Button button_Delete;
        private Label label_StudentID;
        private Label label_Email;
        private Label label_IC;
        private Label label_Address;
        private Label label_Level;
        private Label label_Date;
        private Label label_Contact;
        private Button button_Receipt;
        private Button button_EditSubject;
        private Label label_FeeOutstand;
        private Label label_FeePaid;
        private Label label_FeeDue;
        private Label label_Role;
        private Label label_Username;
        private Button button_Profile;
        private Label label_Logo;
        private Label label_Subject;
        private ListBox listBox_Subject;
    }
}