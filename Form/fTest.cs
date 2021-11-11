using QuizApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class fTest : Form
    {
        Test test = new Test();
        List<Question> questions = new List<Question>();
        int setID;
        // tạo clock
        CountDownTimer timer = new CountDownTimer();

        public fTest(Test test, int setID, int duration)
        {
            InitializeComponent();
            this.test = test;
            this.questions = test.questions;
            this.setID = setID;

            //set to 30 mins
            timer.SetTime(duration, 0);

            timer.Start();

            //update label text
            timer.TimeChanged += () => lbTimer.Text = timer.TimeLeftMsStr;

            // show messageBox on timer = 00:00.000
            timer.CountDownFinished += () => 
            {
                MessageBox.Show("Time out");
                int score = 0;
                foreach (var question in questions)
                {
                    if (question.choice != null)
                    {
                        string selected = question.answers[question.choice];
                        if (selected.Equals(question.a)) score += 1;
                    }
                }
                test.score = score;
                fResult frm = new fResult(test, setID);
                this.Close();
                frm.ShowDialog();
            };

            //timer step. By default is 1 second
            timer.StepMs = 77; // for nice milliseconds time switch
        }

        private void fTest_Load(object sender, EventArgs e)
        {
            txtUserID.Text = Common.user.userID.ToString();
            txtSetID.Text = setID.ToString();
            txtTotal.Text = questions.Count.ToString();

            // hiển thị câu hỏi đầu tiên
            rtbQuestion.Text = questions[0].q;
            txtQuestion.Text = "1";
            btnSubmit.Enabled = false;

            // sinh ra các button số câu hỏi
            foreach (var q in questions)
            {
                Button btn = new Button();
                btn.Name = "btn" + q.ID.ToString();
                btn.Width = 40;
                btn.Height = 30;
                btn.Text = q.ID.ToString();
                btn.Click += (sender, args) =>
                {
                    int ID = Int32.Parse(btn.Text);
                    rtbQuestion.Text = questions[ID-1].q;
                    txtQuestion.Text = btn.Text;

                    rbA.Checked = false;
                    rbB.Checked = false;
                    rbC.Checked = false;
                    rbD.Checked = false;

                    switch (test.questions[ID-1].choice)
                    {
                        case "A":
                            rbA.Checked = true;
                            break;
                        case "B":
                            rbB.Checked = true;
                            break;
                        case "C":
                            rbC.Checked = true;
                            break;
                        case "D":
                            rbD.Checked = true;
                            break;
                        default:
                            break;
                    }
                };
                flpQuestion.Controls.Add(btn);
            }
        }

        Control GetControlByName(string Name)
        {
            foreach (Control c in flpQuestion.Controls)
                if (c.Name == Name)
                    return c;

            return null;
        }

        private void rbA_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(txtQuestion.Text);
            test.questions[ID-1].choice = "A";
            Control ctn = GetControlByName("btn"+txtQuestion.Text);
            ctn.BackColor = ColorTranslator.FromHtml("#3DED97");
        }

        private void rbB_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(txtQuestion.Text);
            test.questions[ID-1].choice = "B";
            Control ctn = GetControlByName("btn" + txtQuestion.Text);
            ctn.BackColor = ColorTranslator.FromHtml("#3DED97");
        }

        private void rbC_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(txtQuestion.Text);
            test.questions[ID-1].choice = "C";
            Control ctn = GetControlByName("btn" + txtQuestion.Text);
            ctn.BackColor = ColorTranslator.FromHtml("#3DED97");
        }

        private void rbD_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(txtQuestion.Text);
            test.questions[ID-1].choice = "D";
            Control ctn = GetControlByName("btn" + txtQuestion.Text);
            ctn.BackColor = ColorTranslator.FromHtml("#3DED97");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;

            // xóa lựa chọn khỏi câu hỏi
            int ID = Int32.Parse(txtQuestion.Text);
            test.questions[ID-1].choice = null;
            Control ctn = GetControlByName("btn1");
            ctn.BackColor = System.Drawing.Color.Transparent;
        }

        private void checkAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSubmit.Checked)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timer.Dispose();
            int score = 0;
            foreach (var question in questions)
            {
                if (question.choice != null)
                {
                    string selected = question.answers[question.choice];
                    if (selected.Equals(question.a)) score += 1;
                }
            }
            test.score = score;
            fResult frm = new fResult(test, setID);
            this.Close();
            frm.ShowDialog();
        }
    }
}
