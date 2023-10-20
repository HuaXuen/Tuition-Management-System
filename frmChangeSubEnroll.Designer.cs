namespace IOOP_Assignment
{
    partial class frmChangeSubEnrol
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
            this.lblETC = new System.Windows.Forms.Label();
            this.lblStu = new System.Windows.Forms.Label();
            this.lblName_StuID = new System.Windows.Forms.Label();
            this.picStu = new System.Windows.Forms.PictureBox();
            this.grpChangeSubEnrol = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbSubToChoose = new System.Windows.Forms.ComboBox();
            this.lblSubToChoose = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.cmbSubToChange = new System.Windows.Forms.ComboBox();
            this.lblSubToChange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).BeginInit();
            this.grpChangeSubEnrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblETC
            // 
            this.lblETC.AutoSize = true;
            this.lblETC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblETC.Location = new System.Drawing.Point(2, -1);
            this.lblETC.Name = "lblETC";
            this.lblETC.Size = new System.Drawing.Size(52, 31);
            this.lblETC.TabIndex = 0;
            this.lblETC.Text = "ETC";
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStu.Location = new System.Drawing.Point(220, 16);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(86, 28);
            this.lblStu.TabIndex = 1;
            this.lblStu.Text = "Student";
            // 
            // lblName_StuID
            // 
            this.lblName_StuID.AutoSize = true;
            this.lblName_StuID.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName_StuID.Location = new System.Drawing.Point(194, 44);
            this.lblName_StuID.Name = "lblName_StuID";
            this.lblName_StuID.Size = new System.Drawing.Size(133, 17);
            this.lblName_StuID.TabIndex = 2;
            this.lblName_StuID.Text = "$NAME$ | StudentID";
            this.lblName_StuID.Click += new System.EventHandler(this.lblName_StuID_Click);
            // 
            // picStu
            // 
            this.picStu.Image = global::IOOP_Assignment.Properties.Resources.student;
            this.picStu.Location = new System.Drawing.Point(333, 12);
            this.picStu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picStu.Name = "picStu";
            this.picStu.Size = new System.Drawing.Size(67, 62);
            this.picStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStu.TabIndex = 3;
            this.picStu.TabStop = false;
            // 
            // grpChangeSubEnrol
            // 
            this.grpChangeSubEnrol.Controls.Add(this.btnConfirm);
            this.grpChangeSubEnrol.Controls.Add(this.btnCancel);
            this.grpChangeSubEnrol.Controls.Add(this.cmbSubToChoose);
            this.grpChangeSubEnrol.Controls.Add(this.lblSubToChoose);
            this.grpChangeSubEnrol.Controls.Add(this.txtReason);
            this.grpChangeSubEnrol.Controls.Add(this.lblReason);
            this.grpChangeSubEnrol.Controls.Add(this.cmbSubToChange);
            this.grpChangeSubEnrol.Controls.Add(this.lblSubToChange);
            this.grpChangeSubEnrol.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpChangeSubEnrol.Location = new System.Drawing.Point(11, 111);
            this.grpChangeSubEnrol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpChangeSubEnrol.Name = "grpChangeSubEnrol";
            this.grpChangeSubEnrol.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpChangeSubEnrol.Size = new System.Drawing.Size(389, 378);
            this.grpChangeSubEnrol.TabIndex = 4;
            this.grpChangeSubEnrol.TabStop = false;
            this.grpChangeSubEnrol.Text = "Form for Changing Subject Enrolment";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(213, 344);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 29);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm Changes";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(43, 344);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbSubToChoose
            // 
            this.cmbSubToChoose.FormattingEnabled = true;
            this.cmbSubToChoose.Location = new System.Drawing.Point(162, 280);
            this.cmbSubToChoose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSubToChoose.Name = "cmbSubToChoose";
            this.cmbSubToChoose.Size = new System.Drawing.Size(220, 28);
            this.cmbSubToChoose.TabIndex = 5;
            // 
            // lblSubToChoose
            // 
            this.lblSubToChoose.AutoSize = true;
            this.lblSubToChoose.Location = new System.Drawing.Point(6, 284);
            this.lblSubToChoose.Name = "lblSubToChoose";
            this.lblSubToChoose.Size = new System.Drawing.Size(154, 20);
            this.lblSubToChoose.TabIndex = 4;
            this.lblSubToChoose.Text = "Subject to be chosen:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(72, 89);
            this.txtReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(310, 168);
            this.txtReason.TabIndex = 3;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(6, 89);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(62, 20);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Reason:";
            // 
            // cmbSubToChange
            // 
            this.cmbSubToChange.FormattingEnabled = true;
            this.cmbSubToChange.Location = new System.Drawing.Point(173, 38);
            this.cmbSubToChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSubToChange.Name = "cmbSubToChange";
            this.cmbSubToChange.Size = new System.Drawing.Size(209, 28);
            this.cmbSubToChange.TabIndex = 1;
            this.cmbSubToChange.SelectedIndexChanged += new System.EventHandler(this.cmbSubToChange_SelectedIndexChanged);
            // 
            // lblSubToChange
            // 
            this.lblSubToChange.AutoSize = true;
            this.lblSubToChange.Location = new System.Drawing.Point(6, 41);
            this.lblSubToChange.Name = "lblSubToChange";
            this.lblSubToChange.Size = new System.Drawing.Size(165, 20);
            this.lblSubToChange.TabIndex = 0;
            this.lblSubToChange.Text = "Subject to be changed:";
            // 
            // frmChangeSubEnrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 500);
            this.Controls.Add(this.grpChangeSubEnrol);
            this.Controls.Add(this.picStu);
            this.Controls.Add(this.lblName_StuID);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.lblETC);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChangeSubEnrol";
            this.Text = "frmChangeSubEnrol";
            this.Load += new System.EventHandler(this.frmChangeSubEnrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).EndInit();
            this.grpChangeSubEnrol.ResumeLayout(false);
            this.grpChangeSubEnrol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblETC;
        private Label lblStu;
        private Label lblName_StuID;
        private PictureBox picStu;
        private GroupBox grpChangeSubEnrol;
        private Button btnConfirm;
        private Button btnCancel;
        private ComboBox cmbSubToChoose;
        private Label lblSubToChoose;
        private TextBox txtReason;
        private Label lblReason;
        private ComboBox cmbSubToChange;
        private Label lblSubToChange;
    }
}