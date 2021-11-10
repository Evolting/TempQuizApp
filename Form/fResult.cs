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
    public partial class fResult : Form
    {
        Test test = new Test();
        DateTime takenAt;
        int setID;

        public fResult(Test test, int setID)
        {
            InitializeComponent();
            this.test = test;
            takenAt = DateTime.Now;
            this.setID = setID;
        }

        private void fResult_Load(object sender, EventArgs e)
        {
            txtScore.Text = test.score.ToString();
            List<Result> results = new List<Result>();
            foreach (var q in test.questions)
            {
                Result result = new Result()
                {
                    ID = q.ID,
                    question = q.quest,
                    answer = q.a,
                    selected = "None",
                    mark = 0
                };
                if (q.choice != null) result.selected = q.answers[q.choice];
                if (result.selected.Equals(result.answer)) result.mark = 1;
                results.Add(result);
            }
            dgvResult.DataSource = results;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to save this attempt", "Save Attempt Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResultDAO rdb = new ResultDAO();
                double mark = ((double) test.score*10) / test.questions.Count;
                mark = Math.Round(mark, 2);
                if (rdb.saveResult(setID, mark.ToString(), takenAt) > 0)
                {
                    
                    MessageBox.Show("Save successfully!");
                }
                else
                {
                    MessageBox.Show("Save failed successfully!");
                }
            }
            this.Close();
        }
    }
}
