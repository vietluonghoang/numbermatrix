﻿using System;
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
    public partial class ThemSo : Form
    {
        private int type;
        private string date;
        private Form2 parent;
        public ThemSo(int type, string date, Form2 parent)
        {
            InitializeComponent();
            LoadKhach();
            if (type > -1 && type < 2)
            {
                cbbLoDe.SelectedIndex = type;
            }
            else
            {
                cbbLoDe.SelectedIndex = 0;
            }
            this.type = type;
            this.date = date;
            this.parent = parent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int id = 0;
            int number = 0;
            int coin = 0;
            bool ready = true;
            try
            {
                try
                {
                    id = ((Customer)cbbKhach.SelectedItem).KID;
                    number = int.Parse((string)cbbSo.SelectedItem);
                    coin = int.Parse(txtDiem.Text);
                }
                catch (Exception ex)
                {
                    lblErrorMsg.Text = "Nhập không đúng.";
                    ready = false;
                }
                if (ready)
                {
                    DataConnection dc = new DataConnection();
                    bool rs = dc.AddNewNumber(date, id, cbbLoDe.SelectedIndex, number, coin);
                    if (rs)
                    {
                        lblErrorMsg.Text = "Thêm số thành công.";
                        parent.reloadBang();
                    }
                    else
                    {
                        lblErrorMsg.Text = "Nhập không đúng. Không thể thêm số.";
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
