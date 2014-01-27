using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatrixOfNumber.ui;

namespace MatrixOfNumber.utilities
{
    public partial class ChitietSo : Form
    {
        private string date;
        private int type;
        private int number;
        private Form2 parent;
        public ChitietSo(string date,int type,int number, Form2 parent)
        {
            InitializeComponent();
            this.date = date;
            this.type = type;
            this.number = number;
            loadData();
            this.parent = parent;
        }

        private void loadData()
        {
            DataConnection dc = new DataConnection();
            DataSet ds = dc.ViewNumberDetails(date, type, number);
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
            dgvDetails.Columns[3].HeaderText = "Tên khách";
            dgvDetails.Columns[4].Visible = false;
            dgvDetails.Columns[5].Visible = false;
            dgvDetails.Columns[6].HeaderText = "Số điểm";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.reloadBang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row= dgvDetails.SelectedRows[0];
            SuaSo ss = new SuaSo(int.Parse(row.Cells[1].Value.ToString())
                                    , int.Parse(row.Cells[2].Value.ToString())
                                    , int.Parse(row.Cells[4].Value.ToString())
                                    , int.Parse(row.Cells[5].Value.ToString())
                                    , int.Parse(row.Cells[6].Value.ToString())
                                    , this);
            ss.ShowDialog(this);
        }

        public void reloadBang()
        {
            loadData();
        }

        private void FormEnter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
