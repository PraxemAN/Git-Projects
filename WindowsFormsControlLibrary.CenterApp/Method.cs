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
        private static FormWindow tempF1 = new FormWindow();
        private static SubForm tempF2 = new SubForm();

        private const string blank = "0";

        //form 1 
        private static int xAxis = FormWindow.F1_xAxis;
        private static int yAxis = FormWindow.F1_yAxis;

        //form 2
        private static int _xAxis = SubForm.F2_xAxis;
        private static int _yAxis = SubForm.F2_yAxis;

        public static void main(String[] args)
        {
           
        }

        /// <summary>
        /// Method both forms can call to avoid redundancy
        /// </summary>
        /// <param name="_form">true for FormWindow()main, false for SubForm</param>
        /// <param name="axis">true for X-Axis, false for Y-Axis</param>
        /// <param name="num">number needing placed</param>
        public static void AdjustText(bool _form, bool axis, int num)
        {
            if(_form)
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
            else //form 2 
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
        }
    }
}
