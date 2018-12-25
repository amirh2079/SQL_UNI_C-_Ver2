namespace SqlTest
{
    partial class Teacher
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "ID";
            // 
            // txtIdDelete
            // 
            this.txtIdDelete.Location = new System.Drawing.Point(519, 297);
            this.txtIdDelete.Name = "txtIdDelete";
            this.txtIdDelete.Size = new System.Drawing.Size(99, 20);
            this.txtIdDelete.TabIndex = 58;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(632, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 44);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "MajorID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "PersonID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "TeacherID";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(167, 335);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(540, 149);
            this.txtResult.TabIndex = 53;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(632, 213);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 44);
            this.btnSelect.TabIndex = 52;
            this.btnSelect.Text = "select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(167, 298);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 30);
            this.btnSubmit.TabIndex = 51;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Location = new System.Drawing.Point(223, 190);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(99, 20);
            this.txtTeacherID.TabIndex = 50;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(223, 224);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(99, 20);
            this.txtPersonID.TabIndex = 49;
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(223, 261);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(99, 20);
            this.txtMajorID.TabIndex = 48;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 591);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.txtMajorID);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.TextBox txtMajorID;
    }
}