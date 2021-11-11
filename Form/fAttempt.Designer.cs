
namespace QuizApp
{
    partial class fAttempt
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
            this.dgvAttempt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCriteria = new System.Windows.Forms.ComboBox();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttempt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAttempt
            // 
            this.dgvAttempt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttempt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttempt.Location = new System.Drawing.Point(13, 59);
            this.dgvAttempt.Name = "dgvAttempt";
            this.dgvAttempt.RowHeadersWidth = 51;
            this.dgvAttempt.RowTemplate.Height = 29;
            this.dgvAttempt.Size = new System.Drawing.Size(501, 379);
            this.dgvAttempt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order By";
            // 
            // cbCriteria
            // 
            this.cbCriteria.FormattingEnabled = true;
            this.cbCriteria.Items.AddRange(new object[] {
            "Time",
            "Score"});
            this.cbCriteria.Location = new System.Drawing.Point(86, 15);
            this.cbCriteria.Name = "cbCriteria";
            this.cbCriteria.Size = new System.Drawing.Size(151, 28);
            this.cbCriteria.TabIndex = 2;
            this.cbCriteria.SelectedIndexChanged += new System.EventHandler(this.cbCriteria_SelectedIndexChanged);
            // 
            // cbOrder
            // 
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Items.AddRange(new object[] {
            "Descending",
            "Ascending"});
            this.cbOrder.Location = new System.Drawing.Point(265, 15);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(151, 28);
            this.cbOrder.TabIndex = 3;
            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            // 
            // fAttempt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.cbOrder);
            this.Controls.Add(this.cbCriteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAttempt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fAttempt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attempt History";
            this.Load += new System.EventHandler(this.fAttempt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttempt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttempt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCriteria;
        private System.Windows.Forms.ComboBox cbOrder;
    }
}