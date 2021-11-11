using QuizApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class fTopScore : Form
    {
        int setID;

        public fTopScore(int setID)
        {
            InitializeComponent();
            this.setID = setID;
        }

        private void fTopScore_Load(object sender, EventArgs e)
        {
            AttemptDAO adb = new AttemptDAO();
            dgvTop.DataSource = adb.getTopScore(setID);
            dgvTop.Columns[0].Visible = false;
        }
    }
}
