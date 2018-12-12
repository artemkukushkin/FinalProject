using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Final_Kukushkin
{
    public static class Valid // created a class similar to the Validator class in the book. Made some modifications, especially in IsFutureDate code.
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public static bool IsFilledOut(TextBox textBox) //Looks for empty fields
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsInt32(TextBox textBox) // makes sure values are integers
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a whole number.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(TextBox textBox, int min, int max) // allows me to specify a valid range
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show("You must take at least 1 class, but no more than "
                     + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsFutureDate(MonthCalendar monthCalendar) // only finds future dates to be valid
        {
            if (monthCalendar.SelectionRange.Start < DateTime.Today.Date)
            {
                MessageBox.Show("The set date has to be in the future", Title);
                monthCalendar.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
     }
}
