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
    public partial class SuaSo : Form
    {
        private int kID;
        private int mID;
        private int nType;
        private int nNumber;
        private ChitietSo parent;
        public SuaSo(int mID, int kID, int nType, int nNumber, int nCoin, ChitietSo parent)
        {
            this.kID = kID;
            this.mID = mID;
            this.nType = nType;
            this.nNumber = nNumber;
            InitializeComponent();
            LoadKhach();
            cbbLoDe.SelectedIndex = nType;
            cbbSo.SelectedIndex = nNumber;
            txtDiem.Text = nCoin.ToString();
            this.parent = parent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                bool ready = true;
                int id=0;
                int number = 0;
                int type = 0;
                int coin = 0;
                try
                {
                    id = ((Customer)cbbKhach.SelectedItem).KID;
                    number = int.Parse((string)cbbSo.SelectedItem);
                    try
                    {
                        coin = int.Parse(txtDiem.Text);
                    }
                    catch (Exception ex)
                    {
                        lblErrorMsg.Text = "Nhập không đúng.";
                        ready = false;
                    }
                    type = cbbLoDe.SelectedIndex;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                    ready = false;
                }
                if (ready)
                {
                    DataConnection dc = new DataConnection();
                    int changeType = 0;
                    if (id != kID || number != nNumber || type != nType)
                    {
                        changeType = 1;
                    }
                    bool rs = dc.EditNumber(mID, id, type, number, coin, changeType);
                    if (rs)
                    {
                        lblErrorMsg.Text = "Sửa số thành công.";
                        parent.reloadBang();
                    }
                    else
                    {
                        lblErrorMsg.Text = "Nhập không đúng.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }
    }
}
