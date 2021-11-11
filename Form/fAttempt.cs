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
    public partial class fAttempt : Form
    {
        int userID;
        int setID;

        public fAttempt(int userID, int setID)
        {
            InitializeComponent();
            this.userID = userID;
            this.setID = setID;
        }

        void reload()
        {
            string criteria;
            string order;

            if (cbCriteria.Text.Equals("Score"))
            {
                criteria = "score";
            }
            else criteria = "takenAt";

            if (cbOrder.Text.Equals("Ascending"))
            {
                order = "asc";
            }
            else order = "desc";

            //MessageBox.Show(criteria+" "+order);
            AttemptDAO adb = new AttemptDAO();
            dgvAttempt.DataSource = adb.getAttempt(userID, setID, criteria, order);
            dgvAttempt.Columns[1].Visible = false;
        }

        private void cbCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            reload();
        }

        private void cbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            reload();
        }

        private void fAttempt_Load(object sender, EventArgs e)
        {
            cbCriteria.SelectedIndex = 0;
            cbOrder.SelectedIndex = 0;

            reload();
        }
    }
}
