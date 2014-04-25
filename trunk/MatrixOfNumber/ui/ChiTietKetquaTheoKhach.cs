using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatrixOfNumber.utilities;
using MatrixOfNumber.entities;

namespace MatrixOfNumber.ui
{
    public partial class ChiTietKetquaTheoKhach : Form
    {
        private DateTime date;
        private DataTable tblLo;
        private DataTable tblDe;
        private List<TypeNumber> kqua;
        private float duocLo;
        private float thuaLo;
        private float duocDe;
        private float thuaDe;

        public ChiTietKetquaTheoKhach(DateTime date, List<TypeNumber> kqua)
        {
            InitializeComponent();
            LoadKhach();
            this.date = date;
            this.lblTitle.Text = "Kết quả ngày: " + String.Format("{0:d-M-yyyy}", date);
            this.kqua = kqua;
        }

        private void LoadKhach()
        {
            try
            {
                DataConnection dc = new DataConnection();
                DataSet ds = dc.GetAllUsersByName("");
                List<Customer> list = new List<Customer>();
                Object obj = null;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Customer cus = new Customer((int)row[0], (string)row[1]);
                    list.Add(cus);
                }
                cbbKhach.DataSource = list;
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private void loadBang()
        {
            try
            {
                DataConnection dc = new DataConnection();
                DataSet ds = dc.GetSummaryByDate(String.Format("{0:d-M-yyyy}", date));
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
                col = new DataColumn("deBaseName", typeof(string));
                tblDe.Columns.Add(col);
                col = new DataColumn("deBase", typeof(float));
                tblDe.Columns.Add(col);
                col = new DataColumn("Được", typeof(float));
                tblDe.Columns.Add(col);
                col = new DataColumn("Thua", typeof(float));
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
                col = new DataColumn("loBaseName", typeof(string));
                tblLo.Columns.Add(col);
                col = new DataColumn("loBase", typeof(float));
                tblLo.Columns.Add(col);
                col = new DataColumn("Được", typeof(float));
                tblLo.Columns.Add(col);
                col = new DataColumn("Thua", typeof(float));
                tblLo.Columns.Add(col);

                if (ds != null && ds.Tables[0].Rows.Count > 0)
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
                            r[8] = row[8];
                            r[9] = row[9];

                            float duoc = int.Parse(row[7].ToString()) * float.Parse(row[9].ToString());
                            float thua = int.Parse(row[7].ToString()) * 80;

                            bool trung = false;
                            foreach (TypeNumber kq in kqua)
                            {
                                if ((int.Parse(row[6].ToString()) == kq.Number) && kq.Type == 0)
                                {
                                    trung = true;
                                    break;
                                }

                            }
                            if (trung)
                            {
                                duoc = 0;
                            }
                            else
                            {
                                thua = 0;
                            }
                            r[10] = duoc;
                            r[11] = thua;

                            tblLo.Rows.Add(r);
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
                            r[8] = row[10];
                            r[9] = row[11];
                            float duoc = int.Parse(row[7].ToString());
                            float thua = int.Parse(row[7].ToString()) * float.Parse(row[11].ToString());

                            bool trung = false;
                            foreach (TypeNumber kq in kqua)
                            {
                                if ((int.Parse(row[6].ToString()) == kq.Number) && kq.Type == 1)
                                {
                                    trung = true;
                                    break;
                                }

                            }
                            if (trung)
                            {
                                duoc = 0;
                            }
                            else
                            {
                                thua = 0;
                            }
                            r[10] = duoc;
                            r[11] = thua;

                            tblDe.Rows.Add(r);
                        }
                    }

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
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!" + e.Message);
                Environment.Exit(0);
            }
        }

