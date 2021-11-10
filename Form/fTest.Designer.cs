
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
            this.cbQuestion = new System.Windows.Forms.ComboBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbQuestion
            // 
            this.cbQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuestion.FormattingEnabled = true;
            this.cbQuestion.Location = new System.Drawing.Point(351, 94);
            this.cbQuestion.Name = "cbQuestion";
            this.cbQuestion.Size = new System.Drawing.Size(93, 28);
            this.cbQuestion.TabIndex = 0;
            this.cbQuestion.SelectedIndexChanged += new System.EventHandler(this.cbQuestion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Location = new System.Drawing.Point(180, 128);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(808, 422);
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
            this.btnSubmit.Location = new System.Drawing.Point(894, 38);
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
            this.cbSubmit.Location = new System.Drawing.Point(18, 12);
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
            this.label2.Location = new System.Drawing.Point(673, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Check your submission carefully before submit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Prev";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 566);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(976, 125);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // fTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 709);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSubmit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbAnswer);
            this.Controls.Add(this.rtbQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTest";
            this.Load += new System.EventHandler(this.fTest_Load);
            this.gbAnswer.ResumeLayout(false);
            this.gbAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbQuestion;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}