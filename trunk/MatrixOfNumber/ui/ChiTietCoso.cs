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
    public partial class ChiTietCoSo : Form
    {
        private int baseID;
        private int type;

        public ChiTietCoSo(int baseID, int type)
        {
            InitializeComponent();
            this.baseID = baseID;
            this.type = type;
            initData();
        }

        private void initData()
        {
            DateTime currentDate = DateTime.Now;
            dtpTo.Value = currentDate;

            DateTime fromDate = DateTime.Now.AddDays(-7);
            dtpFrom.Value = fromDate;

            LoadHistory(fromDate, currentDate);
            DataValidation dv = new DataValidation();
            string convertedFromDate = dv.GetSecondsFromDateDiff(fromDate).ToString();
            string convertedToDate = dv.GetSecondsFromDateDiff(currentDate).ToString();

            DataConnection dc = new DataConnection();
            DataSet dsh = dc.GetBaseHistoryByID(this.type, this.baseID, convertedFromDate, convertedToDate);
            lblTennhomDetails.Text = dsh.Tables[0].Rows[0][2].ToString();
            lblCosoDetails.Text = dsh.Tables[0].Rows[0][3].ToString();
            if (type == 0)
            {
                lblTypeDetails.Text = "Lô";
            }
            else
            {
                lblTypeDetails.Text = "Đề";
            }
        }

        private void LoadHistory(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataValidation dv = new DataValidation();
                string convertedFromDate = dv.GetSecondsFromDateDiff(fromDate).ToString();
                string convertedToDate = dv.GetSecondsFromDateDiff(toDate).ToString();

                DataConnection dc = new DataConnection();
                DataSet dsh = dc.GetBaseHistoryByID(this.type, this.baseID, convertedFromDate, convertedToDate);

                if (dsh != null)
                {
                    dgvHistory.DataSource = dsh.Tables[0];
                    dgvHistory.Columns[0].Visible = false;
                    dgvHistory.Columns[1].Visible = false;
                    dgvHistory.Columns[2].Visible = false;
                    dgvHistory.Columns[3].Visible = false;
                    dgvHistory.Columns[4].HeaderText = "Tên nhóm cũ";
                    dgvHistory.Columns[5].HeaderText = "Tên nhóm mới";
                    dgvHistory.Columns[6].HeaderText = "Cơ sở cũ";
                    dgvHistory.Columns[7].HeaderText = "Cơ sở mới";
                    dgvHistory.Columns[8].HeaderText = "Ngày thay đổi";
                }
                else
                {
                    lblError.Text = "Không tìm thấy bản ghi nào.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadHistory(dtpFrom.Value, dtpTo.Value);
        }
    }
}
