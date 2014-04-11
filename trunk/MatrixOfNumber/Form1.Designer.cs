using System.Drawing;
using System.Windows.Forms;
using System;
using MatrixOfNumber.utilities;
using MatrixOfNumber.entities;
using System.Data;
using System.Collections.Generic;

namespace MatrixOfNumber
{
    partial class Form1
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
            this.btnHidden1 = new System.Windows.Forms.Button();
            this.btnHidden2 = new System.Windows.Forms.Button();
            this.btnHidden3 = new System.Windows.Forms.Button();
            this.btnHidden4 = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHidden1
            // 
            this.btnHidden1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHidden1.BackColor = System.Drawing.Color.Transparent;
            this.btnHidden1.FlatAppearance.BorderSize = 0;
            this.btnHidden1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHidden1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHidden1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidden1.Location = new System.Drawing.Point(597, 1);
            this.btnHidden1.Name = "btnHidden1";
            this.btnHidden1.Size = new System.Drawing.Size(75, 23);
            this.btnHidden1.TabIndex = 0;
            this.btnHidden1.UseVisualStyleBackColor = false;
            this.btnHidden1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHidden2
            // 
            this.btnHidden2.BackColor = System.Drawing.Color.Transparent;
            this.btnHidden2.FlatAppearance.BorderSize = 0;
            this.btnHidden2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHidden2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHidden2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidden2.Location = new System.Drawing.Point(0, 1);
            this.btnHidden2.Name = "btnHidden2";
            this.btnHidden2.Size = new System.Drawing.Size(75, 23);
            this.btnHidden2.TabIndex = 1;
            this.btnHidden2.UseVisualStyleBackColor = true;
            this.btnHidden2.Click += new System.EventHandler(this.btnHidden2_Click);
            // 
            // btnHidden3
            // 
            this.btnHidden3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHidden3.BackColor = System.Drawing.Color.Transparent;
            this.btnHidden3.FlatAppearance.BorderSize = 0;
            this.btnHidden3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHidden3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHidden3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidden3.Location = new System.Drawing.Point(0, 293);
            this.btnHidden3.Name = "btnHidden3";
            this.btnHidden3.Size = new System.Drawing.Size(75, 23);
            this.btnHidden3.TabIndex = 2;
            this.btnHidden3.UseVisualStyleBackColor = true;
            this.btnHidden3.Click += new System.EventHandler(this.btnHidden3_Click);
            // 
            // btnHidden4
            // 
            this.btnHidden4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHidden4.BackColor = System.Drawing.Color.Transparent;
            this.btnHidden4.FlatAppearance.BorderSize = 0;
            this.btnHidden4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHidden4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHidden4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidden4.Location = new System.Drawing.Point(597, 293);
            this.btnHidden4.Name = "btnHidden4";
            this.btnHidden4.Size = new System.Drawing.Size(75, 23);
            this.btnHidden4.TabIndex = 3;
            this.btnHidden4.UseVisualStyleBackColor = true;
            this.btnHidden4.Click += new System.EventHandler(this.btnHidden4_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(237, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(194, 22);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Kết quả xổ số miền bắc";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(299, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "01-01-2013";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.ColumnHeadersVisible = false;
            this.dgvResult.Enabled = false;
            this.dgvResult.Location = new System.Drawing.Point(186, 81);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvResult.Size = new System.Drawing.Size(304, 170);
            this.dgvResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 316);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnHidden4);
            this.Controls.Add(this.btnHidden3);
            this.Controls.Add(this.btnHidden2);
            this.Controls.Add(this.btnHidden1);
            this.Name = "Form1";
            this.Text = "Kết quả xổ số miền bắc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void initData()
        {
            try
            {
                //prepare current date
                DateTime currentDate = DateTime.Now;
                DateTime date=currentDate;
                if ((currentDate.Hour >= 18 && currentDate.Minute > 30)||(currentDate.Hour >= 19))
                {
                    date = currentDate;
                }
                else if ((currentDate.Hour >= 18 && currentDate.Minute < 30) && (currentDate.Hour >= 18 && currentDate.Minute > 15))
                {
                    MessageBox.Show("Đang quay, chờ tý nhé!");
                    Environment.Exit(0);

                }else
                {
                    date = currentDate.AddHours(-24);
                }

                string datetime = String.Format("{0:d-M-yyyy}", date);
                lblDate.Text = datetime;
                //prepare result of the day
                initResult(datetime);
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }
        private void initResult(string date)
        {
            try
            {
                GetDataFromWeb gd = new GetDataFromWeb();
                Result result = null;
                try
                {
                    result = gd.getResult(date);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                    Environment.Exit(0);
                }
                DataSet ds = new DataSet();
                DataTable dt = new DataTable("result");
                dt.Columns.Add(new DataColumn("", typeof(String)));
                dt.Columns.Add(new DataColumn("", typeof(String)));
                if (result == null)
                {
                    MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                    Environment.Exit(0);
                }
                List<Prize> prz = result.Prizes;
                foreach (Prize p in prz)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = p.Label;
                    dr[1] = p.Number;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
                dgvResult.DataSource = ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private Button btnHidden1;
        private Button btnHidden2;
        private Button btnHidden3;
        private Button btnHidden4;
        private Label lblHeader;
        private Label lblDate;
        private DataGridView dgvResult;
    }
}

