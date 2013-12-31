using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatrixOfNumber.ui;
using MatrixOfNumber.utilities;

namespace MatrixOfNumber
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadKhach("");
        }

        private void finishup(object sender, FormClosingEventArgs e)
        {

        }

        private void finished(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ThemKhach tk = new ThemKhach(this);
                tk.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private void LoadKhach(string name)
        {
            try
            {
                DataConnection dc = new DataConnection();
                DataSet ds = dc.GetAllUsersByName(name);
                dgvKhach.DataSource = ds.Tables[0];
                dgvKhach.Columns[0].Visible = false;
                dgvKhach.Columns[4].Visible = false;
                dgvKhach.Columns[6].Visible = false;
                dgvKhach.Columns[1].HeaderText = "Tên khách";
                dgvKhach.Columns[2].HeaderText = "Liên hệ";
                dgvKhach.Columns[3].HeaderText = "Tài khoản";
                dgvKhach.Columns[5].HeaderText = "Nhóm lô";
                dgvKhach.Columns[7].HeaderText = "Nhóm đề";
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        public void ReloadKhach()
        {
            try
            {
                LoadKhach("");
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvKhach.SelectedRows[0];
                string s = selectedRow.Cells[0].Value.ToString();

                int id = int.Parse(s);
                SuaKhach sk = new SuaKhach(this, id);
                sk.ShowDialog();
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = "Xảy ra lỗi! Hãy thử lại!";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtNameSearch.Text;
            if (name.Contains("'"))
            {
                name = name.Replace("'", "\'");
            }
            LoadKhach(name);
        }

        private void ReloadData(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 0)
            {
                ReloadKhachTab();
            }
        }
        private void ReloadKhachTab()
        {
            txtNameSearch.Text = "";
            LoadKhach("");
        }

        private void btnXemchitietkhach_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvKhach.SelectedRows[0];
                string s = selectedRow.Cells[0].Value.ToString();

                int id = int.Parse(s);
                ChiTietKhach ctk = new ChiTietKhach(id);
                ctk.ShowDialog(this);
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = "Xảy ra lỗi! Hãy thử lại!";
            }
        }
    }
}
