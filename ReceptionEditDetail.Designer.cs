namespace IOOP_Assignment
{
    partial class ReceptionEditDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionEditDetail));
            this.label_Logo = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Role = new System.Windows.Forms.Label();
            this.pictureBox_Account = new System.Windows.Forms.PictureBox();
            this.groupBox_EditDetails = new System.Windows.Forms.GroupBox();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Month = new System.Windows.Forms.TextBox();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.comboBox_Level = new System.Windows.Forms.ComboBox();
            this.textBox_IC = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Day = new System.Windows.Forms.TextBox();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_StudentID = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_IC = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Level = new System.Windows.Forms.Label();
            this.label_Contact = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_StudentID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Account)).BeginInit();
            this.groupBox_EditDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Logo
            // 
            this.label_Logo.AutoSize = true;
            this.label_Logo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Logo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_Logo.Location = new System.Drawing.Point(9, 12);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(77, 46);
            this.label_Logo.TabIndex = 16;
            this.label_Logo.Text = "ETC";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(271, 45);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(51, 20);
            this.label_Username.TabIndex = 15;
            this.label_Username.Text = "NAME";
            this.label_Username.Click += new System.EventHandler(this.label_Username_Click);
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Role.Location = new System.Drawing.Point(246, 12);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(102, 28);
            this.label_Role.TabIndex = 18;
            this.label_Role.Text = "Reception";
            // 
            // pictureBox_Account
            // 
            this.pictureBox_Account.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Account.Image")));
            this.pictureBox_Account.ImageLocation = "\"Resources/img_UserIcon.png\"";
            this.pictureBox_Account.Location = new System.Drawing.Point(350, 9);
            this.pictureBox_Account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Account.Name = "pictureBox_Account";
            this.pictureBox_Account.Size = new System.Drawing.Size(51, 60);
            this.pictureBox_Account.TabIndex = 14;
            this.pictureBox_Account.TabStop = false;
            // 
            // groupBox_EditDetails
            // 
            this.groupBox_EditDetails.Controls.Add(this.button_Confirm);
            this.groupBox_EditDetails.Controls.Add(this.button_Cancel);
            this.groupBox_EditDetails.Controls.Add(this.textBox_Month);
            this.groupBox_EditDetails.Controls.Add(this.textBox_Year);
            this.groupBox_EditDetails.Controls.Add(this.comboBox_Level);
            this.groupBox_EditDetails.Controls.Add(this.textBox_IC);
            this.groupBox_EditDetails.Controls.Add(this.textBox_Address);
            this.groupBox_EditDetails.Controls.Add(this.textBox_Day);
            this.groupBox_EditDetails.Controls.Add(this.textBox_Contact);
            this.groupBox_EditDetails.Controls.Add(this.textBox_Email);
            this.groupBox_EditDetails.Controls.Add(this.textBox_StudentID);
            this.groupBox_EditDetails.Controls.Add(this.textBox_Name);
            this.groupBox_EditDetails.Controls.Add(this.label_IC);
            this.groupBox_EditDetails.Controls.Add(this.label_Address);
            this.groupBox_EditDetails.Controls.Add(this.label_Date);
            this.groupBox_EditDetails.Controls.Add(this.label_Level);
            this.groupBox_EditDetails.Controls.Add(this.label_Contact);
            this.groupBox_EditDetails.Controls.Add(this.label_Email);
            this.groupBox_EditDetails.Controls.Add(this.label_StudentID);
            this.groupBox_EditDetails.Controls.Add(this.label_Name);
            this.groupBox_EditDetails.Location = new System.Drawing.Point(9, 69);
            this.groupBox_EditDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_EditDetails.Name = "groupBox_EditDetails";
            this.groupBox_EditDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_EditDetails.Size = new System.Drawing.Size(393, 399);
            this.groupBox_EditDetails.TabIndex = 19;
            this.groupBox_EditDetails.TabStop = false;
            this.groupBox_EditDetails.Text = "Edit Details";
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(237, 360);
            this.button_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(127, 31);
            this.button_Confirm.TabIndex = 21;
            this.button_Confirm.Text = "Confirm Changes";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(33, 360);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(127, 31);
            this.button_Cancel.TabIndex = 20;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_Month
            // 
            this.textBox_Month.Location = new System.Drawing.Point(134, 236);
            this.textBox_Month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Month.Name = "textBox_Month";
            this.textBox_Month.PlaceholderText = "Month";
            this.textBox_Month.Size = new System.Drawing.Size(42, 27);
            this.textBox_Month.TabIndex = 19;
            this.textBox_Month.TextChanged += new System.EventHandler(this.textBox_Date_TextChanged);
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(183, 236);
            this.textBox_Year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.PlaceholderText = "Year";
            this.textBox_Year.Size = new System.Drawing.Size(85, 27);
            this.textBox_Year.TabIndex = 18;
            this.textBox_Year.TextChanged += new System.EventHandler(this.textBox_Date_TextChanged);
            // 
            // comboBox_Level
            // 
            this.comboBox_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Level.FormattingEnabled = true;
            this.comboBox_Level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboBox_Level.Location = new System.Drawing.Point(85, 187);
            this.comboBox_Level.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Level.Name = "comboBox_Level";
            this.comboBox_Level.Size = new System.Drawing.Size(62, 28);
            this.comboBox_Level.TabIndex = 16;
            // 
            // textBox_IC
            // 
            this.textBox_IC.Location = new System.Drawing.Point(85, 308);
            this.textBox_IC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_IC.Name = "textBox_IC";
            this.textBox_IC.PlaceholderText = "IC Number";
            this.textBox_IC.Size = new System.Drawing.Size(301, 27);
            this.textBox_IC.TabIndex = 15;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(85, 275);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.PlaceholderText = "Address";
            this.textBox_Address.Size = new System.Drawing.Size(301, 27);
            this.textBox_Address.TabIndex = 14;
            // 
            // textBox_Day
            // 
            this.textBox_Day.Location = new System.Drawing.Point(85, 236);
            this.textBox_Day.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Day.Name = "textBox_Day";
            this.textBox_Day.PlaceholderText = "Day";
            this.textBox_Day.Size = new System.Drawing.Size(42, 27);
            this.textBox_Day.TabIndex = 13;
            this.textBox_Day.TextChanged += new System.EventHandler(this.textBox_Date_TextChanged);
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Location = new System.Drawing.Point(85, 147);
            this.textBox_Contact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.PlaceholderText = "Contact Number";
            this.textBox_Contact.Size = new System.Drawing.Size(301, 27);
            this.textBox_Contact.TabIndex = 11;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(85, 99);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.PlaceholderText = "Email";
            this.textBox_Email.Size = new System.Drawing.Size(301, 27);
            this.textBox_Email.TabIndex = 10;
            // 
            // textBox_StudentID
            // 
            this.textBox_StudentID.Enabled = false;
            this.textBox_StudentID.Location = new System.Drawing.Point(85, 65);
            this.textBox_StudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_StudentID.Name = "textBox_StudentID";
            this.textBox_StudentID.PlaceholderText = "StudentID";
            this.textBox_StudentID.ReadOnly = true;
            this.textBox_StudentID.Size = new System.Drawing.Size(301, 27);
            this.textBox_StudentID.TabIndex = 9;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(85, 33);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.PlaceholderText = "Name";
            this.textBox_Name.Size = new System.Drawing.Size(301, 27);
            this.textBox_Name.TabIndex = 8;
            // 
            // label_IC
            // 
            this.label_IC.AutoSize = true;
            this.label_IC.Location = new System.Drawing.Point(7, 312);
            this.label_IC.Name = "label_IC";
            this.label_IC.Size = new System.Drawing.Size(83, 20);
            this.label_IC.TabIndex = 7;
            this.label_IC.Text = "IC Number:";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(7, 279);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(65, 20);
            this.label_Address.TabIndex = 6;
            this.label_Address.Text = "Address:";
            // 
            // label_Date
            // 
            this.label_Date.Location = new System.Drawing.Point(7, 224);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(64, 43);
            this.label_Date.TabIndex = 5;
            this.label_Date.Text = "Date Enrolled:";
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.Location = new System.Drawing.Point(7, 191);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(46, 20);
            this.label_Level.TabIndex = 4;
            this.label_Level.Text = "Level:";
            // 
            // label_Contact
            // 
            this.label_Contact.Location = new System.Drawing.Point(7, 135);
            this.label_Contact.Name = "label_Contact";
            this.label_Contact.Size = new System.Drawing.Size(64, 43);
            this.label_Contact.TabIndex = 3;
            this.label_Contact.Text = "Contact Number:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(7, 103);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(55, 20);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "E-mail:";
            // 
            // label_StudentID
            // 
            this.label_StudentID.AutoSize = true;
            this.label_StudentID.Location = new System.Drawing.Point(7, 69);
            this.label_StudentID.Name = "label_StudentID";
            this.label_StudentID.Size = new System.Drawing.Size(78, 20);
            this.label_StudentID.TabIndex = 1;
            this.label_StudentID.Text = "StudentID:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(7, 37);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(52, 20);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name:";
            // 
            // ReceptionEditDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 480);
            this.Controls.Add(this.groupBox_EditDetails);
            this.Controls.Add(this.label_Logo);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.pictureBox_Account);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReceptionEditDetail";
            this.Text = "ReceptionEditDetail";
            this.Load += new System.EventHandler(this.ReceptionEditDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Account)).EndInit();
            this.groupBox_EditDetails.ResumeLayout(false);
            this.groupBox_EditDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Logo;
        private Label label_Username;
        private Label label_Role;
        private PictureBox pictureBox_Account;
        private GroupBox groupBox_EditDetails;
        private TextBox textBox_Month;
        private TextBox textBox_Year;
        private ComboBox comboBox_Level;
        private TextBox textBox_IC;
        private TextBox textBox_Address;
        private TextBox textBox_Day;
        private TextBox textBox_Contact;
        private TextBox textBox_Email;
        private TextBox textBox_StudentID;
        private TextBox textBox_Name;
        private Label label_IC;
        private Label label_Address;
        private Label label_Date;
        private Label label_Level;
        private Label label_Contact;
        private Label label_Email;
        private Label label_StudentID;
        private Label label_Name;
        private Button button_Confirm;
        private Button button_Cancel;
    }
}