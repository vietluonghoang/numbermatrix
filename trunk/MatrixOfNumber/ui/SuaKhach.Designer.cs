namespace MatrixOfNumber.ui
{
    partial class SuaKhach
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblContactError = new System.Windows.Forms.Label();
            this.lblBalanceError = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLoBase = new System.Windows.Forms.Label();
            this.lblDeBase = new System.Windows.Forms.Label();
            this.cbbLoBase = new System.Windows.Forms.ComboBox();
            this.cbbDeBase = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(120, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên: ";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(104, 53);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(48, 13);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Liên hệ: ";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(29, 157);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(123, 13);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Tiền có trong tài khoản: ";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(489, 203);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(160, 50);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(188, 91);
            this.txtContact.TabIndex = 2;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(160, 154);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(143, 20);
            this.txtBalance.TabIndex = 3;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(354, 20);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(0, 13);
            this.lblNameError.TabIndex = 7;
            // 
            // lblContactError
            // 
            this.lblContactError.AutoSize = true;
            this.lblContactError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactError.ForeColor = System.Drawing.Color.Red;
            this.lblContactError.Location = new System.Drawing.Point(354, 53);
            this.lblContactError.Name = "lblContactError";
            this.lblContactError.Size = new System.Drawing.Size(0, 13);
            this.lblContactError.TabIndex = 8;
            // 
            // lblBalanceError
            // 
            this.lblBalanceError.AutoSize = true;
            this.lblBalanceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceError.ForeColor = System.Drawing.Color.Red;
            this.lblBalanceError.Location = new System.Drawing.Point(354, 157);
            this.lblBalanceError.Name = "lblBalanceError";
            this.lblBalanceError.Size = new System.Drawing.Size(0, 13);
            this.lblBalanceError.TabIndex = 9;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(29, 194);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMsg.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(438, 203);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLoBase
            // 
            this.lblLoBase.AutoSize = true;
            this.lblLoBase.Location = new System.Drawing.Point(386, 40);
            this.lblLoBase.Name = "lblLoBase";
            this.lblLoBase.Size = new System.Drawing.Size(51, 13);
            this.lblLoBase.TabIndex = 12;
            this.lblLoBase.Text = "Lô cơ sở:";
            // 
            // lblDeBase
            // 
            this.lblDeBase.AutoSize = true;
            this.lblDeBase.Location = new System.Drawing.Point(386, 73);
            this.lblDeBase.Name = "lblDeBase";
            this.lblDeBase.Size = new System.Drawing.Size(56, 13);
            this.lblDeBase.TabIndex = 13;
            this.lblDeBase.Text = "Đề cơ sở: ";
            // 
            // cbbLoBase
            // 
            this.cbbLoBase.FormattingEnabled = true;
            this.cbbLoBase.Location = new System.Drawing.Point(443, 37);
            this.cbbLoBase.Name = "cbbLoBase";
            this.cbbLoBase.Size = new System.Drawing.Size(121, 21);
            this.cbbLoBase.TabIndex = 4;
            // 
            // cbbDeBase
            // 
            this.cbbDeBase.FormattingEnabled = true;
            this.cbbDeBase.Location = new System.Drawing.Point(443, 70);
            this.cbbDeBase.Name = "cbbDeBase";
            this.cbbDeBase.Size = new System.Drawing.Size(121, 21);
            this.cbbDeBase.TabIndex = 5;
            // 
            // SuaKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 251);
            this.ControlBox = false;
            this.Controls.Add(this.cbbDeBase);
            this.Controls.Add(this.cbbLoBase);
            this.Controls.Add(this.lblDeBase);
            this.Controls.Add(this.lblLoBase);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.lblBalanceError);
            this.Controls.Add(this.lblContactError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuaKhach";
            this.ShowInTaskbar = false;
            this.Text = "Sửa khách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblContactError;
        private System.Windows.Forms.Label lblBalanceError;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLoBase;
        private System.Windows.Forms.Label lblDeBase;
        private System.Windows.Forms.ComboBox cbbLoBase;
        private System.Windows.Forms.ComboBox cbbDeBase;
    }
}