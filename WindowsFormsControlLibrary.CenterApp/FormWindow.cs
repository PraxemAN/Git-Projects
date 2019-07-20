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
        private static int _xAxis = 0;
        private static int _yAxis = 0;

        private static bool firstDel = false;

        //to utilize the methods I make my own instance
        //Method tempMethod = new Method();
        FormWindow thisWindow;

        Helper helperC;

        #region DLL Imports
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        //[DllImport("user32.dll", SetLastError = false)]
        //private static extern IntPtr GetDesktopWindow();
        #endregion

        #region getters and setters
        //getters and setters for textboxs
        public string TextBoxArrowRight
        {
            get => textBoxArrowRight.Text;
            internal set { textBoxArrowRight.Text = value; }
        }
        public string TextBoxArrowLeft
        {
            get => textBoxArrowLeft.Text;
            internal set { textBoxArrowLeft.Text = value; }
        }
        public string TextBoxArrowUp
        {
            get => textBoxArrowUp.Text;
            internal set { textBoxArrowUp.Text = value; }
        }
        public string TextBoxArrowDown
        {
            get => textBoxArrowDown.Text;
            internal set { textBoxArrowDown.Text = value; }
        }

        public static int F1_xAxis { get { return _xAxis; } set { _xAxis = value; } }
        public static int F1_yAxis { get { return _yAxis; } set { _yAxis = value; } }
        #endregion

        public FormWindow()
        {
            InitializeComponent();
            thisWindow = this;
            helperC = new Helper(thisWindow);
        }

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

                if (helperC.CheckText(true, textBoxArrowLeft.Text))
                {
                    helperC.AdjustText(true, true);
                }
            }
        }

        private void TextAppSelect_GotFocus(object sender, EventArgs e)
        {
            if (!firstDel) { textAppSelect.Clear(); firstDel = true; }
        }

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
            helperC.AdjustText(true, true);
        }

        //Adjust right
        private void ButtonArrowRight_Click(object sender, EventArgs e)
        {
            _xAxis++;
            helperC.AdjustText(true, true);
        }

        //Adjust up
        private void ButtonArrowUp_Click(object sender, EventArgs e)
        {
            _yAxis++;
            helperC.AdjustText(true, false);
        }

        //Adjust down
        private void ButtonArrowDown_Click(object sender, EventArgs e)
        {
            _yAxis--;
            helperC.AdjustText(true, false);
        }
        #endregion

        private void CornerAdjustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForm subForm = new SubForm(this);
            subForm.Show();
        }

        //clears appselect text box to make things quicker for user
        private void ButtonDelAppTB_Click(object sender, EventArgs e)
        {
            textAppSelect.Text = String.Empty;
        }
    }
}
