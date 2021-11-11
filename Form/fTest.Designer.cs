
namespace QuizApp
{
    partial class fTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTest));
            this.label1 = new System.Windows.Forms.Label();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.gbAnswer = new System.Windows.Forms.GroupBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbSubmit = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flpQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTimer = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSetID = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Location = new System.Drawing.Point(180, 128);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(793, 422);
            this.rtbQuestion.TabIndex = 2;
            this.rtbQuestion.Text = "";
            // 
            // gbAnswer
            // 
            this.gbAnswer.Controls.Add(this.rbD);
            this.gbAnswer.Controls.Add(this.rbC);
            this.gbAnswer.Controls.Add(this.rbB);
            this.gbAnswer.Controls.Add(this.rbA);
            this.gbAnswer.Location = new System.Drawing.Point(12, 192);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(143, 358);
            this.gbAnswer.TabIndex = 3;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "Answer";
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(26, 284);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(41, 24);
            this.rbD.TabIndex = 3;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.Click += new System.EventHandler(this.rbD_Click);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(27, 201);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(39, 24);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.Click += new System.EventHandler(this.rbC_Click);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(26, 126);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(39, 24);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.Click += new System.EventHandler(this.rbB_Click);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(27, 47);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(40, 24);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.Click += new System.EventHandler(this.rbA_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Choice";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 660);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbSubmit
            // 
            this.cbSubmit.AutoSize = true;
            this.cbSubmit.Location = new System.Drawing.Point(12, 584);
            this.cbSubmit.Name = "cbSubmit";
            this.cbSubmit.Size = new System.Drawing.Size(138, 24);
            this.cbSubmit.TabIndex = 6;
            this.cbSubmit.Text = "I want to submit";
            this.cbSubmit.UseVisualStyleBackColor = true;
            this.cbSubmit.CheckedChanged += new System.EventHandler(this.checkAnswer_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Click here to finish";
            // 
            // flpQuestion
            // 
            this.flpQuestion.Location = new System.Drawing.Point(180, 556);
            this.flpQuestion.Name = "flpQuestion";
            this.flpQuestion.Size = new System.Drawing.Size(793, 133);
            this.flpQuestion.TabIndex = 10;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTimer.ForeColor = System.Drawing.Color.Red;
            this.lbTimer.Location = new System.Drawing.Point(374, 36);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(176, 81);
            this.lbTimer.TabIndex = 11;
            this.lbTimer.Text = "00:00";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(254, 90);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(70, 27);
            this.txtQuestion.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(797, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 119);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(699, 12);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(70, 27);
            this.txtUserID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Set ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total Question";
            // 
            // txtSetID
            // 
            this.txtSetID.Location = new System.Drawing.Point(699, 50);
            this.txtSetID.Name = "txtSetID";
            this.txtSetID.ReadOnly = true;
            this.txtSetID.Size = new System.Drawing.Size(70, 27);
            this.txtSetID.TabIndex = 18;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(699, 90);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(70, 27);
            this.txtTotal.TabIndex = 19;
            // 
            // fTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 701);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSetID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.flpQuestion);
            this.Controls.Add(this.cbSubmit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbAnswer);
            this.Controls.Add(this.rtbQuestion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTest";
            this.Load += new System.EventHandler(this.fTest_Load);
            this.gbAnswer.ResumeLayout(false);
            this.gbAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.GroupBox gbAnswer;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox cbSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpQuestion;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSetID;
        private System.Windows.Forms.TextBox txtTotal;
    }
}