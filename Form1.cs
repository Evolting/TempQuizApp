using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CountDownTimer timer = new CountDownTimer();
            timer.SetTime(0, Convert.ToInt32(textBox1.Text));
            timer.Start();
            timer.TimeChanged += () => label1.Text = timer.TimeLeftMsStr;
            timer.CountDownFinished += () =>
            {
                MessageBox.Show("End");
                label1.Text = "Finish!";
            };
            timer.StepMs = 77;
        }
    }
}
