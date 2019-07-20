using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary.CenterApp
{
    class Helper
    {
        private Form _form;


        //private FormWindow tempF1 = new FormWindow();
        //private SubForm tempF2 = new SubForm();

        private const string blank = "0";

        private static int _F1xAxis; // = FormWindow.F1_xAxis;
        private static int _F1yAxis; // = FormWindow.F1_yAxis;
        private static int _F2xAxis; // = SubForm.F2_xAxis;
        private static int _F2yAxis; // = SubForm.F2_yAxis;

        private FormWindow formWindow;

        public Helper()
        {

        }

        public Helper(Form form)
        {
            _form = form;

            //_F2xAxis = Int32.Parse(SubForm.textBoxLeftArrow.Text) + Int32.Parse(SubForm.textBoxRightArrow.Text);
        }

        public Helper(FormWindow formWindow)
        {
            this.formWindow = formWindow;
        }

        //public static void Main(String[] args)
        //{

        //}

        private void UpdateFields()
        {
            _F1xAxis = FormWindow.F1_xAxis;
            _F1yAxis = FormWindow.F1_yAxis;
            _F2xAxis = SubForm.F2_xAxis;
            _F2yAxis = SubForm.F2_yAxis;
        }

        /// <summary>
        /// Method both forms can call to avoid redundancy
        /// </summary>
        /// <param name="_form">true for FormWindow, false for SubForm</param>
        /// <param name="axis">true for X-Axis, false for Y-Axis</param>
        /// <param name="number">number needing placed</param>
        internal void AdjustText(bool _form, bool axis)
        {
            UpdateFields();

            if (_form) //FormWindow
            {
                if (axis)
                {
                    if (_F1xAxis >= 0)
                    {
                        formWindow.TextBoxArrowRight = _F1xAxis.ToString();
                        formWindow.TextBoxArrowLeft = blank;
                    }
                    else if (_F1xAxis <= 0)
                    {
                        formWindow.TextBoxArrowLeft = _F1xAxis.ToString();
                        formWindow.TextBoxArrowRight = blank;
                    }
                }
                else if (!axis)
                {
                    if (_F1yAxis >= 0)
                    {
                        _form tempF1.TextBoxArrowDown = blank;
                    }
                    else if (_F1yAxis <= 0)
                    {
                        tempF1.TextBoxArrowDown = _F1yAxis.ToString();
                        tempF1.TextBoxArrowUp = blank;
                    }
                }
            }
            else //SubForm
            {
                if (axis)
                {
                    if (_F2xAxis >= 0)
                    {
                        formWindow.TextBoxRightArrow = _F1yAxis.ToString();
                        formWindow.TextBoxLeftArrow = blank;
                    }
                    else if (_F2xAxis <= 0)
                    {
                        tempF2.TextBoxLeftArrow = _F1yAxis.ToString();
                        tempF2.TextBoxRightArrow = blank;
                    }
                }
                else if (!axis)
                {
                    if (_F2yAxis >= 0)
                    {
                        tempF2.TextBoxUpArrow = _F1yAxis.ToString();
                        tempF2.TextBoxDownArrow = blank;
                    }
                    else if (_F2yAxis <= 0)
                    {
                        tempF2.TextBoxDownArrow = _F1yAxis.ToString();
                        tempF2.TextBoxUpArrow = blank;
                    }
                }
            }
        }//End of AdjustText


        /// <summary>
        /// Checks to see if the given string is an int
        /// </summary>
        /// <param name="neg">true if the number is negative</param>
        /// <param name="axis">true(_F2xAxis) false(_F2yAxis)</param>
        /// <param name="checkMe">changed textbox text</param>
        /// <returns></returns>
        public bool CheckText(bool neg, string checkMe)
        {
            if (neg && !checkMe.StartsWith("-")) { checkMe.Insert(0, "-"); }
            foreach (char element in checkMe)
            {
                if (element == 45) { continue; }
                if (!(element >= 48 && element <= 57))
                {
                    MessageBox.Show("Not a valid number");
                    return false;
                }
            }
            return true;
        }//end CheckText

    }
}
