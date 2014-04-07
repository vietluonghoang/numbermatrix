using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatrixOfNumber.utilities;
using System.Collections;
using MatrixOfNumber.entities;

namespace MatrixOfNumber.ui
{
    public partial class KetBang : Form
    {
        private DateTime date;
        private DataTable tblLo;
        private DataTable tblDe;
        List<TypeNumber> kqua;
        private float duocLo;
        private float thuaLo;
        private float duocDe;
        private float thuaDe;

        public KetBang(DateTime date)
        {
            InitializeComponent();
            this.date = date;
            this.lblTitle.Text = "Kết quả ngày: " + String.Format("{0:d-M-yyyy}", date);
            initData(date);
            loadData();
        }

        private void initData(DateTime date)
        {
            DataConnection dc = new DataConnection();
            kqua = dc.getNumberType(date);
        }

        private void loadData()
        {
            //kqua = new ArrayList();
            //kqua.Add(1);
            //kqua.Add(2);
            //kqua.Add(3);
            //kqua.Add(4);
            loadBang();
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
            lblTongDe.Text = "Tổng: "+Math.Abs(tongde).ToString();
            lblTongLo.Text = "Tổng: "+Math.Abs(tonglo).ToString();
            float tongket = tongde + tonglo;
            if (tongket > 0)
            {
                lblTongket.ForeColor = Color.Blue;
                lblTongket.Text = "Hôm nay được: " + Math.Abs(tongket).ToString();
            }
            else
            {
                lblTongket.ForeColor = Color.Red;
                lblTongket.Text = "Hôm nay thua: " + Math.Abs(tongket).ToString();
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
                            r[8] = row[8];
                            r[9] = row[9];

                            float duoc = int.Parse(row[7].ToString()) * float.Parse(row[9].ToString());
                            float thua = int.Parse(row[7].ToString()) * 80;

                            bool trung = false;
                            foreach (TypeNumber kq in kqua)
                            {
                                if ((int.Parse(row[6].ToString()) == kq.Number)&&kq.Type==0)
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

                            bool isExisted = false;
                            foreach (DataRow tlRow in tblLo.Rows)
                            {
                                if (int.Parse(tlRow[6].ToString()) == int.Parse(r[6].ToString()))
                                {
                                    tlRow[7] = int.Parse(tlRow[7].ToString()) + int.Parse(r[7].ToString());
                                    tlRow[10] = float.Parse(tlRow[10].ToString()) + float.Parse(r[10].ToString());
                                    tlRow[11] = float.Parse(tlRow[11].ToString()) + float.Parse(r[11].ToString());
                                    isExisted = true;
                                }
                            }
                            if (!isExisted)
                            {
                                tblLo.Rows.Add(r);
                            }
                            duocLo += float.Parse(r[10].ToString());
                            thuaLo += float.Parse(r[11].ToString());
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

                            bool isExisted = false;
                            foreach (DataRow tdRow in tblDe.Rows)
                            {
                                if (int.Parse(tdRow[6].ToString()) == int.Parse(r[6].ToString()))
                                {
                                    tdRow[7] = int.Parse(tdRow[7].ToString()) + int.Parse(r[7].ToString());
                                    tdRow[10] = float.Parse(tdRow[10].ToString()) + float.Parse(r[10].ToString());
                                    tdRow[11] = float.Parse(tdRow[11].ToString()) + float.Parse(r[11].ToString());
                                    isExisted = true;
                                }
                            }
                            if (!isExisted)
                            {
                                tblDe.Rows.Add(r);
                            }
                            duocDe += float.Parse(r[10].ToString());
                            thuaDe += float.Parse(r[11].ToString());
                        }
                    }

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
                    dgvLo.Columns[8].Visible = false;
                    dgvLo.Columns[9].Visible = false;
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
                    dgvDe.Columns[8].Visible = false;
                    dgvDe.Columns[9].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!" + e.Message);
                Environment.Exit(0);
            }
        }

        private void btnLoXemso_Click(object sender, EventArgs e)
        {

        }
    }
}
