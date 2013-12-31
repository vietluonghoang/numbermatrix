using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatrixOfNumber.utilities;

namespace MatrixOfNumber
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private bool isStarted = false;
        private string key = "";

        public Form1()
        {
            InitializeComponent();
            initData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            bool isPassed=dv.openUpCheck(key);
            if (isPassed)
            {
                Form2 f2 = new Form2();
                f2.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fail");
                key = String.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }       
    }
}
