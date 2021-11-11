
namespace QuizApp
{
    partial class fQuizUpdate
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
            this.btnUpdateQuiz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtDefinition = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtTerm = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateQuiz
            // 
            this.btnUpdateQuiz.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateQuiz.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateQuiz.Location = new System.Drawing.Point(110, 395);
            this.btnUpdateQuiz.Name = "btnUpdateQuiz";
            this.btnUpdateQuiz.Size = new System.Drawing.Size(126, 34);
            this.btnUpdateQuiz.TabIndex = 9;
            this.btnUpdateQuiz.Text = "Update Quiz";
            this.btnUpdateQuiz.UseVisualStyleBackColor = false;
            this.btnUpdateQuiz.Click += new System.EventHandler(this.btnUpdateQuiz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Definition:";
            // 
            // rtxtDefinition
            // 
            this.rtxtDefinition.Location = new System.Drawing.Point(110, 175);
            this.rtxtDefinition.Name = "rtxtDefinition";
            this.rtxtDefinition.Size = new System.Drawing.Size(319, 200);
            this.rtxtDefinition.TabIndex = 7;
            this.rtxtDefinition.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Term:";
            // 
            // rtxtTerm
            // 
            this.rtxtTerm.Location = new System.Drawing.Point(110, 29);
            this.rtxtTerm.Name = "rtxtTerm";
            this.rtxtTerm.Size = new System.Drawing.Size(319, 129);
            this.rtxtTerm.TabIndex = 5;
            this.rtxtTerm.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(352, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fQuizUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateQuiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtDefinition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtTerm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fQuizUpdate";
            this.Text = "Update Quiz";
            this.Load += new System.EventHandler(this.fQuizUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateQuiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtDefinition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtTerm;
        private System.Windows.Forms.Button btnCancel;
    }
}