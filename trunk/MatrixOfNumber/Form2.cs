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
        private DataTable tblLo;
        private DataTable tblDe;

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
            if (tabMain.SelectedIndex == 1)
            {
                dtpBang.Value = DateTime.Now;
                loadBang();
            }
            if (tabMain.SelectedIndex == 2)
            {
                LoadBases();
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


        public void reloadBang()
        {
            loadBang();
        }
        private void loadBang()
        {
            try
            {
                DataConnection dc = new DataConnection();
                string datetime = String.Format("{0:d-M-yyyy}", dtpBang.Value);
                DataSet ds = dc.GetNumberByDate(datetime);
                tblDe = new DataTable();
                DataColumn col = new DataColumn("nID", typeof(int));
                tblDe.Columns.Add(col);
                col = new DataColumn("mID", typeof(int));
                tblDe.Columns.Add(col);
                col = new DataColumn("mDate", typeof(string));
                tblDe.Columns.Add(col);
                col = new DataColumn("kID", typeof(int));
                tblDe.Columns.Add(col);
                col = new DataColumn("kName", typeof(string));
                tblDe.Columns.Add(col);
                col = new DataColumn("nType", typeof(int));
                tblDe.Columns.Add(col);
                col = new DataColumn("Số", typeof(int));
                tblDe.Columns.Add(col);
                col = new DataColumn("Điểm", typeof(int));
                tblDe.Columns.Add(col);

                tblLo = new DataTable();
                col = new DataColumn("nID", typeof(int));
                tblLo.Columns.Add(col);
                col = new DataColumn("mID", typeof(int));
                tblLo.Columns.Add(col);
                col = new DataColumn("mDate", typeof(string));
                tblLo.Columns.Add(col);
                col = new DataColumn("kID", typeof(int));
                tblLo.Columns.Add(col);
                col = new DataColumn("kName", typeof(string));
                tblLo.Columns.Add(col);
                col = new DataColumn("nType", typeof(int));
                tblLo.Columns.Add(col);
                col = new DataColumn("Số", typeof(int));
                tblLo.Columns.Add(col);
                col = new DataColumn("Điểm", typeof(int));
                tblLo.Columns.Add(col);

                if (ds != null)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (int.Parse(row[5].ToString()) == 0)
                        {
                            DataRow r = tblLo.NewRow();
                            r[0] = row[0];
                            r[1] = row[1];
                            r[2] = row[2];
                            r[3] = row[3];
                            r[4] = row[4];
                            r[5] = row[5];
                            r[6] = row[6];
                            r[7] = row[7];
                            bool isExisted = false;
                            foreach (DataRow tlRow in tblLo.Rows)
                            {
                                if (int.Parse(tlRow[6].ToString()) == int.Parse(r[6].ToString()))
                                {
                                    tlRow[7] = int.Parse(tlRow[7].ToString()) + int.Parse(r[7].ToString());
                                    isExisted = true;
                                }
                            }
                            if (!isExisted)
                            {
                                tblLo.Rows.Add(r);
                            }
                        }
                        else
                        {
                            DataRow r = tblDe.NewRow();
                            r[0] = row[0];
                            r[1] = row[1];
                            r[2] = row[2];
                            r[3] = row[3];
                            r[4] = row[4];
                            r[5] = row[5];
                            r[6] = row[6];
                            r[7] = row[7];
                            bool isExisted = false;
                            foreach (DataRow tlRow in tblDe.Rows)
                            {
                                if (int.Parse(tlRow[6].ToString()) == int.Parse(r[6].ToString()))
                                {
                                    tlRow[7] = int.Parse(tlRow[7].ToString()) + int.Parse(r[7].ToString());
                                    isExisted = true;
                                }
                            }
                            if (!isExisted)
                            {
                                tblDe.Rows.Add(r);
                            }
                        }
                    }
                    btnLoThemso.Enabled = true;
                    btnDeThemso.Enabled = true;
                    btnTaobang.Enabled = false;
                    btnXemketqua.Enabled = true;
                    btnDeXemso.Enabled = true;
                    btnLoXemso.Enabled = true;
                }
                else
                {
                    tblDe = new DataTable();
                    DataColumn emptyCol = new DataColumn(" ", typeof(string));
                    tblDe.Columns.Add(emptyCol);
                    DataRow r = tblDe.NewRow();
                    r[0] = "Không có";
                    tblDe.Rows.Add(r);
                    tblLo = new DataTable();
                    emptyCol = new DataColumn(" ", typeof(string));
                    tblLo.Columns.Add(emptyCol);
                    r = tblLo.NewRow();
                    r[0] = "Không có";
                    tblLo.Rows.Add(r);

                    btnDeThemso.Enabled = false;
                    btnLoThemso.Enabled = false;
                    btnTaobang.Enabled = true;
                    btnXemketqua.Enabled = false;
                    btnDeXemso.Enabled = false;
                    btnLoXemso.Enabled = false;
                }
                dgvLo.DataSource = tblLo;
                if (dgvLo.Columns.Count > 1)
                {
                    dgvLo.Columns[0].Visible = false;
                    dgvLo.Columns[1].Visible = false;
                    dgvLo.Columns[2].Visible = false;
                    dgvLo.Columns[3].Visible = false;
                    dgvLo.Columns[4].Visible = false;
                    dgvLo.Columns[5].Visible = false;
                }
                dgvDe.DataSource = tblDe;
                if (dgvDe.Columns.Count > 1)
                {
                    dgvDe.Columns[0].Visible = false;
                    dgvDe.Columns[1].Visible = false;
                    dgvDe.Columns[2].Visible = false;
                    dgvDe.Columns[3].Visible = false;
                    dgvDe.Columns[4].Visible = false;
                    dgvDe.Columns[5].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private void btnLoThemso_Click(object sender, EventArgs e)
        {
            string datetime = String.Format("{0:d-M-yyyy}", dtpBang.Value);

            ThemSo ts = new ThemSo(0, datetime, this);
            ts.ShowDialog(this);
        }

        private void btnDeThemso_Click(object sender, EventArgs e)
        {
            string datetime = String.Format("{0:d-M-yyyy}", dtpBang.Value);
            ThemSo ts = new ThemSo(1, datetime, this);
            ts.ShowDialog(this);
        }

        private void btnTaobang_Click(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            string datetime = String.Format("{0:d-M-yyyy}", dtpBang.Value);
            bool rs = dc.CreateNewMatrix(datetime);
            if (rs)
            {
                loadBang();
                MessageBox.Show("Bảng mới đã tạo thành công!");
            }
            else
            {
                MessageBox.Show("Không thể tạo được bảng!");
            }
        }

        private void dtpBang_ValueChanged(object sender, EventArgs e)
        {
            loadBang();
        }

        private void btnLoXemso_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvLo.SelectedRows[0];
                string str = selectedRow.Cells[6].Value.ToString();
                int number = int.Parse(str);
                string datetime = String.Format("{0:d-M-yyyy}", dtpBang.Value);
                ChitietSo cts = new ChitietSo(datetime, 0, number, this);
                cts.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private void btnDeXemso_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvDe.SelectedRows[0];
                string str = selectedRow.Cells[6].Value.ToString();
                int number = int.Parse(str);
                string datetime = String.Format("{0:d-M-yyyy}", dtpBang.Value);
                ChitietSo cts = new ChitietSo(datetime, 1, number, this);
                cts.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private void BangEnter(object sender, EventArgs e)
        {
            loadBang();
        }

        private void LoadBases()
        {
            try
            {
                DataConnection dc = new DataConnection();
                DataSet dsde = dc.GetDeBases();
                DataSet dslo = dc.GetLoBases();
                dgvDeBase.DataSource = dsde.Tables[0];
                dgvLoBase.DataSource = dslo.Tables[0];
                dgvDeBase.Columns[0].Visible = false;
                dgvLoBase.Columns[0].Visible = false;
                dgvDeBase.Columns[1].HeaderText = "Tên nhóm";
                dgvDeBase.Columns[2].HeaderText = "Cơ sở";
                dgvLoBase.Columns[1].HeaderText = "Tên nhóm";
                dgvLoBase.Columns[2].HeaderText = "Cơ sở";
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }
        public void reloadBases()
        {
            LoadBases();
        }

        private void btnNewDeBase_Click(object sender, EventArgs e)
        {
            ThemCoSo tcs = new ThemCoSo(1, this);
            tcs.ShowDialog(this);
        }

        private void btnNewLoBase_Click(object sender, EventArgs e)
        {
            ThemCoSo tcs = new ThemCoSo(0, this);
            tcs.ShowDialog(this);
        }

        private void btnEditLoBase_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvLoBase.SelectedRows[0];
            SuaCoSo scs = new SuaCoSo(0, int.Parse(row.Cells[0].Value.ToString())
                                        , row.Cells[1].Value.ToString()
                                        , float.Parse(row.Cells[2].Value.ToString())
                                        , this);
            scs.ShowDialog(this);
        }

        private void btnEditDeBase_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvDeBase.SelectedRows[0];
            SuaCoSo scs = new SuaCoSo(1, int.Parse(row.Cells[0].Value.ToString())
                                        , row.Cells[1].Value.ToString()
                                        , float.Parse(row.Cells[2].Value.ToString())
                                        , this);
            scs.ShowDialog(this);
        }

        private void btnDeBaseDetails_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvDeBase.SelectedRows[0];
            ChiTietCoSo ctcs = new ChiTietCoSo(int.Parse(row.Cells[0].Value.ToString()), 1);
            ctcs.ShowDialog(this);
        }

        private void btnLoBaseDetails_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvLoBase.SelectedRows[0];
            ChiTietCoSo ctcs = new ChiTietCoSo(int.Parse(row.Cells[0].Value.ToString()), 0);
            ctcs.ShowDialog(this);
        }
    }
}
