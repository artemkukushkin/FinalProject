namespace Project4_Final_Kukushkin
{
    partial class frmConfirmation
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
            this.txtConfNumCourses = new System.Windows.Forms.TextBox();
            this.txtConfName = new System.Windows.Forms.TextBox();
            this.txtConfDate = new System.Windows.Forms.TextBox();
            this.txtConfClass = new System.Windows.Forms.TextBox();
            this.txtConfType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConfNumCourses
            // 
            this.txtConfNumCourses.Location = new System.Drawing.Point(146, 53);
            this.txtConfNumCourses.Name = "txtConfNumCourses";
            this.txtConfNumCourses.ReadOnly = true;
            this.txtConfNumCourses.Size = new System.Drawing.Size(100, 20);
            this.txtConfNumCourses.TabIndex = 0;
            // 
            // txtConfName
            // 
            this.txtConfName.Location = new System.Drawing.Point(146, 104);
            this.txtConfName.Name = "txtConfName";
            this.txtConfName.ReadOnly = true;
            this.txtConfName.Size = new System.Drawing.Size(100, 20);
            this.txtConfName.TabIndex = 1;
            // 
            // txtConfDate
            // 
            this.txtConfDate.Location = new System.Drawing.Point(146, 162);
            this.txtConfDate.Name = "txtConfDate";
            this.txtConfDate.ReadOnly = true;
            this.txtConfDate.Size = new System.Drawing.Size(100, 20);
            this.txtConfDate.TabIndex = 2;
            // 
            // txtConfClass
            // 
            this.txtConfClass.Location = new System.Drawing.Point(146, 226);
            this.txtConfClass.Name = "txtConfClass";
            this.txtConfClass.ReadOnly = true;
            this.txtConfClass.Size = new System.Drawing.Size(100, 20);
            this.txtConfClass.TabIndex = 3;
            // 
            // txtConfType
            // 
            this.txtConfType.Location = new System.Drawing.Point(146, 288);
            this.txtConfType.Name = "txtConfType";
            this.txtConfType.ReadOnly = true;
            this.txtConfType.Size = new System.Drawing.Size(100, 20);
            this.txtConfType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of courses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selected class:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Class type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "The following information was recorded!";
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(120, 339);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 11;
            this.btnOkay.Text = "&Okay!";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 425);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfType);
            this.Controls.Add(this.txtConfClass);
            this.Controls.Add(this.txtConfDate);
            this.Controls.Add(this.txtConfName);
            this.Controls.Add(this.txtConfNumCourses);
            this.Name = "frmConfirmation";
            this.Text = "frmConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfNumCourses;
        private System.Windows.Forms.TextBox txtConfName;
        private System.Windows.Forms.TextBox txtConfDate;
        private System.Windows.Forms.TextBox txtConfClass;
        private System.Windows.Forms.TextBox txtConfType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOkay;
    }
}