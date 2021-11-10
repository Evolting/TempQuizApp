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
    public partial class fQuizUpdate : Form
    {
        Quiz q;
        QuizDAO db = new QuizDAO();

        public fQuizUpdate(Quiz quiz)
        {
            InitializeComponent();
            this.q = quiz;
        }

        private void btnUpdateQuiz_Click(object sender, EventArgs e)
        {
            q.term = rtxtTerm.Text;
            q.definition = rtxtDefinition.Text;
            try
            {
                if (db.UpdateQuiz(q) > 0)
                {
                    MessageBox.Show("Update success.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update failed");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void fQuizUpdate_Load(object sender, EventArgs e)
        {
            rtxtTerm.Text = q.term;
            rtxtDefinition.Text = q.definition;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
