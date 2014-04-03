namespace MatrixOfNumber.ui
{
    partial class ChiTietCoSo
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
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTypeDetails = new System.Windows.Forms.Label();
            this.lblCosoDetails = new System.Windows.Forms.Label();
            this.lblTennhomDetails = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCoso = new System.Windows.Forms.Label();
            this.lblTennhom = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.gbHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHistory
            // 
            this.gbHistory.Controls.Add(this.dgvHistory);
            this.gbHistory.Controls.Add(this.btnXem);
            this.gbHistory.Controls.Add(this.dtpTo);
            this.gbHistory.Controls.Add(this.lblTo);
            this.gbHistory.Controls.Add(this.dtpFrom);
            this.gbHistory.Controls.Add(this.lblFrom);
            this.gbHistory.Location = new System.Drawing.Point(27, 100);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(722, 263);
            this.gbHistory.TabIndex = 24;
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(674, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTypeDetails
            // 
            this.lblTypeDetails.AutoSize = true;
            this.lblTypeDetails.Location = new System.Drawing.Point(112, 67);
            this.lblTypeDetails.Name = "lblTypeDetails";
            this.lblTypeDetails.Size = new System.Drawing.Size(41, 13);
            this.lblTypeDetails.TabIndex = 22;
            this.lblTypeDetails.Text = "label10";
            // 
            // lblCosoDetails
            // 
            this.lblCosoDetails.AutoSize = true;
            this.lblCosoDetails.Location = new System.Drawing.Point(112, 44);
            this.lblCosoDetails.Name = "lblCosoDetails";
            this.lblCosoDetails.Size = new System.Drawing.Size(35, 13);
            this.lblCosoDetails.TabIndex = 21;
            this.lblCosoDetails.Text = "label9";
            // 
            // lblTennhomDetails
            // 
            this.lblTennhomDetails.AutoSize = true;
            this.lblTennhomDetails.Location = new System.Drawing.Point(112, 22);
            this.lblTennhomDetails.Name = "lblTennhomDetails";
            this.lblTennhomDetails.Size = new System.Drawing.Size(35, 13);
            this.lblTennhomDetails.TabIndex = 18;
            this.lblTennhomDetails.Text = "label6";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(34, 67);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 13);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Loại: ";
            // 
            // lblCoso
            // 
            this.lblCoso.AutoSize = true;
            this.lblCoso.Location = new System.Drawing.Point(34, 44);
            this.lblCoso.Name = "lblCoso";
            this.lblCoso.Size = new System.Drawing.Size(37, 13);
            this.lblCoso.TabIndex = 16;
            this.lblCoso.Text = "Cơ sở:";
            // 
            // lblTennhom
            // 
            this.lblTennhom.AutoSize = true;
            this.lblTennhom.Location = new System.Drawing.Point(34, 22);
            this.lblTennhom.Name = "lblTennhom";
            this.lblTennhom.Size = new System.Drawing.Size(55, 13);
            this.lblTennhom.TabIndex = 13;
            this.lblTennhom.Text = "Tên nhóm";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(36, 380);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 25;
            // 
            // ChiTietCoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 411);
            this.ControlBox = false;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gbHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTypeDetails);
            this.Controls.Add(this.lblCosoDetails);
            this.Controls.Add(this.lblTennhomDetails);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCoso);
            this.Controls.Add(this.lblTennhom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietCoSo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết cơ sở";
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTypeDetails;
        private System.Windows.Forms.Label lblCosoDetails;
        private System.Windows.Forms.Label lblTennhomDetails;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCoso;
        private System.Windows.Forms.Label lblTennhom;
        private System.Windows.Forms.Label lblError;

    }
}