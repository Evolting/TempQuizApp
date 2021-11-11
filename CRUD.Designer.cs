﻿
namespace QuizApp
{
    partial class CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCrudQ = new System.Windows.Forms.DataGridView();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Definition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSetID = new System.Windows.Forms.TextBox();
            this.rtxtDefinition = new System.Windows.Forms.RichTextBox();
            this.rtxtTerm = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHighest = new System.Windows.Forms.Button();
            this.btnAttempt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrudQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Term";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(714, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Definition";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(804, 109);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = " Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCrudQ
            // 
            this.dgvCrudQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCrudQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrudQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Term,
            this.Definition});
            this.dgvCrudQ.Location = new System.Drawing.Point(12, 76);
            this.dgvCrudQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCrudQ.Name = "dgvCrudQ";
            this.dgvCrudQ.RowHeadersWidth = 51;
            this.dgvCrudQ.RowTemplate.Height = 25;
            this.dgvCrudQ.Size = new System.Drawing.Size(685, 574);
            this.dgvCrudQ.TabIndex = 12;
            // 
            // Term
            // 
            this.Term.DataPropertyName = "term";
            this.Term.HeaderText = "Term";
            this.Term.MinimumWidth = 6;
            this.Term.Name = "Term";
            // 
            // Definition
            // 
            this.Definition.DataPropertyName = "definition";
            this.Definition.HeaderText = "Definition";
            this.Definition.MinimumWidth = 6;
            this.Definition.Name = "Definition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "setID";
            // 
            // txtSetID
            // 
            this.txtSetID.Location = new System.Drawing.Point(629, 35);
            this.txtSetID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSetID.Name = "txtSetID";
            this.txtSetID.ReadOnly = true;
            this.txtSetID.Size = new System.Drawing.Size(68, 27);
            this.txtSetID.TabIndex = 14;
            // 
            // rtxtDefinition
            // 
            this.rtxtDefinition.Location = new System.Drawing.Point(804, 368);
            this.rtxtDefinition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtDefinition.Name = "rtxtDefinition";
            this.rtxtDefinition.Size = new System.Drawing.Size(276, 210);
            this.rtxtDefinition.TabIndex = 15;
            this.rtxtDefinition.Text = "";
            // 
            // rtxtTerm
            // 
            this.rtxtTerm.Location = new System.Drawing.Point(804, 170);
            this.rtxtTerm.Name = "rtxtTerm";
            this.rtxtTerm.Size = new System.Drawing.Size(276, 157);
            this.rtxtTerm.TabIndex = 16;
            this.rtxtTerm.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(939, 619);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 31);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(992, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(898, 109);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 38);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(471, 35);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(68, 27);
            this.txtUserID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "UserID";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Lime;
            this.btnTest.Location = new System.Drawing.Point(12, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(127, 50);
            this.btnTest.TabIndex = 22;
            this.btnTest.Text = "Take a Test!";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(146, 36);
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(88, 27);
            this.numTimer.TabIndex = 23;
            this.numTimer.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(146, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Set a Time Limit Here";
            // 
            // btnHighest
            // 
            this.btnHighest.Location = new System.Drawing.Point(804, 38);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(105, 46);
            this.btnHighest.TabIndex = 25;
            this.btnHighest.Text = "Top Score";
            this.btnHighest.UseVisualStyleBackColor = true;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // btnAttempt
            // 
            this.btnAttempt.Location = new System.Drawing.Point(975, 38);
            this.btnAttempt.Name = "btnAttempt";
            this.btnAttempt.Size = new System.Drawing.Size(105, 46);
            this.btnAttempt.TabIndex = 26;
            this.btnAttempt.Text = "Your Attempt";
            this.btnAttempt.UseVisualStyleBackColor = true;
            this.btnAttempt.Click += new System.EventHandler(this.btnAttempt_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 663);
            this.Controls.Add(this.btnAttempt);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTimer);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtxtTerm);
            this.Controls.Add(this.rtxtDefinition);
            this.Controls.Add(this.txtSetID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCrudQ);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrudQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCrudQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSetID;
        private System.Windows.Forms.RichTextBox rtxtDefinition;
        private System.Windows.Forms.RichTextBox rtxtTerm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn Definition;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.Button btnAttempt;
    }
}