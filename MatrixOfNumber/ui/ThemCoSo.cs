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
    public partial class ThemCoSo : Form
    {
        private int type = 0;
        private Form2 parent;

        public ThemCoSo(int type, Form2 parent)
        {
            InitializeComponent();
            this.type = type;
            this.parent = parent;
            cbbLoai.SelectedIndex = type;
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
                        rs = dc.CreateLoBase(tennhom, coso);
                    }
                    else
                    {
                        rs = dc.CreateDeBase(tennhom, coso);
                    }
                    if (rs)
                    {
                        lblError.Text = "Thêm cơ sở thành công.";
                        parent.reloadBang();
                    }
                    else
                    {
                        lblError.Text = "Nhập không đúng. Không thể thêm cơ sở.";
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
