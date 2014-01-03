namespace MatrixOfNumber.utilities
{
    partial class ChitietSo
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
            this.lblSo = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblSoDtl = new System.Windows.Forms.Label();
            this.lblLoaiDtl = new System.Windows.Forms.Label();
            this.lblNgayDtl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.Location = new System.Drawing.Point(23, 18);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(26, 13);
            this.lblSo.TabIndex = 0;
            this.lblSo.Text = "Số: ";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(22, 45);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(33, 13);
            this.lblLoai.TabIndex = 1;
            this.lblLoai.Text = "Loại: ";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(23, 72);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(38, 13);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "Ngày: ";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(196, 12);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(293, 261);
            this.dgvDetails.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(47, 119);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(498, 18);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // lblSoDtl
            // 
            this.lblSoDtl.AutoSize = true;
            this.lblSoDtl.Location = new System.Drawing.Point(70, 18);
            this.lblSoDtl.Name = "lblSoDtl";
            this.lblSoDtl.Size = new System.Drawing.Size(35, 13);
            this.lblSoDtl.TabIndex = 6;
            this.lblSoDtl.Text = "label4";
            // 
            // lblLoaiDtl
            // 
            this.lblLoaiDtl.AutoSize = true;
            this.lblLoaiDtl.Location = new System.Drawing.Point(70, 45);
            this.lblLoaiDtl.Name = "lblLoaiDtl";
            this.lblLoaiDtl.Size = new System.Drawing.Size(35, 13);
            this.lblLoaiDtl.TabIndex = 7;
            this.lblLoaiDtl.Text = "label5";
            // 
            // lblNgayDtl
            // 
            this.lblNgayDtl.AutoSize = true;
            this.lblNgayDtl.Location = new System.Drawing.Point(70, 72);
            this.lblNgayDtl.Name = "lblNgayDtl";
            this.lblNgayDtl.Size = new System.Drawing.Size(35, 13);
            this.lblNgayDtl.TabIndex = 8;
            this.lblNgayDtl.Text = "label6";
            // 
            // ChitietSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 285);
            this.ControlBox = false;
            this.Controls.Add(this.lblNgayDtl);
            this.Controls.Add(this.lblLoaiDtl);
            this.Controls.Add(this.lblSoDtl);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblSo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChitietSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết số";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblSoDtl;
        private System.Windows.Forms.Label lblLoaiDtl;
        private System.Windows.Forms.Label lblNgayDtl;
    }
}