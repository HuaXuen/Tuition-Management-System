namespace IOOP_Assignment
{
    partial class frmViewStatus
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
            this.lblReq = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.lstRequest = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblETC
            // 
            this.lblETC.AutoSize = true;
            this.lblETC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblETC.Location = new System.Drawing.Point(1, -1);
            this.lblETC.Name = "lblETC";
            this.lblETC.Size = new System.Drawing.Size(52, 31);
            this.lblETC.TabIndex = 0;
            this.lblETC.Text = "ETC";
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStu.Location = new System.Drawing.Point(216, 16);
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
            this.picStu.Name = "picStu";
            this.picStu.Size = new System.Drawing.Size(67, 62);
            this.picStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStu.TabIndex = 3;
            this.picStu.TabStop = false;
            // 
            // lblReq
            // 
            this.lblReq.AutoSize = true;
            this.lblReq.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReq.Location = new System.Drawing.Point(12, 95);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(67, 20);
            this.lblReq.TabIndex = 6;
            this.lblReq.Text = "Request:";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(12, 428);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(191, 29);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Delete Selected";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lstRequest
            // 
            this.lstRequest.FormattingEnabled = true;
            this.lstRequest.ItemHeight = 20;
            this.lstRequest.Location = new System.Drawing.Point(12, 118);
            this.lstRequest.Name = "lstRequest";
            this.lstRequest.Size = new System.Drawing.Size(388, 304);
            this.lstRequest.TabIndex = 11;
            this.lstRequest.SelectedIndexChanged += new System.EventHandler(this.lstRequest_SelectedIndexChanged);
            // 
            // frmViewStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 500);
            this.Controls.Add(this.lstRequest);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.picStu);
            this.Controls.Add(this.lblName_StuID);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.lblETC);
            this.Name = "frmViewStatus";
            this.Text = "frmViewStatus";
            this.Load += new System.EventHandler(this.frmViewStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblETC;
        private Label lblStu;
        private Label lblName_StuID;
        private PictureBox picStu;
        private Label lblReq;
        private Button btnDel;
        private ListBox lstRequest;
    }
}