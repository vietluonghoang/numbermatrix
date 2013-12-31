namespace MatrixOfNumber.ui
{
    partial class ChiTietKhach
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
            this.lblTitleName = new System.Windows.Forms.Label();
            this.lblTitleContact = new System.Windows.Forms.Label();
            this.lblTitleBalance = new System.Windows.Forms.Label();
            this.lblTitleLoBase = new System.Windows.Forms.Label();
            this.lblTitleDeBase = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblLoBase = new System.Windows.Forms.Label();
            this.lblDeBase = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.gbHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Location = new System.Drawing.Point(24, 9);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(32, 13);
            this.lblTitleName.TabIndex = 0;
            this.lblTitleName.Text = "Tên: ";
            // 
            // lblTitleContact
            // 
            this.lblTitleContact.AutoSize = true;
            this.lblTitleContact.Location = new System.Drawing.Point(24, 31);
            this.lblTitleContact.Name = "lblTitleContact";
            this.lblTitleContact.Size = new System.Drawing.Size(48, 13);
            this.lblTitleContact.TabIndex = 1;
            this.lblTitleContact.Text = "Liên hệ: ";
            // 
            // lblTitleBalance
            // 
            this.lblTitleBalance.AutoSize = true;
            this.lblTitleBalance.Location = new System.Drawing.Point(24, 78);
            this.lblTitleBalance.Name = "lblTitleBalance";
            this.lblTitleBalance.Size = new System.Drawing.Size(58, 13);
            this.lblTitleBalance.TabIndex = 2;
            this.lblTitleBalance.Text = "Tài khoản:";
            // 
            // lblTitleLoBase
            // 
            this.lblTitleLoBase.AutoSize = true;
            this.lblTitleLoBase.Location = new System.Drawing.Point(24, 101);
            this.lblTitleLoBase.Name = "lblTitleLoBase";
            this.lblTitleLoBase.Size = new System.Drawing.Size(48, 13);
            this.lblTitleLoBase.TabIndex = 3;
            this.lblTitleLoBase.Text = "Cơ sở lô:";
            // 
            // lblTitleDeBase
            // 
            this.lblTitleDeBase.AutoSize = true;
            this.lblTitleDeBase.Location = new System.Drawing.Point(24, 124);
            this.lblTitleDeBase.Name = "lblTitleDeBase";
            this.lblTitleDeBase.Size = new System.Drawing.Size(53, 13);
            this.lblTitleDeBase.TabIndex = 4;
            this.lblTitleDeBase.Text = "Cơ sở đề:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(102, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "label6";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(102, 31);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(35, 13);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "label7";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(102, 78);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(35, 13);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "label8";
            // 
            // lblLoBase
            // 
            this.lblLoBase.AutoSize = true;
            this.lblLoBase.Location = new System.Drawing.Point(102, 101);
            this.lblLoBase.Name = "lblLoBase";
            this.lblLoBase.Size = new System.Drawing.Size(35, 13);
            this.lblLoBase.TabIndex = 9;
            this.lblLoBase.Text = "label9";
            // 
            // lblDeBase
            // 
            this.lblDeBase.AutoSize = true;
            this.lblDeBase.Location = new System.Drawing.Point(102, 124);
            this.lblDeBase.Name = "lblDeBase";
            this.lblDeBase.Size = new System.Drawing.Size(41, 13);
            this.lblDeBase.TabIndex = 10;
            this.lblDeBase.Text = "label10";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(664, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbHistory
            // 
            this.gbHistory.Controls.Add(this.dgvHistory);
            this.gbHistory.Controls.Add(this.btnXem);
            this.gbHistory.Controls.Add(this.dtpTo);
            this.gbHistory.Controls.Add(this.lblTo);
            this.gbHistory.Controls.Add(this.dtpFrom);
            this.gbHistory.Controls.Add(this.lblFrom);
            this.gbHistory.Location = new System.Drawing.Point(16, 151);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(722, 263);
            this.gbHistory.TabIndex = 12;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "Lịch sử";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(11, 48);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHistory.Size = new System.Drawing.Size(698, 209);
            this.dgvHistory.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(348, 23);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd-MM-yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(244, 22);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(98, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(209, 28);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "đến:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(75, 22);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(98, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(46, 28);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(23, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Từ:";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(389, 125);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMsg.TabIndex = 13;
            // 
            // ChiTietKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 426);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.gbHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDeBase);
            this.Controls.Add(this.lblLoBase);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitleDeBase);
            this.Controls.Add(this.lblTitleLoBase);
            this.Controls.Add(this.lblTitleBalance);
            this.Controls.Add(this.lblTitleContact);
            this.Controls.Add(this.lblTitleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietKhach";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết";
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label lblTitleContact;
        private System.Windows.Forms.Label lblTitleBalance;
        private System.Windows.Forms.Label lblTitleLoBase;
        private System.Windows.Forms.Label lblTitleDeBase;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblLoBase;
        private System.Windows.Forms.Label lblDeBase;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}