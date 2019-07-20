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
        //I need these to update the real ones
        private FormWindow tempF1 = new FormWindow();
        private SubForm tempF2 = new SubForm();

        //easy to reference blank than retyping "0"
        private const string blank = "0";

        //form 1 
        private static int _F1xAxis = FormWindow.F1_xAxis;
        private static int _F1yAxis = FormWindow.F1_yAxis;

        //form 2
        private static int _F2xAxis; // = SubForm.F2_xAxis;
        private static int _F2yAxis; // = SubForm.F2_yAxis;

        public Helper()
        {
            _F2xAxis = Int32.Parse(SubForm.textBoxLeftArrow.Text) + Int32.Parse(SubForm.textBoxRightArrow.Text);


        }

        //public static void Main(String[] args)
        //{
           
        //}

        /// <summary>
        /// Method both forms can call to avoid redundancy
        /// </summary>
        /// <param name="_form">true for FormWindow()main, false for SubForm</param>
        /// <param name="axis">true for X-Axis, false for Y-Axis</param>
        /// <param name="num">number needing placed</param>
        internal void AdjustText(bool _form, bool axis, int num)
        {
            if(_form) //FormWindow
            {
                if (axis)
                {
                    if (_F1xAxis >= 0)
                    {
                        tempF1.TextBoxArrowRight = _F1xAxis.ToString();
                        tempF1.TextBoxArrowLeft = blank;
                    }
                    else if (_F1xAxis <= 0)
                    {
                        tempF1.TextBoxArrowLeft = _F1xAxis.ToString();
                        tempF1.TextBoxArrowRight = blank;
                    }
                }
                else if (!axis)
                {
                    if (_F1yAxis >= 0)
                    {
                        tempF1.TextBoxArrowUp = _F1yAxis.ToString();
                        tempF1.TextBoxArrowDown = blank;
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
                        tempF2.TextBoxRightArrow = _F1yAxis.ToString();
                        tempF2.TextBoxLeftArrow = blank;
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
            if(neg && !checkMe.StartsWith("-")) { checkMe.Insert(0, "-"); }
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
