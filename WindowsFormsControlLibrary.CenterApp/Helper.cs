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
        private SubForm _subForm;
        private FormWindow _formWindow;

        private const string blank = "0";

        private static int _F1xAxis; // = FormWindow.F1_xAxis;
        private static int _F1yAxis; // = FormWindow.F1_yAxis;
        private static int _F2xAxis; // = SubForm.F2_xAxis;
        private static int _F2yAxis; // = SubForm.F2_yAxis;


        public Helper(SubForm form)
        {
            _subForm = form;
        }

        public Helper(FormWindow formWindow)
        {
            this._formWindow = formWindow;
        }

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
        /// <param name="isFormWindow">true for FormWindow, false for SubForm</param>
        /// <param name="isxAxis">true for X-Axis, false for Y-Axis</param>
        /// <param name="number">number needing placed</param>
        internal void AdjustText(bool isFormWindow, bool isxAxis)
        {
            UpdateFields();

            if (isFormWindow) //FormWindow
            {
                if (isxAxis)
                {
                    if (_F1xAxis >= 0)
                    {
                        _formWindow.TextBoxArrowRight = _F1xAxis.ToString();
                        _formWindow.TextBoxArrowLeft = blank;
                    }
                    else if (_F1xAxis < 0)
                    {
                        _formWindow.TextBoxArrowLeft = _F1xAxis.ToString();
                    }
                }
                else if (!isxAxis)
                {
                    if (_F1yAxis >= 0)
                    {
                        _formWindow.TextBoxArrowUp = _F1yAxis.ToString();
                        _formWindow.TextBoxArrowDown = blank;
                    }
                    else if (_F1yAxis < 0)
                    {
                        _formWindow.TextBoxArrowDown = _F1yAxis.ToString();
                    }
                }
            }
            else //SubForm
            {
                if (isxAxis)
                {
                    if (_F2xAxis >= 0)
                    {
                        _subForm.TextBoxRightArrow = _F2xAxis.ToString();
                        _subForm.TextBoxLeftArrow = blank;
                    }
                    else if (_F2xAxis < 0)
                    {
                        _subForm.TextBoxLeftArrow = _F2xAxis.ToString();
                    }
                }
                else if (!isxAxis)
                {
                    if (_F2yAxis >= 0)
                    {
                        _subForm.TextBoxUpArrow = _F2yAxis.ToString();
                        _subForm.TextBoxDownArrow = blank;
                    }
                    else if (_F2yAxis < 0)
                    {
                        _subForm.TextBoxDownArrow = _F2yAxis.ToString();
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
