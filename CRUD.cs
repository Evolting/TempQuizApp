using QuizApp.DAO;
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
    public partial class CRUD : Form
    {
        QuizDAO db = new QuizDAO();
        int setID;
        int userID;
        public CRUD(int setID, int userID)
        {
            InitializeComponent();
            this.setID = setID;
            this.userID = userID;
        }

        public void Reload()
        {
            List<Quiz> list = db.getQuizbySetID(setID);
            txtSetID.DataBindings.Clear();
            rtxtTerm.DataBindings.Clear();
            rtxtDefinition.DataBindings.Clear();

            txtUserID.Text = userID.ToString();
            txtSetID.Text = setID.ToString();
            rtxtTerm.DataBindings.Add("Text", list, "term");
            rtxtDefinition.DataBindings.Add("Text", list, "definition");
            dgvCrudQ.DataSource = list;
            dgvCrudQ.Columns[0].Visible = false;
            dgvCrudQ.Columns[1].Visible = false;

            if (Common.user.userID != userID)
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setID = Int32.Parse(txtSetID.Text);
            fQuizAdd fAdd = new fQuizAdd(setID);
            fAdd.ShowDialog();
            Reload();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var quiz = new Quiz()
            {
                quizID = Int32.Parse(dgvCrudQ.CurrentRow.Cells[0].Value.ToString()),
                setID = Int32.Parse(txtSetID.Text),
                term = rtxtTerm.Text,
                definition = rtxtDefinition.Text
            };
            fQuizUpdate fUpdate = new fQuizUpdate(quiz);
            fUpdate.ShowDialog();
            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var quiz = new Quiz()
                {
                    quizID = Int32.Parse(dgvCrudQ.CurrentRow.Cells[0].Value.ToString())
                };

                if (db.DeleteQuiz(quiz) > 0)
                {
                    MessageBox.Show("Delete success.");
                    Reload();
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            List<Quiz> list = db.getQuizbySetID(Int32.Parse(txtSetID.Text));
            if (list.Count > 4)
            {
                QuizDAO qdb = new QuizDAO();

                int duration = Convert.ToInt32(numTimer.Value.ToString());
                int setID = Int32.Parse(txtSetID.Text);

                Test test = new Test();
                test.score = 0;
                test.questions = qdb.createQuestions(setID);
                fTest f = new fTest(test, setID, duration);
                f.ShowDialog();
            }
            else MessageBox.Show("You should add a few more quiz.");
        }

        private void btnAttempt_Click(object sender, EventArgs e)
        {
            int userID = Int32.Parse(txtUserID.Text);
            int setID = Int32.Parse(txtSetID.Text);
            fAttempt fAtt = new fAttempt(userID, setID);
            fAtt.ShowDialog();
        }

        private void btnHighest_Click(object sender, EventArgs e)
        {
            int userID = Int32.Parse(txtUserID.Text);
            int setID = Int32.Parse(txtSetID.Text);
            fTopScore fTop = new fTopScore(setID);
            fTop.ShowDialog();
        }
    }
}
