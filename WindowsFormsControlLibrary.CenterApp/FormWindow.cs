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
        //contains desktop res + centered res 
        //private int[,] _resArray = new int[2, 2];

        private static int _xAxis = 0;
        private static int _yAxis = 0;

        //To prevent the deletion of text everytime the text box is focused on after the first time 
        private bool firstDel = false;

        //to utilize the methods I make my own instance
        //Method tempMethod = new Method();
        Form thisWindow = Form;

        Helper helperC = new Helper(this.formWindow = )

        #region DLL Imports
        //find window
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        //move window
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        #endregion

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

        public static int F1_xAxis { get { return _xAxis; } set { _xAxis = value; } }
        public static int F1_yAxis { get { return _yAxis; } set { _yAxis = value; } }
        #endregion

        public FormWindow()
        {
            InitializeComponent();
            
        }

        //not sure if needed when dpi is considered
        //finds the center of a given double array
        //private int[,] CenterRes(int[,] z)
        //{
        //    for (int j = 0; j < 1; j++)
        //    {
        //        z[1, j] = z[0, j / 2];
        //    }
        //    return z;
        //}

        //buttons enact the code not main
        //public static void Main(String[] args)
        //{
        //}

        //When form loads this code runs 
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //note on the relations it seems to be deleting thme from the designer
            //establishes the event relation
            textBoxArrowLeft.KeyUp += TextBoxArrowLeft_KeyUp;
            //establishes the event relation
            textAppSelect.GotFocus += TextAppSelect_GotFocus;
        }

        private void TextBoxArrowLeft_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            // Determine whether the key entered
            if (e.KeyData == Keys.Enter)
            {
                //for debugging
                MessageBox.Show("Pressed enter.");

                
                if (tempMethod.CheckText(true, textBoxArrowLeft.Text))
                {
                    tempMethod.AdjustText(true, true, Int32.Parse(textBoxArrowLeft.Text));
                }
            }
        }

        //When the textAppSelect box is clicked on by user
        private void TextAppSelect_GotFocus(object sender, EventArgs e)
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

            if (hWnd != IntPtr.Zero) { MoveWindow(hWnd, 0 + SubForm.F2_xAxis, 0 + SubForm.F2_yAxis, 300 + _xAxis, 400 + _yAxis, true); }
            else { MessageBox.Show("Window not found"); }
        }

        #region Arrow button press calls
        //Adjust left
        private void ButtonArrowLeft_Click(object sender, EventArgs e)
        {
            _xAxis--;
            tempMethod.AdjustText(true, true, _xAxis);
        }

        //Adjust right
        private void ButtonArrowRight_Click(object sender, EventArgs e)
        {
            _xAxis++;
            tempMethod.AdjustText(true, true, _xAxis);
        }

        //Adjust up
        private void ButtonArrowUp_Click(object sender, EventArgs e)
        {
            _yAxis++;
            tempMethod.AdjustText(true, false, _yAxis);
        }

        //Adjust down
        private void ButtonArrowDown_Click(object sender, EventArgs e)
        {
            _yAxis--;
            tempMethod.AdjustText(true, false, _yAxis);
        }
        #endregion

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

        //clears appselect text box to make things quicker for user
        private void ButtonDelAppTB_Click(object sender, EventArgs e)
        {
            textAppSelect.Text = String.Empty;
        }
    }
}
