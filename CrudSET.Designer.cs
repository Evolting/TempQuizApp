
namespace QuizApp
{
    partial class CrudSET
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.cbPrivacy = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your SET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = " Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = " Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(114, 271);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 67);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 27);
            this.txtName.TabIndex = 7;
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Location = new System.Drawing.Point(114, 121);
            this.rtxtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(275, 68);
            this.rtxtDesc.TabIndex = 8;
            this.rtxtDesc.Text = "";
            // 
            // cbPrivacy
            // 
            this.cbPrivacy.AutoSize = true;
            this.cbPrivacy.Location = new System.Drawing.Point(114, 220);
            this.cbPrivacy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPrivacy.Name = "cbPrivacy";
            this.cbPrivacy.Size = new System.Drawing.Size(77, 24);
            this.cbPrivacy.TabIndex = 9;
            this.cbPrivacy.Text = "Privacy";
            this.cbPrivacy.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 271);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CrudSET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbPrivacy);
            this.Controls.Add(this.rtxtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrudSET";
            this.Text = "CrudSET";
            this.Load += new System.EventHandler(this.CrudSET_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.CheckBox cbPrivacy;
        private System.Windows.Forms.Button btnCancel;
    }
}