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
using System.Data.SqlClient;

namespace MatrixOfNumber
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Timer pgTimer;
        private int pgPercentage;
        private bool isStarted = false;
        private string key = "";

        public Form1()
        {
            InitializeComponent();
            initData();
            dtpBang.Select();
            dgvResult.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDate.Focus();
            if (!isStarted)
            {
                createTimer();
                isStarted = true;
            }
            else
            {
                resetTimer();
            }
            this.key += "a";
        }

        private void btnHidden2_Click(object sender, EventArgs e)
        {
            lblDate.Focus();
            if (!isStarted)
            {
                createTimer();
                isStarted = true;
            }
            else
            {
                resetTimer();
            }
            this.key += "b";
        }

        private void btnHidden3_Click(object sender, EventArgs e)
        {
            lblDate.Focus();
            if (!isStarted)
            {
                createTimer();
                isStarted = true;
            }
            else
            {
                resetTimer();
            }
            this.key += "c";
        }

        private void btnHidden4_Click(object sender, EventArgs e)
        {
            lblDate.Focus();
            if (!isStarted)
            {
                createTimer();
                isStarted = true;
            }
            else
            {
                resetTimer();
            }
            this.key += "d";
        }

        private void createTimer()
        {
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void resetTimer()
        {
            timer.Stop();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            isStarted = false;
            DataValidation dv = new DataValidation();
            bool isPassed = dv.openUpCheck(key);
            if (isPassed)
            {
                Form2 f2 = new Form2();
                f2.Show(this);
                this.Hide();
            }
            else
            {
                key = String.Empty;                
                initProgress();
            }
        }

        private void initProgress()
        {
            pgPercentage = 0;
            pgTimer = new Timer();
            pgbCooldown.Value = 0;
            pgTimer.Interval = 30;
            pgTimer.Tick += new EventHandler(pgTimer_Tick);
            pgTimer.Start();
            lblLoading.Visible = true;
            pgbCooldown.Visible = true;
            lblLoading.BackColor = Color.Transparent;
        }

        private void pgTimer_Tick(object sender, EventArgs e)
        {
            pgPercentage += 1;
            pgbCooldown.Value=pgPercentage;
            lblLoading.Text = "Loading..." + pgbCooldown.Value + "%";
            if (pgPercentage == 100)
            {
                new DataConnection().refuseAll();
                pgTimer.Stop();
                lblLoading.Visible = false;
                pgbCooldown.Visible = false;                
            }
        }

        private void dtpBang_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dtpBang.Value;
                DataConnection dc = new DataConnection();
                DataSet ds = dc.getResultByDate(date);
                Result result;
                string datetime = String.Format("{0:d-M-yyyy}", date);
                string header = "KẾT QUẢ XỔ SỐ MIỀN BẮC NGÀY " + datetime;
                List<Prize> prz = new List<Prize>();
                lblDate.Text = datetime;
                string[] title = { "Giải đặc biệt", "Giải nhất", "Giải nhì", "Giải ba", "Giải tư", "Giải năm", "Giải sáu", "Giải bảy" };
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int i = int.Parse(row[1].ToString());
                        Prize p = new Prize(title[i], row[2].ToString());
                        prz.Add(p);
                    }
                    result = new Result(datetime, header, prz);
                    initResultTable(result);
                }
                else
                {
                    if ((DateTime.Now.Day - date.Day > 5 && DateTime.Now.Month == date.Month)
                            || (DateTime.Now.Month > date.Month && ((DateTime.Now.Day + (30 - date.Day)) > 5))
                            || (DateTime.Now.Month < date.Month)
                            || (DateTime.Now.Day < date.Day && DateTime.Now.Month == date.Month))
                    {
                        Prize p = new Prize("...", "Không có kết quả.");
                        prz.Add(p);
                        result = new Result(datetime, header, prz);
                        initResultTable(result);
                    }
                    else if (DateTime.Now.Date == date.Date
                                && DateTime.Now.Hour == 18
                                && DateTime.Now.Minute > 10
                                && DateTime.Now.Minute < 30)
                    {
                        Prize p = new Prize("...", "Đang quay, chờ tẹo nhé.");
                        prz.Add(p);
                        result = new Result(datetime, header, prz);
                        initResultTable(result);
                    }
                    else
                    {
                        GetDataFromWeb gdfw = new GetDataFromWeb();
                        result = gdfw.getResult(datetime);
                        initResultTable(result);
                        dc.insertResult(result, date);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Hãy kiểm tra lại!" + ex.Message);
                Environment.Exit(0);
            }
        }

        private void pgbCooldown_Click(object sender, EventArgs e)
        {
            pgTimer.Stop();
            lblLoading.Visible = false;
            pgbCooldown.Visible = false;
        }
    }
}
