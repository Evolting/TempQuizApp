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

        public fTest(Test test, int setID)
        {
            InitializeComponent();
            this.test = test;
            this.questions = test.questions;
            this.setID = setID;
        }

        private void fTest_Load(object sender, EventArgs e)
        {
            cbQuestion.DataSource = questions;
            cbQuestion.DisplayMember = "ID";
            cbQuestion.ValueMember = "ID";
            rtbQuestion.Text = questions[0].q;
            btnSubmit.Enabled = false;
        }

        private void cbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Int32.Parse(cbQuestion.SelectedIndex.ToString());
            rtbQuestion.Text = questions[ID].q;

            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;

            switch (test.questions[ID].choice)
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
        }

        private void rbA_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(cbQuestion.SelectedIndex.ToString());
            test.questions[ID].choice = "A";
        }

        private void rbB_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(cbQuestion.SelectedIndex.ToString());
            test.questions[ID].choice = "B";
        }

        private void rbC_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(cbQuestion.SelectedIndex.ToString());
            test.questions[ID].choice = "C";
        }

        private void rbD_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(cbQuestion.SelectedIndex.ToString());
            test.questions[ID].choice = "D";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;

            // xóa lựa chọn khỏi câu hỏi
            int ID = Int32.Parse(cbQuestion.SelectedIndex.ToString());
            test.questions[ID].choice = null;
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
