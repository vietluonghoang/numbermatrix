using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MatrixOfNumber.utilities
{
    public partial class ChitietSo : Form
    {
        private Form2 parent;
        public ChitietSo(string date,int type,int number, Form2 parent)
        {
            InitializeComponent();
            loadData(date, type, number);
            this.parent = parent;
        }

        private void loadData(string date, int type, int number)
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
            dgvDetails.Columns[4].HeaderText = "Số điểm";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
