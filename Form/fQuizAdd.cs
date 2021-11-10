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
    public partial class fQuizAdd : Form
    {
        int sID;
        QuizDAO db = new QuizDAO();

        public fQuizAdd(int setID)
        {
            InitializeComponent();
            this.sID = setID;
        }

        private void btnAddQuiz_Click(object sender, EventArgs e)
        {
            try
            {
                var quiz = new Quiz()
                {
                    setID = sID,
                    term = rtxtTerm.Text,
                    definition = rtxtDefinition.Text
                };
                if (db.inserQuiz(quiz) > 0)
                {
                    MessageBox.Show("Insert success.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insert failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
