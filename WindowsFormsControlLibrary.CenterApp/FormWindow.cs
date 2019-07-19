using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsControlLibrary.CenterApp
{
    public partial class FormWindow : UserControl
    {
        public FormWindow()
        {
            InitializeComponent();
        }

        //contains desktop res + centered res 
        private int[,] resArray = new int[2,2];

        private static int xAxis = 0;
        public static int F1_xAxis { get { return xAxis; } set { xAxis = value; } }
        private static int yAxis = 0;
        public static int F1_yAxis { get { return yAxis; } set { yAxis = value; } }

        
        private bool firstDel = false;

        //Subform x and y move
        public int _xAxis = 0;
        public int _yAxis = 0;

        //not sure if needed anymore
        //private string windowName;

        #region DLL Imports
        //find window
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        //move window
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        #endregion

        //finds the center of a given double array
        private int[,] centerRes(int[,] z)
        {
                for (int j = 0; j < 1; j++)
                {
                    z[1, j] = z[0, j / 2];
                }
            return z;
        }

        //buttons enact the code not main
        public static void main(String[] args)
        {
        }

        //When form loads this code runs 
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //note on the relations it seems to be deleting thme from the designer

            //establishes the event relation
            textBoxArrowLeft.KeyUp += textBoxArrowLeft_KeyUp;
            //establishes the event relation
            textAppSelect.GotFocus += textAppSelect_GotFocus;

        }

        private void textBoxArrowLeft_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            // Determine whether the key entered
            if (e.KeyData == Keys.Enter)
            {
                MessageBox.Show("Pressed enter.");
                CheckText(true, textBoxArrowLeft.Text);
            }
        }

        //When the textAppSelect box is clicked on by user
        private void textAppSelect_GotFocus(object sender, EventArgs e)
        {
            if (!firstDel) { textAppSelect.Clear(); firstDel = true; } //clear the text.
        }

        private void LabelExplanation_Click(object sender, EventArgs e)
        {

        }

        //Hitting the center button Do most of everything here
        private void ButtonCenter_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = FindWindow(null, textAppSelect.Text);

            if (hWnd != IntPtr.Zero) { MoveWindow(hWnd, 0, 0, 300 + xAxis, 400 + yAxis, true); }
            else { MessageBox.Show("Window not found"); }
        }

        //Adjust right
        private void ButtonArrowRight_Click(object sender, EventArgs e)
        {
            xAxis++;
            //Method.AdjustText(true, true, F1_xAxis);
        }

        //Adjust up
        private void ButtonArrowUp_Click(object sender, EventArgs e)
        {
            yAxis++;
            //ArrowAdjust(false, yAxis);
        }

        //Adjust left
        private void ButtonArrowLeft_Click(object sender, EventArgs e)
        {
            xAxis--;
            //ArrowAdjust(true, xAxis);
        }

        //Adjust down
        private void ButtonArrowDown_Click(object sender, EventArgs e)
        {
            yAxis--;
            //ArrowAdjust(false, yAxis);
        }

        //If user enters number in box
        private void TextBoxArrowLeft_TextChanged(object sender, EventArgs e)
        {
            //CheckText(true, textBoxArrowLeft.Text);
        }

        //Checks to see if the given string is an int
        //axis = true(xAxis) false(yAxis); checkMe = changed textbox text
        public void CheckText(bool axis, string checkMe)
        {
            foreach (char element in checkMe)
            {
                if (element == 45) { continue; }
                if (!(element >= 48 && element <= 57))
                {
                    textBoxArrowLeft.Text = "Not a valid number";
                    return;
                }
            }

            //if (axis) { xAxis = Int32.Parse(checkMe); ArrowAdjust(true, xAxis); }
            //if (!axis) { yAxis = Int32.Parse(checkMe); ArrowAdjust(false, yAxis); }
        }

     

        //drop down menu adjust; Trying to get the other form to show; no code written on new form until this bears fruit
        private void CornerAdjustToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SubForm subForm = new SubForm(this);
            subForm.Show();
            //SubForm nForm = new SubForm
            //{
            //    TopLevel = false
            //};
            //nForm.Show();
            ////nForm.ShowDialog();
            //this.Hide();
        }


        //obsolete by gotfocus
        private void textAppSelect_TextChanged(object sender, EventArgs e) {}

        //whoops
        private void TextBoxArrowRight_TextChanged(object sender, EventArgs e){}

        //clears appselect text box to make things quicker for user
        private void ButtonDelAppTB_Click(object sender, EventArgs e)
        {
            textAppSelect.Text = String.Empty;
        }

        #region getters and setters
        //getters and setters for textboxs
        public string TextBoxArrowRight
        {
            get => textBoxArrowRight.Text;
            set { textBoxArrowRight.Text = value; }
        }
        public string TextBoxArrowLeft
        {
            get => textBoxArrowLeft.Text;
            set { textBoxArrowLeft.Text = value; }
        }
        public string TextBoxArrowUp
        {
            get => textBoxArrowUp.Text;
            set { textBoxArrowUp.Text = value; }
        }
        public string TextBoxArrowDown
        {
            get => textBoxArrowDown.Text;
            set { textBoxArrowDown.Text = value; }
        }
        #endregion
    }
}
