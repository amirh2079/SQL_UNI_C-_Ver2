namespace SqlTest
{
    partial class First
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
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnMajor = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerson
            // 
            this.btnPerson.Location = new System.Drawing.Point(243, 12);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(91, 53);
            this.btnPerson.TabIndex = 0;
            this.btnPerson.Text = "Person";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnMajor
            // 
            this.btnMajor.Location = new System.Drawing.Point(243, 152);
            this.btnMajor.Name = "btnMajor";
            this.btnMajor.Size = new System.Drawing.Size(91, 53);
            this.btnMajor.TabIndex = 1;
            this.btnMajor.Text = "Major";
            this.btnMajor.UseVisualStyleBackColor = true;
            this.btnMajor.Click += new System.EventHandler(this.btnMajor_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(243, 83);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(91, 53);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(243, 219);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(91, 53);
            this.btnTeacher.TabIndex = 3;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 277);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnMajor);
            this.Controls.Add(this.btnPerson);
            this.Name = "First";
            this.Text = "First";
            this.Load += new System.EventHandler(this.First_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnMajor;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnTeacher;
    }
}