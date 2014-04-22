namespace MatrixOfNumber.ui
{
    partial class ChiTietSoTheoKhach
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.cbbKhach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDe = new System.Windows.Forms.GroupBox();
            this.dgvDe = new System.Windows.Forms.DataGridView();
            this.gbLo = new System.Windows.Forms.GroupBox();
            this.dgvLo = new System.Windows.Forms.DataGridView();
            this.lblTonglo = new System.Windows.Forms.Label();
            this.lblTongde = new System.Windows.Forms.Label();
            this.gbDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDe)).BeginInit();
            this.gbLo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 13);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Ngay";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(542, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(298, 58);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 16;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbbKhach
            // 
            this.cbbKhach.FormattingEnabled = true;
            this.cbbKhach.Location = new System.Drawing.Point(104, 60);
            this.cbbKhach.Name = "cbbKhach";
            this.cbbKhach.Size = new System.Drawing.Size(171, 21);
            this.cbbKhach.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Khách:";
            // 
            // gbDe
            // 
            this.gbDe.Controls.Add(this.dgvDe);
            this.gbDe.Location = new System.Drawing.Point(322, 110);
            this.gbDe.Name = "gbDe";
            this.gbDe.Size = new System.Drawing.Size(249, 375);
            this.gbDe.TabIndex = 13;
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
            this.dgvDe.Size = new System.Drawing.Size(210, 328);
            this.dgvDe.TabIndex = 0;
            // 
            // gbLo
            // 
            this.gbLo.Controls.Add(this.dgvLo);
            this.gbLo.Location = new System.Drawing.Point(60, 110);
            this.gbLo.Name = "gbLo";
            this.gbLo.Size = new System.Drawing.Size(247, 375);
            this.gbLo.TabIndex = 12;
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
            this.dgvLo.Size = new System.Drawing.Size(209, 328);
            this.dgvLo.TabIndex = 7;
            // 
            // lblTonglo
            // 
            this.lblTonglo.AutoSize = true;
            this.lblTonglo.Location = new System.Drawing.Point(190, 488);
            this.lblTonglo.Name = "lblTonglo";
            this.lblTonglo.Size = new System.Drawing.Size(32, 13);
            this.lblTonglo.TabIndex = 19;
            this.lblTonglo.Text = "Tổng";
            // 
            // lblTongde
            // 
            this.lblTongde.AutoSize = true;
            this.lblTongde.Location = new System.Drawing.Point(465, 488);
            this.lblTongde.Name = "lblTongde";
            this.lblTongde.Size = new System.Drawing.Size(32, 13);
            this.lblTongde.TabIndex = 20;
            this.lblTongde.Text = "Tổng";
            // 
            // ChiTietSoTheoKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 522);
            this.ControlBox = false;
            this.Controls.Add(this.lblTongde);
            this.Controls.Add(this.lblTonglo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbbKhach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDe);
            this.Controls.Add(this.gbLo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietSoTheoKhach";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết số theo khách";
            this.gbDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDe)).EndInit();
            this.gbLo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbbKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDe;
        private System.Windows.Forms.DataGridView dgvDe;
        private System.Windows.Forms.GroupBox gbLo;
        private System.Windows.Forms.DataGridView dgvLo;
        private System.Windows.Forms.Label lblTonglo;
        private System.Windows.Forms.Label lblTongde;
    }
}