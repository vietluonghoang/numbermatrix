namespace MatrixOfNumber.ui
{
    partial class ThemCoSo
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
            this.lblTennhom = new System.Windows.Forms.Label();
            this.lblTencoso = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblLoai = new System.Windows.Forms.Label();
            this.txtTennhom = new System.Windows.Forms.TextBox();
            this.txtCoso = new System.Windows.Forms.TextBox();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTennhom
            // 
            this.lblTennhom.AutoSize = true;
            this.lblTennhom.Location = new System.Drawing.Point(21, 27);
            this.lblTennhom.Name = "lblTennhom";
            this.lblTennhom.Size = new System.Drawing.Size(58, 13);
            this.lblTennhom.TabIndex = 0;
            this.lblTennhom.Text = "Tên nhóm:";
            // 
            // lblTencoso
            // 
            this.lblTencoso.AutoSize = true;
            this.lblTencoso.Location = new System.Drawing.Point(21, 54);
            this.lblTencoso.Name = "lblTencoso";
            this.lblTencoso.Size = new System.Drawing.Size(37, 13);
            this.lblTencoso.TabIndex = 1;
            this.lblTencoso.Text = "Cơ sở:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(140, 126);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(51, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(197, 126);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(21, 82);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(30, 13);
            this.lblLoai.TabIndex = 4;
            this.lblLoai.Text = "Loại:";
            // 
            // txtTennhom
            // 
            this.txtTennhom.Location = new System.Drawing.Point(85, 24);
            this.txtTennhom.Name = "txtTennhom";
            this.txtTennhom.Size = new System.Drawing.Size(162, 20);
            this.txtTennhom.TabIndex = 5;
            // 
            // txtCoso
            // 
            this.txtCoso.Location = new System.Drawing.Point(85, 51);
            this.txtCoso.Name = "txtCoso";
            this.txtCoso.Size = new System.Drawing.Size(100, 20);
            this.txtCoso.TabIndex = 6;
            // 
            // cbbLoai
            // 
            this.cbbLoai.Enabled = false;
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "Lô",
            "Đề"});
            this.cbbLoai.Location = new System.Drawing.Point(85, 79);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(84, 21);
            this.cbbLoai.TabIndex = 7;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(21, 161);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 8;
            // 
            // ThemCoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.ControlBox = false;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.txtCoso);
            this.Controls.Add(this.txtTennhom);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblTencoso);
            this.Controls.Add(this.lblTennhom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemCoSo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Cơ Sở";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTennhom;
        private System.Windows.Forms.Label lblTencoso;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.TextBox txtTennhom;
        private System.Windows.Forms.TextBox txtCoso;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label lblError;
    }
}