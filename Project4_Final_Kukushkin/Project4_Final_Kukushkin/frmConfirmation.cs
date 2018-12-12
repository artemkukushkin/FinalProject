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
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
      
        }

        private void frmConfirmation_Load(object sender, EventArgs e) // 21-28 was supposed to load the second forms 
                                                                      // textboxes with the information from Courses class. Stopped short, because I could've find a solution.
                                                                      // this code still produces blank textboxes
                                                                      // I assume it has to do with creation of new instance of my custom class, but not sure.
        {
            Courses myCourse = new Courses();
            this.txtConfNumCourses.Text = Convert.ToString(myCourse.NumCourses);
            this.txtConfName.Text = myCourse.FullName;
            
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
