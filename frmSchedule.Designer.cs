namespace IOOP_Assignment
{
    partial class frmSchedule
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
            this.lblETC = new System.Windows.Forms.Label();
            this.lblStu = new System.Windows.Forms.Label();
            this.lblName_StuID = new System.Windows.Forms.Label();
            this.lblSch = new System.Windows.Forms.Label();
            this.picStu = new System.Windows.Forms.PictureBox();
            this.grdSch = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblETC
            // 
            this.lblETC.AutoSize = true;
            this.lblETC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblETC.Location = new System.Drawing.Point(0, -1);
            this.lblETC.Name = "lblETC";
            this.lblETC.Size = new System.Drawing.Size(52, 31);
            this.lblETC.TabIndex = 0;
            this.lblETC.Text = "ETC";
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStu.Location = new System.Drawing.Point(401, 12);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(86, 28);
            this.lblStu.TabIndex = 1;
            this.lblStu.Text = "Student";
            // 
            // lblName_StuID
            // 
            this.lblName_StuID.AutoSize = true;
            this.lblName_StuID.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName_StuID.Location = new System.Drawing.Point(384, 40);
            this.lblName_StuID.Name = "lblName_StuID";
            this.lblName_StuID.Size = new System.Drawing.Size(117, 17);
            this.lblName_StuID.TabIndex = 2;
            this.lblName_StuID.Text = "Name | StudentID";
            // 
            // lblSch
            // 
            this.lblSch.AutoSize = true;
            this.lblSch.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSch.Location = new System.Drawing.Point(12, 85);
            this.lblSch.Name = "lblSch";
            this.lblSch.Size = new System.Drawing.Size(247, 45);
            this.lblSch.TabIndex = 3;
            this.lblSch.Text = "Class Schedule";
            // 
            // picStu
            // 
            this.picStu.Image = global::IOOP_Assignment.Properties.Resources.student;
            this.picStu.Location = new System.Drawing.Point(507, 12);
            this.picStu.Name = "picStu";
            this.picStu.Size = new System.Drawing.Size(67, 62);
            this.picStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStu.TabIndex = 4;
            this.picStu.TabStop = false;
            // 
            // grdSch
            // 
            this.grdSch.AllowUserToAddRows = false;
            this.grdSch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Subject,
            this.dataGridViewTextBoxColumn1,
            this.EndTime});
            this.grdSch.Location = new System.Drawing.Point(12, 134);
            this.grdSch.Name = "grdSch";
            this.grdSch.ReadOnly = true;
            this.grdSch.RowHeadersWidth = 51;
            this.grdSch.RowTemplate.Height = 29;
            this.grdSch.Size = new System.Drawing.Size(562, 304);
            this.grdSch.TabIndex = 5;
            this.grdSch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSch_CellContentClick);
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject Title";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 125;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.grdSch);
            this.Controls.Add(this.picStu);
            this.Controls.Add(this.lblSch);
            this.Controls.Add(this.lblName_StuID);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.lblETC);
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblETC;
        private Label lblStu;
        private Label lblName_StuID;
        private Label lblSch;
        private PictureBox picStu;
        private DataGridView grdSch;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn EndTime;
    }
}