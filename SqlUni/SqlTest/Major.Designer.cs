namespace SqlTest
{
    partial class Major
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
            this.txtIdDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.txtMajorField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdDelete
            // 
            this.txtIdDelete.Location = new System.Drawing.Point(539, 279);
            this.txtIdDelete.Name = "txtIdDelete";
            this.txtIdDelete.Size = new System.Drawing.Size(99, 20);
            this.txtIdDelete.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(652, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 44);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "MajorField";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "MajorID";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(187, 322);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(540, 149);
            this.txtResult.TabIndex = 20;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(652, 195);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 44);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(187, 285);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(153, 26);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(241, 215);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(99, 20);
            this.txtMajorID.TabIndex = 17;
            // 
            // txtMajorField
            // 
            this.txtMajorField.Location = new System.Drawing.Point(241, 249);
            this.txtMajorField.Name = "txtMajorField";
            this.txtMajorField.Size = new System.Drawing.Size(99, 20);
            this.txtMajorField.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID";
            // 
            // Major
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMajorID);
            this.Controls.Add(this.txtMajorField);
            this.Name = "Major";
            this.Text = "Major";
            this.Load += new System.EventHandler(this.Major_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtMajorID;
        private System.Windows.Forms.TextBox txtMajorField;
        private System.Windows.Forms.Label label3;
    }
}