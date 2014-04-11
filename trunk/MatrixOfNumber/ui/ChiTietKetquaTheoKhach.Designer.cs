namespace MatrixOfNumber.ui
{
    partial class ChiTietKetquaTheoKhach
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
            this.gbDe = new System.Windows.Forms.GroupBox();
            this.dgvDe = new System.Windows.Forms.DataGridView();
            this.gbLo = new System.Windows.Forms.GroupBox();
            this.dgvLo = new System.Windows.Forms.DataGridView();
            this.cbbKhach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTongket = new System.Windows.Forms.Label();
            this.lblTongDe = new System.Windows.Forms.Label();
            this.lblTongLo = new System.Windows.Forms.Label();
            this.lblThuaDe = new System.Windows.Forms.Label();
            this.lblDuocDe = new System.Windows.Forms.Label();
            this.lblThuaLo = new System.Windows.Forms.Label();
            this.lblDuocLo = new System.Windows.Forms.Label();
            this.gbDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDe)).BeginInit();
            this.gbLo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDe
            // 
            this.gbDe.Controls.Add(this.dgvDe);
            this.gbDe.Location = new System.Drawing.Point(380, 110);
            this.gbDe.Name = "gbDe";
            this.gbDe.Size = new System.Drawing.Size(298, 375);
            this.gbDe.TabIndex = 5;
            this.gbDe.TabStop = false;
            this.gbDe.Text = "Đề";
            // 
            // dgvDe
            // 
            this.dgvDe.AllowUserToAddRows = false;
            this.dgvDe.AllowUserToDeleteRows = false;
            this.dgvDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDe.Location = new System.Drawing.Point(16, 31);
            this.dgvDe.Name = "dgvDe";
            this.dgvDe.ReadOnly = true;
            this.dgvDe.RowHeadersVisible = false;
            this.dgvDe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDe.Size = new System.Drawing.Size(261, 328);
            this.dgvDe.TabIndex = 0;
            // 
            // gbLo
            // 
            this.gbLo.Controls.Add(this.dgvLo);
            this.gbLo.Location = new System.Drawing.Point(52, 110);
            this.gbLo.Name = "gbLo";
            this.gbLo.Size = new System.Drawing.Size(309, 375);
            this.gbLo.TabIndex = 4;
            this.gbLo.TabStop = false;
            this.gbLo.Text = "Lô";
            // 
            // dgvLo
            // 
            this.dgvLo.AllowUserToAddRows = false;
            this.dgvLo.AllowUserToDeleteRows = false;
            this.dgvLo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLo.Location = new System.Drawing.Point(17, 31);
            this.dgvLo.Name = "dgvLo";
            this.dgvLo.ReadOnly = true;
            this.dgvLo.RowHeadersVisible = false;
            this.dgvLo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLo.Size = new System.Drawing.Size(263, 328);
            this.dgvLo.TabIndex = 7;
            // 
            // cbbKhach
            // 
            this.cbbKhach.FormattingEnabled = true;
            this.cbbKhach.Location = new System.Drawing.Point(96, 60);
            this.cbbKhach.Name = "cbbKhach";
            this.cbbKhach.Size = new System.Drawing.Size(171, 21);
            this.cbbKhach.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khách:";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(290, 58);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(643, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 13);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Ngay";
            // 
            // lblTongket
            // 
            this.lblTongket.AutoSize = true;
            this.lblTongket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongket.Location = new System.Drawing.Point(411, 63);
            this.lblTongket.Name = "lblTongket";
            this.lblTongket.Size = new System.Drawing.Size(73, 16);
            this.lblTongket.TabIndex = 12;
            this.lblTongket.Text = "Bạn được";
            // 
            // lblTongDe
            // 
            this.lblTongDe.AutoSize = true;
            this.lblTongDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDe.Location = new System.Drawing.Point(504, 551);
            this.lblTongDe.Name = "lblTongDe";
            this.lblTongDe.Size = new System.Drawing.Size(52, 16);
            this.lblTongDe.TabIndex = 18;
            this.lblTongDe.Text = "Tổng: ";
            // 
            // lblTongLo
            // 
            this.lblTongLo.AutoSize = true;
            this.lblTongLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongLo.Location = new System.Drawing.Point(179, 551);
            this.lblTongLo.Name = "lblTongLo";
            this.lblTongLo.Size = new System.Drawing.Size(52, 16);
            this.lblTongLo.TabIndex = 17;
            this.lblTongLo.Text = "Tổng: ";
            // 
            // lblThuaDe
            // 
            this.lblThuaDe.AutoSize = true;
            this.lblThuaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuaDe.ForeColor = System.Drawing.Color.Red;
            this.lblThuaDe.Location = new System.Drawing.Point(480, 527);
            this.lblThuaDe.Name = "lblThuaDe";
            this.lblThuaDe.Size = new System.Drawing.Size(44, 13);
            this.lblThuaDe.TabIndex = 16;
            this.lblThuaDe.Text = "Thua: ";
            // 
            // lblDuocDe
            // 
            this.lblDuocDe.AutoSize = true;
            this.lblDuocDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuocDe.Location = new System.Drawing.Point(480, 505);
            this.lblDuocDe.Name = "lblDuocDe";
            this.lblDuocDe.Size = new System.Drawing.Size(45, 13);
            this.lblDuocDe.TabIndex = 15;
            this.lblDuocDe.Text = "Được: ";
            // 
            // lblThuaLo
            // 
            this.lblThuaLo.AutoSize = true;
            this.lblThuaLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuaLo.ForeColor = System.Drawing.Color.Red;
            this.lblThuaLo.Location = new System.Drawing.Point(161, 527);
            this.lblThuaLo.Name = "lblThuaLo";
            this.lblThuaLo.Size = new System.Drawing.Size(44, 13);
            this.lblThuaLo.TabIndex = 14;
            this.lblThuaLo.Text = "Thua: ";
            // 
            // lblDuocLo
            // 
            this.lblDuocLo.AutoSize = true;
            this.lblDuocLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuocLo.Location = new System.Drawing.Point(161, 505);
            this.lblDuocLo.Name = "lblDuocLo";
            this.lblDuocLo.Size = new System.Drawing.Size(45, 13);
            this.lblDuocLo.TabIndex = 13;
            this.lblDuocLo.Text = "Được: ";
            // 
            // ChiTietKetquaTheoKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 589);
            this.ControlBox = false;
            this.Controls.Add(this.lblTongDe);
            this.Controls.Add(this.lblTongLo);
            this.Controls.Add(this.lblThuaDe);
            this.Controls.Add(this.lblDuocDe);
            this.Controls.Add(this.lblThuaLo);
            this.Controls.Add(this.lblDuocLo);
            this.Controls.Add(this.lblTongket);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbbKhach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDe);
            this.Controls.Add(this.gbLo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietKetquaTheoKhach";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết kết quả theo khách";
            this.gbDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDe)).EndInit();
            this.gbLo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDe;
        private System.Windows.Forms.DataGridView dgvDe;
        private System.Windows.Forms.GroupBox gbLo;
        private System.Windows.Forms.DataGridView dgvLo;
        private System.Windows.Forms.ComboBox cbbKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTongket;
        private System.Windows.Forms.Label lblTongDe;
        private System.Windows.Forms.Label lblTongLo;
        private System.Windows.Forms.Label lblThuaDe;
        private System.Windows.Forms.Label lblDuocDe;
        private System.Windows.Forms.Label lblThuaLo;
        private System.Windows.Forms.Label lblDuocLo;
    }
}