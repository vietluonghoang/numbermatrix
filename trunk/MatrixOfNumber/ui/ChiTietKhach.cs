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
    public partial class ChiTietKhach : Form
    {
        private int kID;
        public ChiTietKhach(int kID)
        {
            InitializeComponent();
            this.kID = kID;
            initData();
        }

        private void initData()
        {
            try
            {
                DataConnection dc = new DataConnection();
                DataSet dsc = dc.GetAllUsersByID(kID);
                lblBalance.Text = dsc.Tables[0].Rows[0][3].ToString();
                lblDeBase.Text = dsc.Tables[0].Rows[0][7].ToString();
                lblLoBase.Text = dsc.Tables[0].Rows[0][5].ToString();
                lblName.Text = dsc.Tables[0].Rows[0][1].ToString();

                string contactSource = dsc.Tables[0].Rows[0][2].ToString();
                string contact = "";
                int lineLength = 70;
                if (contactSource.Length > lineLength)
                {
                    string[] splitted = contactSource.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    string temp = "";
                    foreach (string s in splitted)
                    {
                        temp = temp + s + " ";
                        contact = contact + s + " ";
                        if (temp.Length > lineLength)
                        {
                            contact = contact + Environment.NewLine;
                            temp = "";
                        }
                    }
                }
                else
                {
                    contact = contactSource;
                }
                lblContact.Text = contact;

                //prepare current date
                DateTime currentDate = DateTime.Now;
                dtpTo.Value = currentDate;

                DateTime fromDate = DateTime.Now.AddDays(-7);
                dtpFrom.Value = fromDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private void LoadHistory(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataValidation dv=new DataValidation();
                string convertedFromDate = dv.GetSecondsFromDateDiff(fromDate).ToString();
                string convertedToDate = dv.GetSecondsFromDateDiff(toDate).ToString();
                
                DataConnection dc = new DataConnection();
                DataSet dsh = dc.GetUserHistoryByID(kID, convertedFromDate, convertedToDate);

                if (dsh != null)
                {
                    dgvHistory.DataSource = dsh.Tables[0];
                    dgvHistory.Columns[0].Visible = false;
                    dgvHistory.Columns[1].Visible = false;
                    dgvHistory.Columns[2].Visible = false;
                    dgvHistory.Columns[3].HeaderText = "Cơ sở lô cũ";
                    dgvHistory.Columns[4].HeaderText = "Cơ sở lô mới";
                    dgvHistory.Columns[5].HeaderText = "Cơ sở đề cũ";
                    dgvHistory.Columns[6].HeaderText = "Cơ sở đề mới";
                    dgvHistory.Columns[7].HeaderText = "Số tài khoản cũ";
                    dgvHistory.Columns[8].HeaderText = "Số tài khoản mới";
                    dgvHistory.Columns[9].HeaderText = "Ngày thay đổi";                    
                }
                else
                {
                    lblErrorMsg.Text = "Không tìm thấy bản ghi nào.";
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
