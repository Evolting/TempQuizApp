
namespace QuizApp
{
    partial class fQuizAdd
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
            this.rtxtTerm = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtDefinition = new System.Windows.Forms.RichTextBox();
            this.btnAddQuiz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtTerm
            // 
            this.rtxtTerm.Location = new System.Drawing.Point(104, 35);
            this.rtxtTerm.Name = "rtxtTerm";
            this.rtxtTerm.Size = new System.Drawing.Size(319, 129);
            this.rtxtTerm.TabIndex = 0;
            this.rtxtTerm.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Term:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Definition:";
            // 
            // rtxtDefinition
            // 
            this.rtxtDefinition.Location = new System.Drawing.Point(104, 181);
            this.rtxtDefinition.Name = "rtxtDefinition";
            this.rtxtDefinition.Size = new System.Drawing.Size(319, 200);
            this.rtxtDefinition.TabIndex = 2;
            this.rtxtDefinition.Text = "";
            // 
            // btnAddQuiz
            // 
            this.btnAddQuiz.Location = new System.Drawing.Point(104, 401);
            this.btnAddQuiz.Name = "btnAddQuiz";
            this.btnAddQuiz.Size = new System.Drawing.Size(147, 34);
            this.btnAddQuiz.TabIndex = 4;
            this.btnAddQuiz.Text = "Add Quiz";
            this.btnAddQuiz.UseVisualStyleBackColor = true;
            this.btnAddQuiz.Click += new System.EventHandler(this.btnAddQuiz_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(346, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fQuizAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddQuiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtDefinition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtTerm);
            this.Name = "fQuizAdd";
            this.Text = "Add Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtDefinition;
        private System.Windows.Forms.Button btnAddQuiz;
        private System.Windows.Forms.Button button1;
    }
}