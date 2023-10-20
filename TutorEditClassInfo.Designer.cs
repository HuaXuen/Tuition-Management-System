namespace IOOP_Assignment
{
    partial class TutorEditClassInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorEditClassInfo));
            this.lblName = new System.Windows.Forms.Label();
            this.lblTutor = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gridList = new System.Windows.Forms.DataGridView();
            this.txtTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCRate = new System.Windows.Forms.Label();
            this.txtCRate = new System.Windows.Forms.TextBox();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.picTutor = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(486, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "$Name$";
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTutor.ForeColor = System.Drawing.Color.Black;
            this.lblTutor.Location = new System.Drawing.Point(484, 9);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(86, 37);
            this.lblTutor.TabIndex = 6;
            this.lblTutor.Text = "Tutor";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(12, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(63, 37);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "ETC";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(196, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 74);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Update and Delete\r\n Class Information";
            // 
            // gridList
            // 
            this.gridList.AllowUserToAddRows = false;
            this.gridList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtTutor,
            this.txtSubject,
            this.txtDay,
            this.StartTime,
            this.EndTime});
            this.gridList.Location = new System.Drawing.Point(0, 22);
            this.gridList.Name = "gridList";
            this.gridList.RowHeadersWidth = 51;
            this.gridList.RowTemplate.Height = 25;
            this.gridList.Size = new System.Drawing.Size(618, 290);
            this.gridList.TabIndex = 12;
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
            // 
            // txtDay
            // 
            this.txtDay.HeaderText = "Day";
            this.txtDay.MinimumWidth = 6;
            this.txtDay.Name = "txtDay";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.Name = "EndTime";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lblCRate);
            this.groupBox1.Controls.Add(this.txtCRate);
            this.groupBox1.Controls.Add(this.btnDeleteRow);
            this.groupBox1.Controls.Add(this.btnAddRow);
            this.groupBox1.Controls.Add(this.gridList);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 361);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Information";
            // 
            // lblCRate
            // 
            this.lblCRate.AutoSize = true;
            this.lblCRate.Location = new System.Drawing.Point(371, 330);
            this.lblCRate.Name = "lblCRate";
            this.lblCRate.Size = new System.Drawing.Size(132, 15);
            this.lblCRate.TabIndex = 20;
            this.lblCRate.Text = "Charge Rate Of Subject:";
            // 
            // txtCRate
            // 
            this.txtCRate.Location = new System.Drawing.Point(506, 326);
            this.txtCRate.Name = "txtCRate";
            this.txtCRate.Size = new System.Drawing.Size(100, 23);
            this.txtCRate.TabIndex = 19;
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(109, 326);
            this.btnDeleteRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(82, 22);
            this.btnDeleteRow.TabIndex = 18;
            this.btnDeleteRow.Text = "Delete Row";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(10, 326);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(82, 22);
            this.btnAddRow.TabIndex = 17;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // picTutor
            // 
            this.picTutor.Image = ((System.Drawing.Image)(resources.GetObject("picTutor.Image")));
            this.picTutor.Location = new System.Drawing.Point(570, 9);
            this.picTutor.Name = "picTutor";
            this.picTutor.Size = new System.Drawing.Size(62, 56);
            this.picTutor.TabIndex = 17;
            this.picTutor.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(12, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 22);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(537, 507);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(93, 22);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Confirm Changes";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // TutorEditClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 550);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.picTutor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.lblLogo);
            this.Name = "TutorEditClassInfo";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblName;
        private Label lblTutor;
        private Label lblLogo;
        private Label lblTitle;
        private DataGridView gridList;
        private GroupBox groupBox1;
        private PictureBox picTutor;
        private Button btnCancel;
        private Button btnConfirm;
        private Button btnDeleteRow;
        private Button btnAddRow;
        private Label lblCRate;
        private TextBox txtCRate;
        private DataGridViewTextBoxColumn txtTutor;
        private DataGridViewTextBoxColumn txtSubject;
        private DataGridViewTextBoxColumn txtDay;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
    }
}