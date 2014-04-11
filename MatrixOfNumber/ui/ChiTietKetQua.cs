using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatrixOfNumber.utilities;

namespace MatrixOfNumber.ui
{
    public partial class ChiTietKetQua : Form
    {
        private string date;
        private int type;
        private int number;
        private int duoc;
        private KetBang parent;

        public ChiTietKetQua(string date, int type, int number,int duoc, KetBang parent)
        {
            InitializeComponent();
            this.date = date;
            this.type = type;
            this.number = number;
            this.duoc = duoc;
            loadData();
            this.parent = parent;
        }

        private void loadData()
        {
            DataConnection dc = new DataConnection();
            DataSet ds = dc.GetSummaryByDate(date);
            DataColumn duocCol = new DataColumn("Được", typeof(string));
            ds.Tables[0].Columns.Add(duocCol);
            DataColumn thuaCol = new DataColumn("Thua", typeof(string));
            ds.Tables[0].Columns.Add(thuaCol);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (int.Parse(row[6].ToString()) != number || int.Parse(row[5].ToString()) != type)
                {
                    row.Delete();
                }
                else
                {
                    if (type == 0)
                    {
                        if (duoc == 0)
                        {
                            row[12] = 0;
                            row[13] = int.Parse(row[7].ToString()) * 80;
                        }
                        else
                        {
                            row[13] = 0;
                            row[12] = int.Parse(row[7].ToString()) * float.Parse(row[9].ToString());
                        }
                    }
                    else
                    {
                        if (duoc == 0)
                        {
                            row[12] = 0;
                            row[13] = int.Parse(row[7].ToString()) * float.Parse(row[11].ToString());
                        }
                        else
                        {
                            row[13] = 0;
                            row[12] = int.Parse(row[7].ToString());
                        }
                    }
                }
            }
            dgvDetails.DataSource = ds.Tables[0];
            
            lblNgayDtl.Text = date;
            lblSoDtl.Text = number.ToString();
            if (type == 0)
            {
                lblLoaiDtl.Text = "Lô";
            }
            else
            {
                lblLoaiDtl.Text = "Đề";
            }
            dgvDetails.Columns[0].Visible = false;
            dgvDetails.Columns[1].Visible = false;
            dgvDetails.Columns[2].Visible = false;
            dgvDetails.Columns[3].Visible = false;
            dgvDetails.Columns[4].HeaderText = "Tên khách";
            dgvDetails.Columns[5].Visible = false;
            dgvDetails.Columns[6].Visible = false;
            dgvDetails.Columns[7].HeaderText = "Số điểm";
            dgvDetails.Columns[8].Visible = false;
            dgvDetails.Columns[9].Visible = false;
            dgvDetails.Columns[10].Visible = false;
            dgvDetails.Columns[11].Visible = false;
            dgvDetails.Columns[12].HeaderText = "Được";
            dgvDetails.Columns[13].HeaderText = "Thua";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
