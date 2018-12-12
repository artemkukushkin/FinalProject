using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_Final_Kukushkin
{
    public partial class frmClassSelection : Form
    {
        public frmClassSelection()
        {
            InitializeComponent();
        }

        private void tblCoursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCoursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSMGCoursesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSMGCoursesDataSet.tblCourses' table. You can move, or remove it, as needed.
            this.tblCoursesTableAdapter.Fill(this.iSMGCoursesDataSet.tblCourses);

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())     //takes all the fields though my validation code, if passes, the values are sored in the instance of a custom class.
                {
                    Courses myNewCourse = new Courses();
                    myNewCourse.NumCourses = Convert.ToInt16(txtNumCourses.Text);
                    myNewCourse.FullName = txtName.Text;
                    myNewCourse.PickedDate = calPickDate.SelectionRange.Start;
                    myNewCourse.CourseID = tblCoursesComboBox.Text;
                    if (HybridRB.Checked)
                    {
                        myNewCourse.CourseType = "Hybrid";
                    }
                    else
                    {
                        myNewCourse.CourseType = "Online";
                    }
                    
                    Form frmConfirm = new frmConfirmation();        // another form is displayed to show the values that were input (does not work).
                    frmConfirm.ShowDialog();
                    
                }
            }
            catch(Exception ex)             // exception is a catchAll
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }
        
        private bool IsValidData()      // validates the fields with my custom validation
        {
            return Valid.IsFilledOut(txtNumCourses) &&
                   Valid.IsInt32(txtNumCourses) &&
                   Valid.IsWithinRange(txtNumCourses, 0, 6) &&
                   Valid.IsFilledOut(txtName) &&
                   Valid.IsFutureDate(calPickDate);
        }

        private void btnGet_Click(object sender, EventArgs e) // supposed to retrieve the values from the class (does not work)
        {
            Courses storedCourse = new Courses();
            MessageBox.Show("Number of courses:" + storedCourse.NumCourses + "\n" +
                            "Your name:" + storedCourse.FullName);
        }
    }
}
