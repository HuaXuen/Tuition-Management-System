namespace IOOP_Assignment
{
    partial class frmEdit
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
            this.picStu = new System.Windows.Forms.PictureBox();
            this.lblStu = new System.Windows.Forms.Label();
            this.lblName_StuID = new System.Windows.Forms.Label();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstSub = new System.Windows.Forms.ListBox();
            this.lblOutputLvl = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblOutputIC = new System.Windows.Forms.Label();
            this.lblOutputName = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblETC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).BeginInit();
            this.grpEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // picStu
            // 
            this.picStu.Image = global::IOOP_Assignment.Properties.Resources.student;
            this.picStu.Location = new System.Drawing.Point(337, 3);
            this.picStu.Name = "picStu";
            this.picStu.Size = new System.Drawing.Size(67, 62);
            this.picStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStu.TabIndex = 0;
            this.picStu.TabStop = false;
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStu.Location = new System.Drawing.Point(230, 6);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(86, 28);
            this.lblStu.TabIndex = 1;
            this.lblStu.Text = "Student";
            // 
            // lblName_StuID
            // 
            this.lblName_StuID.AutoSize = true;
            this.lblName_StuID.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName_StuID.Location = new System.Drawing.Point(214, 34);
            this.lblName_StuID.Name = "lblName_StuID";
            this.lblName_StuID.Size = new System.Drawing.Size(117, 17);
            this.lblName_StuID.TabIndex = 2;
            this.lblName_StuID.Text = "Name | StudentID";
            this.lblName_StuID.Click += new System.EventHandler(this.lblName_StuID_Click);
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.btnConfirm);
            this.grpEdit.Controls.Add(this.btnCancel);
            this.grpEdit.Controls.Add(this.lstSub);
            this.grpEdit.Controls.Add(this.lblOutputLvl);
            this.grpEdit.Controls.Add(this.txtContact);
            this.grpEdit.Controls.Add(this.txtEmail);
            this.grpEdit.Controls.Add(this.txtAdd);
            this.grpEdit.Controls.Add(this.lblOutputIC);
            this.grpEdit.Controls.Add(this.lblOutputName);
            this.grpEdit.Controls.Add(this.lblAdd);
            this.grpEdit.Controls.Add(this.lblSub);
            this.grpEdit.Controls.Add(this.lblLvl);
            this.grpEdit.Controls.Add(this.lblContact);
            this.grpEdit.Controls.Add(this.lblEmail);
            this.grpEdit.Controls.Add(this.lblIC);
            this.grpEdit.Controls.Add(this.lblName);
            this.grpEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpEdit.Location = new System.Drawing.Point(12, 71);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(388, 419);
            this.grpEdit.TabIndex = 3;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Edit Details";
            this.grpEdit.Enter += new System.EventHandler(this.grpEdit_Enter);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(218, 384);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(131, 29);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm Changes";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(58, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 29);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lstSub
            // 
            this.lstSub.FormattingEnabled = true;
            this.lstSub.ItemHeight = 20;
            this.lstSub.Location = new System.Drawing.Point(138, 292);
            this.lstSub.Name = "lstSub";
            this.lstSub.Size = new System.Drawing.Size(150, 84);
            this.lstSub.TabIndex = 13;
            // 
            // lblOutputLvl
            // 
            this.lblOutputLvl.AutoSize = true;
            this.lblOutputLvl.Location = new System.Drawing.Point(58, 258);
            this.lblOutputLvl.Name = "lblOutputLvl";
            this.lblOutputLvl.Size = new System.Drawing.Size(65, 20);
            this.lblOutputLvl.TabIndex = 12;
            this.lblOutputLvl.Text = "$LEVEL$";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(133, 220);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(249, 27);
            this.txtContact.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(77, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 27);
            this.txtEmail.TabIndex = 10;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(77, 102);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(305, 79);
            this.txtAdd.TabIndex = 9;
            // 
            // lblOutputIC
            // 
            this.lblOutputIC.AutoSize = true;
            this.lblOutputIC.Location = new System.Drawing.Point(37, 69);
            this.lblOutputIC.Name = "lblOutputIC";
            this.lblOutputIC.Size = new System.Drawing.Size(38, 20);
            this.lblOutputIC.TabIndex = 8;
            this.lblOutputIC.Text = "$IC$";
            // 
            // lblOutputName
            // 
            this.lblOutputName.AutoSize = true;
            this.lblOutputName.Location = new System.Drawing.Point(64, 34);
            this.lblOutputName.Name = "lblOutputName";
            this.lblOutputName.Size = new System.Drawing.Size(69, 20);
            this.lblOutputName.TabIndex = 7;
            this.lblOutputName.Text = "$NAME$";
            this.lblOutputName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(6, 102);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(67, 20);
            this.lblAdd.TabIndex = 6;
            this.lblAdd.Text = "Address:";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(6, 292);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(130, 20);
            this.lblSub.TabIndex = 5;
            this.lblSub.Text = "Subjects enrolled:";
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Location = new System.Drawing.Point(6, 258);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(48, 20);
            this.lblLvl.TabIndex = 4;
            this.lblLvl.Text = "Level:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(6, 223);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(127, 20);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblIC
            // 
            this.lblIC.AutoSize = true;
            this.lblIC.Location = new System.Drawing.Point(6, 69);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(26, 20);
            this.lblIC.TabIndex = 1;
            this.lblIC.Text = "IC:";
            this.lblIC.Click += new System.EventHandler(this.lblIC_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblETC
            // 
            this.lblETC.AutoSize = true;
            this.lblETC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblETC.Location = new System.Drawing.Point(2, 3);
            this.lblETC.Name = "lblETC";
            this.lblETC.Size = new System.Drawing.Size(52, 31);
            this.lblETC.TabIndex = 4;
            this.lblETC.Text = "ETC";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 500);
            this.Controls.Add(this.lblETC);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.lblName_StuID);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.picStu);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).EndInit();
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picStu;
        private Label lblStu;
        private Label lblName_StuID;
        private GroupBox grpEdit;
        private Label lblAdd;
        private Label lblSub;
        private Label lblLvl;
        private Label lblContact;
        private Label lblEmail;
        private Label lblIC;
        private Label lblName;
        private Button btnCancel;
        private ListBox lstSub;
        private Label lblOutputLvl;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtAdd;
        private Label lblOutputIC;
        private Label lblOutputName;
        private Button btnConfirm;
        private Label lblETC;
    }
}