        private void loadData()
        {
            loadBang();
            duocDe = 0;
            duocLo = 0;
            thuaDe = 0;
            thuaLo = 0;
            int id = ((Customer)cbbKhach.SelectedItem).KID;
            DataTable tl = tblLo.Clone();
            foreach (DataRow lr in tblLo.Rows)
            {
                if (!(tblLo.Columns.Count > 7))
                {
                    tl.Rows.Add(lr.ItemArray);
                }
                else
                {
                    if (int.Parse(lr[3].ToString()) == id)
                    {
                        tl.Rows.Add(lr.ItemArray);
                        duocLo += float.Parse(lr[10].ToString());
                        thuaLo += float.Parse(lr[11].ToString());
                    }
                }
            }
            DataTable td = tblDe.Clone();
            foreach (DataRow dr in tblDe.Rows)
            {
                if (!(tblDe.Columns.Count > 7))
                {
                    td.Rows.Add(dr.ItemArray);
                }
                else
                {
                    if (int.Parse(dr[3].ToString()) == id)
                    {
                        td.Rows.Add(dr.ItemArray);
                        duocDe += float.Parse(dr[10].ToString());
                        thuaDe += float.Parse(dr[11].ToString());
                    }
                }
            }
            dgvDe.DataSource = td;
            dgvLo.DataSource = tl;
            if (!(tblDe.Columns.Count > 7))
            {
                dgvDe.Columns[0].Visible = false;
                dgvDe.Columns[1].Visible = false;
                dgvDe.Columns[2].Visible = false;
                dgvDe.Columns[3].Visible = false;
                dgvDe.Columns[4].Visible = false;
                dgvDe.Columns[5].Visible = false;
                dgvDe.Columns[8].Visible = false;
                dgvDe.Columns[9].Visible = false;
            }
            if (!(tblLo.Columns.Count > 7))
            {
                dgvLo.Columns[0].Visible = false;
                dgvLo.Columns[1].Visible = false;
                dgvLo.Columns[2].Visible = false;
                dgvLo.Columns[3].Visible = false;
                dgvLo.Columns[4].Visible = false;
                dgvLo.Columns[5].Visible = false;
                dgvLo.Columns[8].Visible = false;
                dgvLo.Columns[9].Visible = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadData();
            lblDuocDe.Text = "Được: " + duocDe.ToString();
            lblThuaDe.Text = "Thua: " + thuaDe.ToString();
            lblDuocLo.Text = "Được: " + duocLo.ToString();
            lblThuaLo.Text = "Thua: " + thuaLo.ToString();
            float tongde = duocDe - thuaDe;
            float tonglo = duocLo - thuaLo;
            if (tongde > 0)
            {
                lblTongDe.ForeColor = Color.Blue;
            }
            else
            {
                lblTongDe.ForeColor = Color.Red;
            }
            if (tonglo > 0)
            {
                lblTongLo.ForeColor = Color.Blue;
            }
            else
            {
                lblTongLo.ForeColor = Color.Red;
            }
            lblTongDe.Text = "Tổng: " + Math.Abs(tongde).ToString();
            lblTongLo.Text = "Tổng: " + Math.Abs(tonglo).ToString();
            float tongket = tongde + tonglo;
            if (tongket > 0)
            {
                lblTongket.ForeColor = Color.Blue;
                lblTongket.Text = "Hôm nay được của khách: " + Math.Abs(tongket).ToString();
            }
            else
            {
                lblTongket.ForeColor = Color.Red;
                lblTongket.Text = "Hôm nay thua với khách: " + Math.Abs(tongket).ToString();
            }
        }

        private void cbbKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
            lblDuocDe.Text = "Được: " + duocDe.ToString();
            lblThuaDe.Text = "Thua: " + thuaDe.ToString();
            lblDuocLo.Text = "Được: " + duocLo.ToString();
            lblThuaLo.Text = "Thua: " + thuaLo.ToString();
            float tongde = duocDe - thuaDe;
            float tonglo = duocLo - thuaLo;
            if (tongde > 0)
            {
                lblTongDe.ForeColor = Color.Blue;
            }
            else
            {
                lblTongDe.ForeColor = Color.Red;
            }
            if (tonglo > 0)
            {
                lblTongLo.ForeColor = Color.Blue;
            }
            else
            {
                lblTongLo.ForeColor = Color.Red;
            }
            lblTongDe.Text = "Tổng: " + Math.Abs(tongde).ToString();
            lblTongLo.Text = "Tổng: " + Math.Abs(tonglo).ToString();
            float tongket = tongde + tonglo;
            if (tongket > 0)
            {
                lblTongket.ForeColor = Color.Blue;
                lblTongket.Text = "Hôm nay được của khách: " + Math.Abs(tongket).ToString();
            }
            else
            {
                lblTongket.ForeColor = Color.Red;
                lblTongket.Text = "Hôm nay thua với khách: " + Math.Abs(tongket).ToString();
            }
        }

        private void cbbKhach_SelectedValueChanged(object sender, EventArgs e)
        {
            loadData();
            lblDuocDe.Text = "Được: " + duocDe.ToString();
            lblThuaDe.Text = "Thua: " + thuaDe.ToString();
            lblDuocLo.Text = "Được: " + duocLo.ToString();
            lblThuaLo.Text = "Thua: " + thuaLo.ToString();
            float tongde = duocDe - thuaDe;
            float tonglo = duocLo - thuaLo;
            if (tongde > 0)
            {
                lblTongDe.ForeColor = Color.Blue;
            }
            else
            {
                lblTongDe.ForeColor = Color.Red;
            }
            if (tonglo > 0)
            {
                lblTongLo.ForeColor = Color.Blue;
            }
            else
            {
                lblTongLo.ForeColor = Color.Red;
            }
            lblTongDe.Text = "Tổng: " + Math.Abs(tongde).ToString();
            lblTongLo.Text = "Tổng: " + Math.Abs(tonglo).ToString();
            float tongket = tongde + tonglo;
            if (tongket > 0)
            {
                lblTongket.ForeColor = Color.Blue;
                lblTongket.Text = "Hôm nay được của khách: " + Math.Abs(tongket).ToString();
            }
            else
            {
                lblTongket.ForeColor = Color.Red;
                lblTongket.Text = "Hôm nay thua với khách: " + Math.Abs(tongket).ToString();
            }
        }

    }
}
