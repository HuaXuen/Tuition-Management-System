namespace IOOP_Assignment
{
    partial class frmMain
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
            this.grpFunc = new System.Windows.Forms.GroupBox();
            this.btnViewPro = new System.Windows.Forms.Button();
            this.btnChangeSubEnroll = new System.Windows.Forms.Button();
            this.btnViewReqStatus = new System.Windows.Forms.Button();
            this.btnViewSch = new System.Windows.Forms.Button();
            this.picStu = new System.Windows.Forms.PictureBox();
            this.grpFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblETC
            // 
            this.lblETC.AutoSize = true;
            this.lblETC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblETC.Location = new System.Drawing.Point(1, 0);
            this.lblETC.Name = "lblETC";
            this.lblETC.Size = new System.Drawing.Size(52, 31);
            this.lblETC.TabIndex = 0;
            this.lblETC.Text = "ETC";
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStu.Location = new System.Drawing.Point(159, 156);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(86, 28);
            this.lblStu.TabIndex = 1;
            this.lblStu.Text = "Student";
            // 
            // lblName_StuID
            // 
            this.lblName_StuID.AutoSize = true;
            this.lblName_StuID.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName_StuID.Location = new System.Drawing.Point(137, 184);
            this.lblName_StuID.Name = "lblName_StuID";
            this.lblName_StuID.Size = new System.Drawing.Size(133, 17);
            this.lblName_StuID.TabIndex = 2;
            this.lblName_StuID.Text = "$NAME$ | StudentID";
            this.lblName_StuID.Click += new System.EventHandler(this.label3_Click);
            // 
            // grpFunc
            // 
            this.grpFunc.Controls.Add(this.btnViewPro);
            this.grpFunc.Controls.Add(this.btnChangeSubEnroll);
            this.grpFunc.Controls.Add(this.btnViewReqStatus);
            this.grpFunc.Controls.Add(this.btnViewSch);
            this.grpFunc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpFunc.Location = new System.Drawing.Point(12, 214);
            this.grpFunc.Name = "grpFunc";
            this.grpFunc.Size = new System.Drawing.Size(388, 239);
            this.grpFunc.TabIndex = 3;
            this.grpFunc.TabStop = false;
            this.grpFunc.Text = "Functions";
            // 
            // btnViewPro
            // 
            this.btnViewPro.Location = new System.Drawing.Point(200, 58);
            this.btnViewPro.Name = "btnViewPro";
            this.btnViewPro.Size = new System.Drawing.Size(182, 50);
            this.btnViewPro.TabIndex = 2;
            this.btnViewPro.Text = "View Profile";
            this.btnViewPro.UseVisualStyleBackColor = true;
            this.btnViewPro.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChangeSubEnroll
            // 
            this.btnChangeSubEnroll.Location = new System.Drawing.Point(6, 143);
            this.btnChangeSubEnroll.Name = "btnChangeSubEnroll";
            this.btnChangeSubEnroll.Size = new System.Drawing.Size(182, 50);
            this.btnChangeSubEnroll.TabIndex = 1;
            this.btnChangeSubEnroll.Text = "Change Subject Enrollment";
            this.btnChangeSubEnroll.UseVisualStyleBackColor = true;
            this.btnChangeSubEnroll.Click += new System.EventHandler(this.btnChangeSubEnroll_Click);
            // 
            // btnViewReqStatus
            // 
            this.btnViewReqStatus.Location = new System.Drawing.Point(200, 143);
            this.btnViewReqStatus.Name = "btnViewReqStatus";
            this.btnViewReqStatus.Size = new System.Drawing.Size(182, 50);
            this.btnViewReqStatus.TabIndex = 3;
            this.btnViewReqStatus.Text = "View Request(s) Status";
            this.btnViewReqStatus.UseVisualStyleBackColor = true;
            this.btnViewReqStatus.Click += new System.EventHandler(this.btnViewReqStatus_Click);
            // 
            // btnViewSch
            // 
            this.btnViewSch.Location = new System.Drawing.Point(6, 58);
            this.btnViewSch.Name = "btnViewSch";
            this.btnViewSch.Size = new System.Drawing.Size(182, 50);
            this.btnViewSch.TabIndex = 0;
            this.btnViewSch.Text = "View Schedule";
            this.btnViewSch.UseVisualStyleBackColor = true;
            this.btnViewSch.Click += new System.EventHandler(this.btnViewSch_Click);
            // 
            // picStu
            // 
            this.picStu.Image = global::IOOP_Assignment.Properties.Resources.student;
            this.picStu.Location = new System.Drawing.Point(146, 41);
            this.picStu.Name = "picStu";
            this.picStu.Size = new System.Drawing.Size(115, 112);
            this.picStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStu.TabIndex = 4;
            this.picStu.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 500);
            this.Controls.Add(this.picStu);
            this.Controls.Add(this.grpFunc);
            this.Controls.Add(this.lblName_StuID);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.lblETC);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpFunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblETC;
        private Label lblStu;
        private Label lblName_StuID;
        private GroupBox grpFunc;
        private Button btnViewReqStatus;
        private Button btnViewPro;
        private Button btnChangeSubEnroll;
        private Button btnViewSch;
        private PictureBox picStu;
    }
}