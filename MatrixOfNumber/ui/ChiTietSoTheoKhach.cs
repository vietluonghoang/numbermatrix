using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatrixOfNumber.entities;
using MatrixOfNumber.utilities;

namespace MatrixOfNumber.ui
{
    public partial class ChiTietSoTheoKhach : Form
    {
        private DateTime date;
        private DataTable tblLo;
        private DataTable tblDe;

        public ChiTietSoTheoKhach(DateTime date)
        {
            InitializeComponent(); 
            LoadKhach();
            this.date = date;
            this.lblTitle.Text = "Số ngày: " + String.Format("{0:d-M-yyyy}", date);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            int tonglo = 0;
            int tongde = 0;
            int id = ((Customer)cbbKhach.SelectedItem).KID;
            DataTable tl = tblLo.Clone();
            foreach (DataRow lr in tblLo.Rows)
            {
                if (int.Parse(lr[3].ToString()) == id)
                {
                    tl.Rows.Add(lr.ItemArray);
                    tonglo+=int.Parse(lr[7].ToString());
                }
            }
            DataTable td = tblDe.Clone();
            foreach (DataRow dr in tblDe.Rows)
            {
                if (int.Parse(dr[3].ToString()) == id)
                {
                    td.Rows.Add(dr.ItemArray);
                    tongde += int.Parse(dr[7].ToString());
                }
            }
            dgvDe.DataSource = td;
            dgvLo.DataSource = tl;
            dgvDe.Columns[0].Visible = false;
            dgvDe.Columns[1].Visible = false;
            dgvDe.Columns[2].Visible = false;
            dgvDe.Columns[3].Visible = false;
            dgvDe.Columns[4].Visible = false;
            dgvDe.Columns[5].Visible = false;
            dgvDe.Columns[8].Visible = false;
            dgvDe.Columns[9].Visible = false;
            dgvLo.Columns[0].Visible = false;
            dgvLo.Columns[1].Visible = false;
            dgvLo.Columns[2].Visible = false;
            dgvLo.Columns[3].Visible = false;
            dgvLo.Columns[4].Visible = false;
            dgvLo.Columns[5].Visible = false;
            dgvLo.Columns[8].Visible = false;
            dgvLo.Columns[9].Visible = false;
            lblTongde.Text = "Tổng đề: "+tongde.ToString();
            lblTonglo.Text = "Tổng lô: "+tonglo.ToString();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
