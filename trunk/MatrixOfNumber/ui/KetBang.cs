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

namespace MatrixOfNumber.ui
{
    public partial class KetBang : Form
    {
        private DateTime date;
        private DataTable tblLo;
        private DataTable tblDe;
        private ArrayList kqua;
        public KetBang(DateTime date)
        {
            InitializeComponent();
            this.date = date;
            this.lblTitle.Text = "Kết quả ngày: " + String.Format("{0:d-M-yyyy}",date);
            loadData();
        }

        private void loadData()
        {
            kqua = new ArrayList();
            kqua.Add(1);
            kqua.Add(2);
            kqua.Add(3);
            kqua.Add(4);
            loadBang();
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
                            foreach (ArrayList kq in kqua)
                            {
                                if (row[6] == kq)
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
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!"+e.Message);
                Environment.Exit(0);
            }
        }
    }
}
