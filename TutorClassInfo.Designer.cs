namespace IOOP_Assignment
{
    partial class TutorClassInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorClassInfo));
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTutor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSList = new System.Windows.Forms.Button();
            this.btnCInfo = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.picTutor = new System.Windows.Forms.PictureBox();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.gridClass = new System.Windows.Forms.DataGridView();
            this.txtTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCRate = new System.Windows.Forms.Label();
            this.txtCRate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).BeginInit();
            this.grpClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(12, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(63, 37);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ETC";
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTutor.ForeColor = System.Drawing.Color.Black;
            this.lblTutor.Location = new System.Drawing.Point(481, 8);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(86, 37);
            this.lblTutor.TabIndex = 1;
            this.lblTutor.Text = "Tutor";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(489, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "$Name$";
            // 
            // btnSList
            // 
            this.btnSList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSList.Location = new System.Drawing.Point(12, 398);
            this.btnSList.Name = "btnSList";
            this.btnSList.Size = new System.Drawing.Size(142, 40);
            this.btnSList.TabIndex = 4;
            this.btnSList.Text = "View Student List";
            this.btnSList.UseVisualStyleBackColor = false;
            this.btnSList.Click += new System.EventHandler(this.btnSList_Click);
            // 
            // btnCInfo
            // 
            this.btnCInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCInfo.Location = new System.Drawing.Point(489, 398);
            this.btnCInfo.Name = "btnCInfo";
            this.btnCInfo.Size = new System.Drawing.Size(141, 40);
            this.btnCInfo.TabIndex = 4;
            this.btnCInfo.Text = "Update and Delete Class Infromation";
            this.btnCInfo.UseVisualStyleBackColor = false;
            this.btnCInfo.Click += new System.EventHandler(this.btnCInfo_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(499, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 25);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // picTutor
            // 
            this.picTutor.Image = ((System.Drawing.Image)(resources.GetObject("picTutor.Image")));
            this.picTutor.Location = new System.Drawing.Point(569, 12);
            this.picTutor.Name = "picTutor";
            this.picTutor.Size = new System.Drawing.Size(54, 42);
            this.picTutor.TabIndex = 18;
            this.picTutor.TabStop = false;
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.gridClass);
            this.grpClass.Location = new System.Drawing.Point(10, 79);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(620, 302);
            this.grpClass.TabIndex = 19;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Class Information";
            // 
            // gridClass
            // 
            this.gridClass.AllowUserToAddRows = false;
            this.gridClass.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtTutor,
            this.txtSubject,
            this.txtDay,
            this.StartTime,
            this.EndTime});
            this.gridClass.Location = new System.Drawing.Point(0, 22);
            this.gridClass.Name = "gridClass";
            this.gridClass.ReadOnly = true;
            this.gridClass.RowHeadersWidth = 51;
            this.gridClass.RowTemplate.Height = 25;
            this.gridClass.Size = new System.Drawing.Size(620, 280);
            this.gridClass.TabIndex = 5;
            // 
            // txtTutor
            // 
            this.txtTutor.HeaderText = "Tutor";
            this.txtTutor.MinimumWidth = 6;
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.ReadOnly = true;
            // 
            // txtSubject
            // 
            this.txtSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtSubject.HeaderText = "Subject Name";
            this.txtSubject.MinimumWidth = 6;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            // 
            // txtDay
            // 
            this.txtDay.HeaderText = "Day";
            this.txtDay.MinimumWidth = 6;
            this.txtDay.Name = "txtDay";
            this.txtDay.ReadOnly = true;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            // 
            // lblCRate
            // 
            this.lblCRate.AutoSize = true;
            this.lblCRate.Location = new System.Drawing.Point(204, 411);
            this.lblCRate.Name = "lblCRate";
            this.lblCRate.Size = new System.Drawing.Size(132, 15);
            this.lblCRate.TabIndex = 21;
            this.lblCRate.Text = "Charge Rate Of Subject:";
            // 
            // txtCRate
            // 
            this.txtCRate.Location = new System.Drawing.Point(336, 407);
            this.txtCRate.Name = "txtCRate";
            this.txtCRate.Size = new System.Drawing.Size(100, 23);
            this.txtCRate.TabIndex = 22;
            // 
            // TutorClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 454);
            this.Controls.Add(this.txtCRate);
            this.Controls.Add(this.lblCRate);
            this.Controls.Add(this.grpClass);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCInfo);
            this.Controls.Add(this.picTutor);
            this.Controls.Add(this.btnSList);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.lblLogo);
            this.Name = "TutorClassInfo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).EndInit();
            this.grpClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLogo;
        private Label lblTutor;
        private Label lblName;
        private Button btnSList;
        private Button btnCInfo;
        private Button btnUpdate;
        private PictureBox picTutor;
        private GroupBox grpClass;
        private DataGridView gridClass;
        private Label lblCRate;
        private DataGridViewTextBoxColumn txtTutor;
        private DataGridViewTextBoxColumn txtSubject;
        private DataGridViewTextBoxColumn txtDay;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
        private TextBox txtCRate;
    }
}