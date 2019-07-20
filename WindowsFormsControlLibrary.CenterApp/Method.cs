using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary.CenterApp
{
    class Method
    {
        //I need these to update the real ones
        private FormWindow tempF1 = new FormWindow();
        private SubForm tempF2 = new SubForm();

        //easy to reference blank than retyping "0"
        private const string blank = "0";

        //form 1 
        private static int xAxis = FormWindow.F1_xAxis;
        private static int yAxis = FormWindow.F1_yAxis;

        //form 2
        private static int _xAxis = SubForm.F2_xAxis;
        private static int _yAxis = SubForm.F2_yAxis;

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
                    if (xAxis >= 0)
                    {
                        tempF1.TextBoxArrowRight = xAxis.ToString();
                        tempF1.TextBoxArrowLeft = blank;
                    }
                    else if (xAxis <= 0)
                    {
                        tempF1.TextBoxArrowLeft = xAxis.ToString();
                        tempF1.TextBoxArrowRight = blank;
                    }
                }
                else if (!axis)
                {
                    if (yAxis >= 0)
                    {
                        tempF1.TextBoxArrowUp = yAxis.ToString();
                        tempF1.TextBoxArrowDown = blank;
                    }
                    else if (yAxis <= 0)
                    {
                        tempF1.TextBoxArrowDown = yAxis.ToString();
                        tempF1.TextBoxArrowUp = blank;
                    }
                }
            }
            else //SubForm
            {
                if (axis)
                {
                    if (_xAxis >= 0)
                    {
                        tempF2.TextBoxRightArrow = yAxis.ToString();
                        tempF2.TextBoxLeftArrow = blank;
                    }
                    else if (_xAxis <= 0)
                    {
                        tempF2.TextBoxLeftArrow = yAxis.ToString();
                        tempF2.TextBoxRightArrow = blank;
                    }
                }
                else if (!axis)
                {
                    if (_yAxis >= 0)
                    {
                        tempF2.TextBoxUpArrow = yAxis.ToString();
                        tempF2.TextBoxDownArrow = blank;
                    }
                    else if (_yAxis <= 0)
                    {
                        tempF2.TextBoxDownArrow = yAxis.ToString();
                        tempF2.TextBoxUpArrow = blank;
                    }
                }
            }
        }//End of AdjustText


        /// <summary>
        /// Checks to see if the given string is an int
        /// </summary>
        /// <param name="neg">true if the number is negative</param>
        /// <param name="axis">true(_xAxis) false(_yAxis)</param>
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
