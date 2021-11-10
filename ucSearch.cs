﻿using QuizApp.DAO;
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
    public partial class ucSearch : UserControl
    {
        QuizDAO qdb = new QuizDAO();

        private static ucSearch _instance;
        public static ucSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSearch();
                return _instance;
            }
        }

        public ucSearch()
        {
            InitializeComponent();
            Reload();
        }

        void Reload()
        {
            cbCriteria.SelectedIndex = 0;
            cbOrder.SelectedIndex = 0;
        }

        private void ucSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtQuery.Text.Length > 0)
            {
                string query = txtQuery.Text;

                string criteria = cbCriteria.SelectedItem.ToString();
                if (criteria.Equals("Name")) criteria = "quizName";
                else criteria = "createdDate";

                string order = cbOrder.SelectedItem.ToString();
                if (order.Equals("Ascending")) order = "asc";
                else order = "desc";

                List<QuizSet> result = qdb.getSetByName(query, criteria, order);
                dgvResult.DataSource = result;
                dgvResult.Columns[6].Visible = false;
                txtResultCount.Text = result.Count.ToString();
            }
            else MessageBox.Show("Please enter a query first");
        }

        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int setID = Int32.Parse(dgvResult.CurrentRow.Cells[0].Value.ToString());
            int userID = Int32.Parse(dgvResult.CurrentRow.Cells[0].Value.ToString());
            CRUD _crud = new CRUD(setID, userID);
            _crud.ShowDialog();
        }
    }
}
