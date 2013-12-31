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
    public partial class SuaKhach : Form
    {
        private Form2 parent;
        private int kID;

        public SuaKhach(Form2 parent, int kID)
        {
            this.parent = parent;
            this.kID = kID;
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            try
            {
                DataConnection dc = new DataConnection();
                DataSet dslo = dc.GetLoBases();
                List<LoBase> loBaseList = new List<LoBase>();
                foreach (DataRow r in dslo.Tables[0].Rows)
                {
                    loBaseList.Add(new LoBase(int.Parse(r[0].ToString()), r[1].ToString(), float.Parse(r[2].ToString())));
                }
                cbbLoBase.DataSource = loBaseList;
                DataSet dsde = dc.GetDeBases();
                List<DeBase> deBaseList = new List<DeBase>();
                foreach (DataRow r in dsde.Tables[0].Rows)
                {
                    deBaseList.Add(new DeBase(int.Parse(r[0].ToString()), r[1].ToString(), float.Parse(r[2].ToString())));
                }
                cbbDeBase.DataSource = deBaseList;

                DataSet kDS = dc.GetAllUsersByID(kID);
                txtName.Text = (string)kDS.Tables[0].Rows[0][1];
                txtContact.Text = (string)kDS.Tables[0].Rows[0][2];
                txtBalance.Text = ((decimal)kDS.Tables[0].Rows[0][3]).ToString();
                int blID = (int)kDS.Tables[0].Rows[0][4];
                int bdID = (int)kDS.Tables[0].Rows[0][6];
                
                foreach(DataRow r in dsde.Tables[0].Rows)
                {
                    if (int.Parse(r[0].ToString()) == bdID)
                    {
                        DeBase db = new DeBase(int.Parse(r[0].ToString()), r[1].ToString(), float.Parse(r[2].ToString()));
                        foreach (Object item in cbbDeBase.Items)
                        {
                            if (db.BdName.Equals(item.ToString()))
                            {
                                cbbDeBase.SelectedItem = item;
                            }
                        }
                        break;
                    }
                }
                
                foreach (DataRow r in dslo.Tables[0].Rows)
                {
                    if (int.Parse(r[0].ToString()) == blID)
                    {
                        LoBase lb = new LoBase(int.Parse(r[0].ToString()), r[1].ToString(), float.Parse(r[2].ToString()));
                        foreach (Object item in cbbLoBase.Items)
                        {
                            if (lb.BlName.Equals(item.ToString()))
                            {
                                cbbLoBase.SelectedItem = item;
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
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
                    bool rs = dc.editCustomer(kID,blID, bdID, name, contact, balance);
                    if (rs)
                    {
                        lblErrorMsg.Text = "Sửa khách thành công.";
                        parent.ReloadKhach();
                    }
                    else
                    {
                        lblErrorMsg.Text = "Không sửa được.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
        }

        private bool validateData()
        {
            try
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
                    lblErrorMsg.Text = "- Các ô không được để trống." + Environment.NewLine + "- Ô tiền phải là số.";
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!");
                Environment.Exit(0);
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
