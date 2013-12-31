namespace MatrixOfNumber
{
    partial class Form2
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbKhach = new System.Windows.Forms.TabPage();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.btnXemchitietkhach = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBang = new System.Windows.Forms.TabPage();
            this.tbCoso = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.tbKhach.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tbKhach);
            this.tabMain.Controls.Add(this.tbBang);
            this.tabMain.Controls.Add(this.tbCoso);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(688, 465);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.ReloadData);
            // 
            // tbKhach
            // 
            this.tbKhach.Controls.Add(this.gbSearch);
            this.tbKhach.Controls.Add(this.btnXemchitietkhach);
            this.tbKhach.Controls.Add(this.btnSua);
            this.tbKhach.Controls.Add(this.btnThem);
            this.tbKhach.Controls.Add(this.dgvKhach);
            this.tbKhach.Controls.Add(this.label1);
            this.tbKhach.Location = new System.Drawing.Point(4, 22);
            this.tbKhach.Name = "tbKhach";
            this.tbKhach.Padding = new System.Windows.Forms.Padding(3);
            this.tbKhach.Size = new System.Drawing.Size(680, 439);
            this.tbKhach.TabIndex = 0;
            this.tbKhach.Text = "Khách";
            this.tbKhach.UseVisualStyleBackColor = true;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(29, 489);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMsg.TabIndex = 6;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.txtNameSearch);
            this.gbSearch.Controls.Add(this.lblSearchName);
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(6, 6);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(266, 76);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(174, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSearch.Location = new System.Drawing.Point(66, 21);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(183, 20);
            this.txtNameSearch.TabIndex = 1;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(6, 24);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(65, 13);
            this.lblSearchName.TabIndex = 0;
            this.lblSearchName.Text = "Tên khách: ";
            // 
            // btnXemchitietkhach
            // 
            this.btnXemchitietkhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemchitietkhach.Location = new System.Drawing.Point(540, 35);
            this.btnXemchitietkhach.Name = "btnXemchitietkhach";
            this.btnXemchitietkhach.Size = new System.Drawing.Size(75, 23);
            this.btnXemchitietkhach.TabIndex = 4;
            this.btnXemchitietkhach.Text = "Xem chi tiết";
            this.btnXemchitietkhach.UseVisualStyleBackColor = true;
            this.btnXemchitietkhach.Click += new System.EventHandler(this.btnXemchitietkhach_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(459, 35);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(378, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvKhach
            // 
            this.dgvKhach.AllowUserToAddRows = false;
            this.dgvKhach.AllowUserToDeleteRows = false;
            this.dgvKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKhach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Location = new System.Drawing.Point(11, 110);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.ReadOnly = true;
            this.dgvKhach.RowHeadersVisible = false;
            this.dgvKhach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhach.ShowCellErrors = false;
            this.dgvKhach.ShowCellToolTips = false;
            this.dgvKhach.ShowEditingIcon = false;
            this.dgvKhach.ShowRowErrors = false;
            this.dgvKhach.Size = new System.Drawing.Size(660, 319);
            this.dgvKhach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khách";
            // 
            // tbBang
            // 
            this.tbBang.Location = new System.Drawing.Point(4, 22);
            this.tbBang.Name = "tbBang";
            this.tbBang.Padding = new System.Windows.Forms.Padding(3);
            this.tbBang.Size = new System.Drawing.Size(680, 323);
            this.tbBang.TabIndex = 1;
            this.tbBang.Text = "Bảng";
            this.tbBang.UseVisualStyleBackColor = true;
            // 
            // tbCoso
            // 
            this.tbCoso.Location = new System.Drawing.Point(4, 22);
            this.tbCoso.Name = "tbCoso";
            this.tbCoso.Size = new System.Drawing.Size(680, 323);
            this.tbCoso.TabIndex = 2;
            this.tbCoso.Text = "Cơ sở";
            this.tbCoso.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 529);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.tabMain);
            this.Name = "Form2";
            this.Text = "Kết bảng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.finished);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.finishup);
            this.tabMain.ResumeLayout(false);
            this.tbKhach.ResumeLayout(false);
            this.tbKhach.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbKhach;
        private System.Windows.Forms.TabPage tbBang;
        private System.Windows.Forms.TabPage tbCoso;
        private System.Windows.Forms.Button btnXemchitietkhach;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}