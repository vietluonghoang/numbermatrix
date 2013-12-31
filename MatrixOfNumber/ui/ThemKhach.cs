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
    public partial class ThemKhach : Form
    {
        Form2 parent;

        public ThemKhach(Form2 parent)
        {
            InitializeComponent();
            initData();
            this.parent = parent;
        }

        private void initData()
        {
            DataConnection dc = new DataConnection();
            DataSet dslo = dc.GetLoBases();
            List<LoBase> loBaseList = new List<LoBase>();
            foreach (DataRow r in dslo.Tables[0].Rows)
            {
                loBaseList.Add(new LoBase(int.Parse(r[0].ToString()),r[1].ToString(),float.Parse(r[2].ToString())));
            }
            cbbLoBase.DataSource = loBaseList;
            DataSet dsde = dc.GetDeBases();
            List<DeBase> deBaseList = new List<DeBase>();
            foreach (DataRow r in dsde.Tables[0].Rows)
            {
                deBaseList.Add(new DeBase(int.Parse(r[0].ToString()), r[1].ToString(), float.Parse(r[2].ToString())));
            }
            cbbDeBase.DataSource = deBaseList;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                DeBase selectedDeBase = (DeBase)cbbDeBase.SelectedItem;
                int bdID = selectedDeBase.BdID;
                LoBase selectedLoBase = (LoBase)cbbLoBase.SelectedItem;
                int blID = selectedLoBase.BlID;
                string name = txtName.Text;
                string contact = txtContact.Text;
                string balance = txtBalance.Text;

                DataConnection dc = new DataConnection();
                bool rs=dc.AddNewCustomer(blID.ToString(), bdID.ToString(), name, contact, balance);
                if (rs)
                {
                    lblErrorMsg.Text = "Tạo khách mới thành công.";
                    txtBalance.Text = "0";
                    txtContact.Text = "";
                    txtName.Text = "";
                    cbbDeBase.SelectedIndex = 0;
                    cbbDeBase.SelectedIndex = 0;
                    parent.ReloadKhach();
                }
                else
                {
                    lblErrorMsg.Text = "Không tạo được.";
                }
            }
        }

        private bool validateData()
        {
            string name = txtName.Text;
            string contact = txtContact.Text;
            string balance = txtBalance.Text;
            bool isValidName = true;
            bool isValidContact = true;
            bool isValidBalance = true;
            lblBalanceError.Text = "";
            lblContactError.Text = "";
            lblNameError.Text = "";
            lblErrorMsg.Text = "";

            DataValidation dv = new DataValidation();
            if (dv.isEmpty(name))
            {
                isValidName = false;
                lblNameError.Text = "*";
            }
            if (dv.isEmpty(contact))
            {
                isValidContact = false;
                lblContactError.Text = "*";
            }
            if (dv.isEmpty(balance))
            {
                isValidBalance = false;
                lblBalanceError.Text = "*";
            }
            else
            {
                if (!dv.isFloat(balance))
                {
                    isValidBalance = false;
                    lblBalanceError.Text = "*";
                }
            }
            if (!isValidBalance || !isValidContact || !isValidName)
            {
                lblErrorMsg.Text = "- Các ô không được để trống." +Environment.NewLine+"- Ô tiền phải là số.";
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
