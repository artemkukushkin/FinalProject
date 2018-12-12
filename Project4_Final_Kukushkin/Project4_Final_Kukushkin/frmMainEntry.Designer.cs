namespace Project4_Final_Kukushkin
{
    partial class frmClassSelection
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
            this.components = new System.ComponentModel.Container();
            this.iSMGCoursesDataSet = new Project4_Final_Kukushkin.ISMGCoursesDataSet();
            this.tblCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCoursesTableAdapter = new Project4_Final_Kukushkin.ISMGCoursesDataSetTableAdapters.tblCoursesTableAdapter();
            this.tableAdapterManager = new Project4_Final_Kukushkin.ISMGCoursesDataSetTableAdapters.TableAdapterManager();
            this.tblCoursesComboBox = new System.Windows.Forms.ComboBox();
            this.txtNumCourses = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.calPickDate = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OnlineRB = new System.Windows.Forms.RadioButton();
            this.HybridRB = new System.Windows.Forms.RadioButton();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.lblNumCourses = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblCourseSelection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iSMGCoursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iSMGCoursesDataSet
            // 
            this.iSMGCoursesDataSet.DataSetName = "ISMGCoursesDataSet";
            this.iSMGCoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCoursesBindingSource
            // 
            this.tblCoursesBindingSource.DataMember = "tblCourses";
            this.tblCoursesBindingSource.DataSource = this.iSMGCoursesDataSet;
            // 
            // tblCoursesTableAdapter
            // 
            this.tblCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCoursesTableAdapter = this.tblCoursesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project4_Final_Kukushkin.ISMGCoursesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCoursesComboBox
            // 
            this.tblCoursesComboBox.DataSource = this.tblCoursesBindingSource;
            this.tblCoursesComboBox.DisplayMember = "CourseID";
            this.tblCoursesComboBox.FormattingEnabled = true;
            this.tblCoursesComboBox.Location = new System.Drawing.Point(137, 265);
            this.tblCoursesComboBox.Name = "tblCoursesComboBox";
            this.tblCoursesComboBox.Size = new System.Drawing.Size(227, 21);
            this.tblCoursesComboBox.TabIndex = 1;
            this.tblCoursesComboBox.ValueMember = "CourseID";
            // 
            // txtNumCourses
            // 
            this.txtNumCourses.Location = new System.Drawing.Point(307, 33);
            this.txtNumCourses.Name = "txtNumCourses";
            this.txtNumCourses.Size = new System.Drawing.Size(57, 20);
            this.txtNumCourses.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(199, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 20);
            this.txtName.TabIndex = 3;
            // 
            // calPickDate
            // 
            this.calPickDate.Location = new System.Drawing.Point(137, 91);
            this.calPickDate.Name = "calPickDate";
            this.calPickDate.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OnlineRB);
            this.groupBox1.Controls.Add(this.HybridRB);
            this.groupBox1.Location = new System.Drawing.Point(137, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Type";
            // 
            // OnlineRB
            // 
            this.OnlineRB.AutoSize = true;
            this.OnlineRB.Location = new System.Drawing.Point(137, 19);
            this.OnlineRB.Name = "OnlineRB";
            this.OnlineRB.Size = new System.Drawing.Size(55, 17);
            this.OnlineRB.TabIndex = 1;
            this.OnlineRB.TabStop = true;
            this.OnlineRB.Text = "Online";
            this.OnlineRB.UseVisualStyleBackColor = true;
            // 
            // HybridRB
            // 
            this.HybridRB.AutoSize = true;
            this.HybridRB.Checked = true;
            this.HybridRB.Location = new System.Drawing.Point(41, 19);
            this.HybridRB.Name = "HybridRB";
            this.HybridRB.Size = new System.Drawing.Size(55, 17);
            this.HybridRB.TabIndex = 0;
            this.HybridRB.TabStop = true;
            this.HybridRB.Text = "Hybrid";
            this.HybridRB.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(137, 352);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(96, 25);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "&Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(268, 352);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(96, 25);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "&Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblNumCourses
            // 
            this.lblNumCourses.AutoSize = true;
            this.lblNumCourses.Location = new System.Drawing.Point(12, 36);
            this.lblNumCourses.Name = "lblNumCourses";
            this.lblNumCourses.Size = new System.Drawing.Size(242, 13);
            this.lblNumCourses.TabIndex = 8;
            this.lblNumCourses.Text = "How many classes are you taking next semester?:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "What is your First and Last name?:";
            // 
            // lblSession
            // 
            this.lblSession.AutoEllipsis = true;
            this.lblSession.Location = new System.Drawing.Point(12, 91);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(123, 27);
            this.lblSession.TabIndex = 10;
            this.lblSession.Text = "When will your first class session be held?:";
            // 
            // lblCourseSelection
            // 
            this.lblCourseSelection.AutoSize = true;
            this.lblCourseSelection.Location = new System.Drawing.Point(12, 268);
            this.lblCourseSelection.Name = "lblCourseSelection";
            this.lblCourseSelection.Size = new System.Drawing.Size(98, 13);
            this.lblCourseSelection.TabIndex = 11;
            this.lblCourseSelection.Text = "Select your course:";
            // 
            // frmClassSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 406);
            this.Controls.Add(this.lblCourseSelection);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumCourses);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calPickDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumCourses);
            this.Controls.Add(this.tblCoursesComboBox);
            this.Name = "frmClassSelection";
            this.Text = "Class Selection Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSMGCoursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ISMGCoursesDataSet iSMGCoursesDataSet;
        private System.Windows.Forms.BindingSource tblCoursesBindingSource;
        private ISMGCoursesDataSetTableAdapters.tblCoursesTableAdapter tblCoursesTableAdapter;
        private ISMGCoursesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tblCoursesComboBox;
        private System.Windows.Forms.TextBox txtNumCourses;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MonthCalendar calPickDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OnlineRB;
        private System.Windows.Forms.RadioButton HybridRB;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label lblNumCourses;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblCourseSelection;
    }
}

