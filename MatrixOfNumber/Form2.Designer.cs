﻿using System;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbKhach = new System.Windows.Forms.TabPage();
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
            this.btnXemtheokhach = new System.Windows.Forms.Button();
            this.lblDateBang = new System.Windows.Forms.Label();
            this.btnXemketqua = new System.Windows.Forms.Button();
            this.gbDe = new System.Windows.Forms.GroupBox();
            this.btnDeXemso = new System.Windows.Forms.Button();
            this.btnDeThemso = new System.Windows.Forms.Button();
            this.dgvDe = new System.Windows.Forms.DataGridView();
            this.gbLo = new System.Windows.Forms.GroupBox();
            this.btnLoXemso = new System.Windows.Forms.Button();
            this.btnLoThemso = new System.Windows.Forms.Button();
            this.dgvLo = new System.Windows.Forms.DataGridView();
            this.btnTaobang = new System.Windows.Forms.Button();
            this.dtpBang = new System.Windows.Forms.DateTimePicker();
            this.tbCoso = new System.Windows.Forms.TabPage();
            this.gbDeBase = new System.Windows.Forms.GroupBox();
            this.dgvDeBase = new System.Windows.Forms.DataGridView();
            this.btnNewDeBase = new System.Windows.Forms.Button();
            this.btnDeBaseDetails = new System.Windows.Forms.Button();
            this.btnEditDeBase = new System.Windows.Forms.Button();
            this.gbLoBase = new System.Windows.Forms.GroupBox();
            this.dgvLoBase = new System.Windows.Forms.DataGridView();
            this.btnNewLoBase = new System.Windows.Forms.Button();
            this.btnLoBaseDetails = new System.Windows.Forms.Button();
            this.btnEditLoBase = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tbKhach.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.tbBang.SuspendLayout();
            this.gbDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDe)).BeginInit();
            this.gbLo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLo)).BeginInit();
            this.tbCoso.SuspendLayout();
            this.gbDeBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeBase)).BeginInit();
            this.gbLoBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoBase)).BeginInit();
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
            this.tabMain.Enter += new System.EventHandler(this.BangEnter);
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
            this.tbBang.Controls.Add(this.btnXemtheokhach);
            this.tbBang.Controls.Add(this.lblDateBang);
            this.tbBang.Controls.Add(this.btnXemketqua);
            this.tbBang.Controls.Add(this.gbDe);
            this.tbBang.Controls.Add(this.gbLo);
            this.tbBang.Controls.Add(this.btnTaobang);
            this.tbBang.Controls.Add(this.dtpBang);
            this.tbBang.Location = new System.Drawing.Point(4, 22);
            this.tbBang.Name = "tbBang";
            this.tbBang.Padding = new System.Windows.Forms.Padding(3);
            this.tbBang.Size = new System.Drawing.Size(680, 439);
            this.tbBang.TabIndex = 1;
            this.tbBang.Text = "Bảng";
            this.tbBang.UseVisualStyleBackColor = true;
            // 
            // btnXemtheokhach
            // 
            this.btnXemtheokhach.Location = new System.Drawing.Point(6, 19);
            this.btnXemtheokhach.Name = "btnXemtheokhach";
            this.btnXemtheokhach.Size = new System.Drawing.Size(101, 23);
            this.btnXemtheokhach.TabIndex = 11;
            this.btnXemtheokhach.Text = "Xem theo khách";
            this.btnXemtheokhach.UseVisualStyleBackColor = true;
            this.btnXemtheokhach.Click += new System.EventHandler(this.btnXemtheokhach_Click);
            // 
            // lblDateBang
            // 
            this.lblDateBang.AutoSize = true;
            this.lblDateBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBang.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDateBang.Location = new System.Drawing.Point(256, 27);
            this.lblDateBang.Name = "lblDateBang";
            this.lblDateBang.Size = new System.Drawing.Size(47, 15);
            this.lblDateBang.TabIndex = 10;
            this.lblDateBang.Text = "Ngày: ";
            // 
            // btnXemketqua
            // 
            this.btnXemketqua.Location = new System.Drawing.Point(596, 19);
            this.btnXemketqua.Name = "btnXemketqua";
            this.btnXemketqua.Size = new System.Drawing.Size(75, 23);
            this.btnXemketqua.TabIndex = 2;
            this.btnXemketqua.Text = "Xem kết quả";
            this.btnXemketqua.UseVisualStyleBackColor = true;
            this.btnXemketqua.Click += new System.EventHandler(this.btnXemketqua_Click);
            // 
            // gbDe
            // 
            this.gbDe.Controls.Add(this.btnDeXemso);
            this.gbDe.Controls.Add(this.btnDeThemso);
            this.gbDe.Controls.Add(this.dgvDe);
            this.gbDe.Location = new System.Drawing.Point(376, 58);
            this.gbDe.Name = "gbDe";
            this.gbDe.Size = new System.Drawing.Size(278, 375);
            this.gbDe.TabIndex = 1;
            this.gbDe.TabStop = false;
            this.gbDe.Text = "Đề";
            // 
            // btnDeXemso
            // 
            this.btnDeXemso.Location = new System.Drawing.Point(188, 83);
            this.btnDeXemso.Name = "btnDeXemso";
            this.btnDeXemso.Size = new System.Drawing.Size(75, 23);
            this.btnDeXemso.TabIndex = 2;
            this.btnDeXemso.Text = "Xem chi tiết";
            this.btnDeXemso.UseVisualStyleBackColor = true;
            this.btnDeXemso.Click += new System.EventHandler(this.btnDeXemso_Click);
            // 
            // btnDeThemso
            // 
            this.btnDeThemso.Location = new System.Drawing.Point(188, 54);
            this.btnDeThemso.Name = "btnDeThemso";
            this.btnDeThemso.Size = new System.Drawing.Size(75, 23);
            this.btnDeThemso.TabIndex = 1;
            this.btnDeThemso.Text = "Thêm số";
            this.btnDeThemso.UseVisualStyleBackColor = true;
            this.btnDeThemso.Click += new System.EventHandler(this.btnDeThemso_Click);
            // 
            // dgvDe
            // 
            this.dgvDe.AllowUserToAddRows = false;
            this.dgvDe.AllowUserToDeleteRows = false;
            this.dgvDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDe.Location = new System.Drawing.Point(12, 31);
            this.dgvDe.Name = "dgvDe";
            this.dgvDe.ReadOnly = true;
            this.dgvDe.RowHeadersVisible = false;
            this.dgvDe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDe.Size = new System.Drawing.Size(158, 328);
            this.dgvDe.TabIndex = 0;
            // 
            // gbLo
            // 
            this.gbLo.Controls.Add(this.btnLoXemso);
            this.gbLo.Controls.Add(this.btnLoThemso);
            this.gbLo.Controls.Add(this.dgvLo);
            this.gbLo.Location = new System.Drawing.Point(28, 58);
            this.gbLo.Name = "gbLo";
            this.gbLo.Size = new System.Drawing.Size(294, 375);
            this.gbLo.TabIndex = 0;
            this.gbLo.TabStop = false;
            this.gbLo.Text = "Lô";
            // 
            // btnLoXemso
            // 
            this.btnLoXemso.Location = new System.Drawing.Point(200, 83);
            this.btnLoXemso.Name = "btnLoXemso";
            this.btnLoXemso.Size = new System.Drawing.Size(75, 23);
            this.btnLoXemso.TabIndex = 11;
            this.btnLoXemso.Text = "Xem chi tiết";
            this.btnLoXemso.UseVisualStyleBackColor = true;
            this.btnLoXemso.Click += new System.EventHandler(this.btnLoXemso_Click);
            // 
            // btnLoThemso
            // 
            this.btnLoThemso.Location = new System.Drawing.Point(200, 54);
            this.btnLoThemso.Name = "btnLoThemso";
            this.btnLoThemso.Size = new System.Drawing.Size(75, 23);
            this.btnLoThemso.TabIndex = 10;
            this.btnLoThemso.Text = "Thêm số";
            this.btnLoThemso.UseVisualStyleBackColor = true;
            this.btnLoThemso.Click += new System.EventHandler(this.btnLoThemso_Click);
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
            this.dgvLo.Size = new System.Drawing.Size(166, 328);
            this.dgvLo.TabIndex = 7;
            // 
            // btnTaobang
            // 
            this.btnTaobang.Location = new System.Drawing.Point(453, 24);
            this.btnTaobang.Name = "btnTaobang";
            this.btnTaobang.Size = new System.Drawing.Size(75, 23);
            this.btnTaobang.TabIndex = 9;
            this.btnTaobang.Text = "Tạo bảng";
            this.btnTaobang.UseVisualStyleBackColor = true;
            this.btnTaobang.Click += new System.EventHandler(this.btnTaobang_Click);
            // 
            // dtpBang
            // 
            this.dtpBang.CustomFormat = "d-M-yyyy";
            this.dtpBang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBang.Location = new System.Drawing.Point(309, 27);
            this.dtpBang.Name = "dtpBang";
            this.dtpBang.Size = new System.Drawing.Size(120, 20);
            this.dtpBang.TabIndex = 6;
            this.dtpBang.Value = new System.DateTime(2014, 1, 3, 12, 34, 37, 119);
            this.dtpBang.ValueChanged += new System.EventHandler(this.dtpBang_ValueChanged);
            // 
            // tbCoso
            // 
            this.tbCoso.Controls.Add(this.gbDeBase);
            this.tbCoso.Controls.Add(this.gbLoBase);
            this.tbCoso.Location = new System.Drawing.Point(4, 22);
            this.tbCoso.Name = "tbCoso";
            this.tbCoso.Size = new System.Drawing.Size(680, 439);
            this.tbCoso.TabIndex = 2;
            this.tbCoso.Text = "Cơ sở";
            this.tbCoso.UseVisualStyleBackColor = true;
            // 
            // gbDeBase
            // 
            this.gbDeBase.Controls.Add(this.dgvDeBase);
            this.gbDeBase.Controls.Add(this.btnNewDeBase);
            this.gbDeBase.Controls.Add(this.btnDeBaseDetails);
            this.gbDeBase.Controls.Add(this.btnEditDeBase);
            this.gbDeBase.Location = new System.Drawing.Point(375, 54);
            this.gbDeBase.Name = "gbDeBase";
            this.gbDeBase.Size = new System.Drawing.Size(281, 348);
            this.gbDeBase.TabIndex = 12;
            this.gbDeBase.TabStop = false;
            this.gbDeBase.Text = "Cơ sở Đề";
            // 
            // dgvDeBase
            // 
            this.dgvDeBase.AllowUserToAddRows = false;
            this.dgvDeBase.AllowUserToDeleteRows = false;
            this.dgvDeBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDeBase.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDeBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeBase.Location = new System.Drawing.Point(14, 19);
            this.dgvDeBase.Name = "dgvDeBase";
            this.dgvDeBase.ReadOnly = true;
            this.dgvDeBase.RowHeadersVisible = false;
            this.dgvDeBase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDeBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeBase.ShowCellErrors = false;
            this.dgvDeBase.ShowCellToolTips = false;
            this.dgvDeBase.ShowEditingIcon = false;
            this.dgvDeBase.ShowRowErrors = false;
            this.dgvDeBase.Size = new System.Drawing.Size(174, 307);
            this.dgvDeBase.TabIndex = 6;
            // 
            // btnNewDeBase
            // 
            this.btnNewDeBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewDeBase.Location = new System.Drawing.Point(194, 64);
            this.btnNewDeBase.Name = "btnNewDeBase";
            this.btnNewDeBase.Size = new System.Drawing.Size(75, 23);
            this.btnNewDeBase.TabIndex = 7;
            this.btnNewDeBase.Text = "Thêm mới";
            this.btnNewDeBase.UseVisualStyleBackColor = true;
            this.btnNewDeBase.Click += new System.EventHandler(this.btnNewDeBase_Click);
            // 
            // btnDeBaseDetails
            // 
            this.btnDeBaseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeBaseDetails.Location = new System.Drawing.Point(194, 122);
            this.btnDeBaseDetails.Name = "btnDeBaseDetails";
            this.btnDeBaseDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDeBaseDetails.TabIndex = 9;
            this.btnDeBaseDetails.Text = "Xem chi tiết";
            this.btnDeBaseDetails.UseVisualStyleBackColor = true;
            this.btnDeBaseDetails.Click += new System.EventHandler(this.btnDeBaseDetails_Click);
            // 
            // btnEditDeBase
            // 
            this.btnEditDeBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDeBase.Location = new System.Drawing.Point(194, 93);
            this.btnEditDeBase.Name = "btnEditDeBase";
            this.btnEditDeBase.Size = new System.Drawing.Size(75, 23);
            this.btnEditDeBase.TabIndex = 8;
            this.btnEditDeBase.Text = "Sửa";
            this.btnEditDeBase.UseVisualStyleBackColor = true;
            this.btnEditDeBase.Click += new System.EventHandler(this.btnEditDeBase_Click);
            // 
            // gbLoBase
            // 
            this.gbLoBase.Controls.Add(this.dgvLoBase);
            this.gbLoBase.Controls.Add(this.btnNewLoBase);
            this.gbLoBase.Controls.Add(this.btnLoBaseDetails);
            this.gbLoBase.Controls.Add(this.btnEditLoBase);
            this.gbLoBase.Location = new System.Drawing.Point(28, 54);
            this.gbLoBase.Name = "gbLoBase";
            this.gbLoBase.Size = new System.Drawing.Size(281, 348);
            this.gbLoBase.TabIndex = 11;
            this.gbLoBase.TabStop = false;
            this.gbLoBase.Text = "Cơ sở Lô";
            // 
            // dgvLoBase
            // 
            this.dgvLoBase.AllowUserToAddRows = false;
            this.dgvLoBase.AllowUserToDeleteRows = false;
            this.dgvLoBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoBase.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLoBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoBase.Location = new System.Drawing.Point(14, 19);
            this.dgvLoBase.Name = "dgvLoBase";
            this.dgvLoBase.ReadOnly = true;
            this.dgvLoBase.RowHeadersVisible = false;
            this.dgvLoBase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLoBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoBase.ShowCellErrors = false;
            this.dgvLoBase.ShowCellToolTips = false;
            this.dgvLoBase.ShowEditingIcon = false;
            this.dgvLoBase.ShowRowErrors = false;
            this.dgvLoBase.Size = new System.Drawing.Size(174, 307);
            this.dgvLoBase.TabIndex = 6;
            // 
            // btnNewLoBase
            // 
            this.btnNewLoBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewLoBase.Location = new System.Drawing.Point(194, 64);
            this.btnNewLoBase.Name = "btnNewLoBase";
            this.btnNewLoBase.Size = new System.Drawing.Size(75, 23);
            this.btnNewLoBase.TabIndex = 7;
            this.btnNewLoBase.Text = "Thêm mới";
            this.btnNewLoBase.UseVisualStyleBackColor = true;
            this.btnNewLoBase.Click += new System.EventHandler(this.btnNewLoBase_Click);
            // 
            // btnLoBaseDetails
            // 
            this.btnLoBaseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoBaseDetails.Location = new System.Drawing.Point(194, 122);
            this.btnLoBaseDetails.Name = "btnLoBaseDetails";
            this.btnLoBaseDetails.Size = new System.Drawing.Size(75, 23);
            this.btnLoBaseDetails.TabIndex = 9;
            this.btnLoBaseDetails.Text = "Xem chi tiết";
            this.btnLoBaseDetails.UseVisualStyleBackColor = true;
            this.btnLoBaseDetails.Click += new System.EventHandler(this.btnLoBaseDetails_Click);
            // 
            // btnEditLoBase
            // 
            this.btnEditLoBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditLoBase.Location = new System.Drawing.Point(194, 93);
            this.btnEditLoBase.Name = "btnEditLoBase";
            this.btnEditLoBase.Size = new System.Drawing.Size(75, 23);
            this.btnEditLoBase.TabIndex = 8;
            this.btnEditLoBase.Text = "Sửa";
            this.btnEditLoBase.UseVisualStyleBackColor = true;
            this.btnEditLoBase.Click += new System.EventHandler(this.btnEditLoBase_Click);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 529);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tổng Số";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.finished);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.finishup);
            this.tabMain.ResumeLayout(false);
            this.tbKhach.ResumeLayout(false);
            this.tbKhach.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.tbBang.ResumeLayout(false);
            this.tbBang.PerformLayout();
            this.gbDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDe)).EndInit();
            this.gbLo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLo)).EndInit();
            this.tbCoso.ResumeLayout(false);
            this.gbDeBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeBase)).EndInit();
            this.gbLoBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoBase)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpBang;
        private System.Windows.Forms.Button btnXemketqua;
        private System.Windows.Forms.GroupBox gbDe;
        private System.Windows.Forms.DataGridView dgvDe;
        private System.Windows.Forms.GroupBox gbLo;
        private System.Windows.Forms.Button btnLoXemso;
        private System.Windows.Forms.Button btnLoThemso;
        private System.Windows.Forms.Button btnTaobang;
        private System.Windows.Forms.DataGridView dgvLo;
        private System.Windows.Forms.Button btnDeXemso;
        private System.Windows.Forms.Button btnDeThemso;
        private System.Windows.Forms.Label lblDateBang;
        private System.Windows.Forms.Button btnLoBaseDetails;
        private System.Windows.Forms.Button btnEditLoBase;
        private System.Windows.Forms.Button btnNewLoBase;
        private System.Windows.Forms.DataGridView dgvLoBase;
        private System.Windows.Forms.GroupBox gbDeBase;
        private System.Windows.Forms.DataGridView dgvDeBase;
        private System.Windows.Forms.Button btnNewDeBase;
        private System.Windows.Forms.Button btnDeBaseDetails;
        private System.Windows.Forms.Button btnEditDeBase;
        private System.Windows.Forms.GroupBox gbLoBase;
        private System.Windows.Forms.Button btnXemtheokhach;
    }
}