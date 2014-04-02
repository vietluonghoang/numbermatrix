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
    public partial class SuaCoSo : Form
    {
        private int type = 0;
        private Form2 parent;
        private int baseID = 0;
        private string tennhom="";
        private float coso=0;

        public SuaCoSo(int type, int baseID, string tennhom, float coso, Form2 parent)
        {
            InitializeComponent();
            this.type = type;
            this.baseID = baseID;
            this.tennhom = tennhom;
            this.coso = coso;
            this.parent = parent;
            initData();
        }

        private void initData(){
            txtCoso.Text=this.coso.ToString();
            txtTennhom.Text=this.tennhom;
            this.cbbLoai.SelectedIndex=this.type;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            parent.reloadBases();
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float coso = 0;
            string tennhom = "";
            bool ready = true;
            try
            {
                try
                {
                    coso = float.Parse(txtCoso.Text);
                    tennhom = txtTennhom.Text;
                }
                catch (Exception ex)
                {
                    lblError.Text = "Nhập không đúng.";
                    ready = false;
                }
                if (ready)
                {
                    DataConnection dc = new DataConnection();
                    bool rs = false;
                    if (type == 0)
                    {
                        rs = dc.EditLoBase(baseID, tennhom, coso);
                    }
                    else
                    {
                        rs = dc.EditDeBase(baseID, tennhom, coso);
                    }
                    if (rs)
                    {
                        lblError.Text = "Sửa cơ sở thành công.";
                        parent.reloadBases();
                    }
                    else
                    {
                        lblError.Text = "Nhập không đúng. Không thể sửa cơ sở.";
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
