namespace IOOP_Assignment
{
    partial class ReceptionEditSubjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionEditSubjects));
            this.label_Logo = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Role = new System.Windows.Forms.Label();
            this.pictureBox_Account = new System.Windows.Forms.PictureBox();
            this.groupBox_EditSubject = new System.Windows.Forms.GroupBox();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.listBox_Subjects = new System.Windows.Forms.ListBox();
            this.label_Enrolled = new System.Windows.Forms.Label();
            this.groupBox_CheckBox = new System.Windows.Forms.GroupBox();
            this.checkBox_Geography = new System.Windows.Forms.CheckBox();
            this.checkBox_History = new System.Windows.Forms.CheckBox();
            this.checkBox_English = new System.Windows.Forms.CheckBox();
            this.checkBox_Math = new System.Windows.Forms.CheckBox();
            this.checkBox_Science = new System.Windows.Forms.CheckBox();
            this.label_Student = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Account)).BeginInit();
            this.groupBox_EditSubject.SuspendLayout();
            this.groupBox_CheckBox.SuspendLayout();
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
            this.label_Logo.TabIndex = 21;
            this.label_Logo.Text = "ETC";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(241, 34);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(41, 15);
            this.label_Username.TabIndex = 20;
            this.label_Username.Text = "NAME";
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Role.Location = new System.Drawing.Point(219, 9);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(85, 21);
            this.label_Role.TabIndex = 23;
            this.label_Role.Text = "Reception";
            // 
            // pictureBox_Account
            // 
            this.pictureBox_Account.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Account.Image")));
            this.pictureBox_Account.ImageLocation = "\"Resources/img_UserIcon.png\"";
            this.pictureBox_Account.Location = new System.Drawing.Point(310, 9);
            this.pictureBox_Account.Name = "pictureBox_Account";
            this.pictureBox_Account.Size = new System.Drawing.Size(45, 45);
            this.pictureBox_Account.TabIndex = 19;
            this.pictureBox_Account.TabStop = false;
            // 
            // groupBox_EditSubject
            // 
            this.groupBox_EditSubject.Controls.Add(this.button_Confirm);
            this.groupBox_EditSubject.Controls.Add(this.button_Cancel);
            this.groupBox_EditSubject.Controls.Add(this.listBox_Subjects);
            this.groupBox_EditSubject.Controls.Add(this.label_Enrolled);
            this.groupBox_EditSubject.Controls.Add(this.groupBox_CheckBox);
            this.groupBox_EditSubject.Controls.Add(this.label_Student);
            this.groupBox_EditSubject.Location = new System.Drawing.Point(13, 60);
            this.groupBox_EditSubject.Name = "groupBox_EditSubject";
            this.groupBox_EditSubject.Size = new System.Drawing.Size(342, 292);
            this.groupBox_EditSubject.TabIndex = 24;
            this.groupBox_EditSubject.TabStop = false;
            this.groupBox_EditSubject.Text = "Edit Student Subjects";
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(206, 263);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(111, 23);
            this.button_Confirm.TabIndex = 29;
            this.button_Confirm.Text = "Confirm Changes";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(28, 263);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(111, 23);
            this.button_Cancel.TabIndex = 28;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // listBox_Subjects
            // 
            this.listBox_Subjects.FormattingEnabled = true;
            this.listBox_Subjects.ItemHeight = 15;
            this.listBox_Subjects.Location = new System.Drawing.Point(173, 75);
            this.listBox_Subjects.Name = "listBox_Subjects";
            this.listBox_Subjects.Size = new System.Drawing.Size(163, 154);
            this.listBox_Subjects.TabIndex = 27;
            // 
            // label_Enrolled
            // 
            this.label_Enrolled.AutoSize = true;
            this.label_Enrolled.Location = new System.Drawing.Point(173, 57);
            this.label_Enrolled.Name = "label_Enrolled";
            this.label_Enrolled.Size = new System.Drawing.Size(97, 15);
            this.label_Enrolled.TabIndex = 26;
            this.label_Enrolled.Text = "Enrolled Subjects";
            // 
            // groupBox_CheckBox
            // 
            this.groupBox_CheckBox.Controls.Add(this.checkBox_Geography);
            this.groupBox_CheckBox.Controls.Add(this.checkBox_History);
            this.groupBox_CheckBox.Controls.Add(this.checkBox_English);
            this.groupBox_CheckBox.Controls.Add(this.checkBox_Math);
            this.groupBox_CheckBox.Controls.Add(this.checkBox_Science);
            this.groupBox_CheckBox.Location = new System.Drawing.Point(15, 57);
            this.groupBox_CheckBox.Name = "groupBox_CheckBox";
            this.groupBox_CheckBox.Size = new System.Drawing.Size(152, 185);
            this.groupBox_CheckBox.TabIndex = 25;
            this.groupBox_CheckBox.TabStop = false;
            this.groupBox_CheckBox.Text = "Subjects";
            // 
            // checkBox_Geography
            // 
            this.checkBox_Geography.AutoSize = true;
            this.checkBox_Geography.Location = new System.Drawing.Point(6, 122);
            this.checkBox_Geography.Name = "checkBox_Geography";
            this.checkBox_Geography.Size = new System.Drawing.Size(84, 19);
            this.checkBox_Geography.TabIndex = 4;
            this.checkBox_Geography.Text = "Geography";
            this.checkBox_Geography.UseVisualStyleBackColor = true;
            this.checkBox_Geography.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // checkBox_History
            // 
            this.checkBox_History.AutoSize = true;
            this.checkBox_History.Location = new System.Drawing.Point(6, 97);
            this.checkBox_History.Name = "checkBox_History";
            this.checkBox_History.Size = new System.Drawing.Size(64, 19);
            this.checkBox_History.TabIndex = 3;
            this.checkBox_History.Text = "History";
            this.checkBox_History.UseVisualStyleBackColor = true;
            this.checkBox_History.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // checkBox_English
            // 
            this.checkBox_English.AutoSize = true;
            this.checkBox_English.Location = new System.Drawing.Point(6, 72);
            this.checkBox_English.Name = "checkBox_English";
            this.checkBox_English.Size = new System.Drawing.Size(64, 19);
            this.checkBox_English.TabIndex = 2;
            this.checkBox_English.Text = "English";
            this.checkBox_English.UseVisualStyleBackColor = true;
            this.checkBox_English.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // checkBox_Math
            // 
            this.checkBox_Math.AutoSize = true;
            this.checkBox_Math.Location = new System.Drawing.Point(6, 47);
            this.checkBox_Math.Name = "checkBox_Math";
            this.checkBox_Math.Size = new System.Drawing.Size(54, 19);
            this.checkBox_Math.TabIndex = 1;
            this.checkBox_Math.Text = "Math";
            this.checkBox_Math.UseVisualStyleBackColor = true;
            this.checkBox_Math.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // checkBox_Science
            // 
            this.checkBox_Science.AutoSize = true;
            this.checkBox_Science.Location = new System.Drawing.Point(6, 22);
            this.checkBox_Science.Name = "checkBox_Science";
            this.checkBox_Science.Size = new System.Drawing.Size(66, 19);
            this.checkBox_Science.TabIndex = 0;
            this.checkBox_Science.Text = "Science";
            this.checkBox_Science.UseVisualStyleBackColor = true;
            this.checkBox_Science.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // label_Student
            // 
            this.label_Student.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Student.Location = new System.Drawing.Point(127, 19);
            this.label_Student.Name = "label_Student";
            this.label_Student.Size = new System.Drawing.Size(100, 35);
            this.label_Student.TabIndex = 0;
            this.label_Student.Text = "Name StudentID";
            this.label_Student.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReceptionEditSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 364);
            this.Controls.Add(this.groupBox_EditSubject);
            this.Controls.Add(this.label_Logo);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.pictureBox_Account);
            this.Name = "ReceptionEditSubjects";
            this.Text = "ReceptionEditSubjects";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Account)).EndInit();
            this.groupBox_EditSubject.ResumeLayout(false);
            this.groupBox_EditSubject.PerformLayout();
            this.groupBox_CheckBox.ResumeLayout(false);
            this.groupBox_CheckBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Logo;
        private Label label_Username;
        private Label label_Role;
        private PictureBox pictureBox_Account;
        private GroupBox groupBox_EditSubject;
        private Label label_Student;
        private ListBox listBox_Subjects;
        private Label label_Enrolled;
        private GroupBox groupBox_CheckBox;
        private CheckBox checkBox_Geography;
        private CheckBox checkBox_History;
        private CheckBox checkBox_English;
        private CheckBox checkBox_Math;
        private CheckBox checkBox_Science;
        private Button button_Confirm;
        private Button button_Cancel;
    }
}