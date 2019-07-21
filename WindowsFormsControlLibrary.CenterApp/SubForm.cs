using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsControlLibrary.CenterApp
{
    public partial class SubForm : Form
    {
        Form opener;
        private SubForm thisWindow;
        private Helper helperC;

        private static int _xAxis = 0;
        private static int _yAxis = 0;

        public SubForm(FormWindow formWindow)
        {
            //formWindow = this;
            //this.formWindow = formWindow;
            InitializeComponent();
            opener = ParentForm;
            

            //this.ButtonAcceptChange.Click += new System.EventHandler(formWindow.ButtonCenter_Click);
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            //FormWindow.ArrowAdjust(true, 1);
            thisWindow = this;
            helperC = new Helper(thisWindow);
        }

        private void LabelInstruct_Click(object sender, EventArgs e)
        {

        }

        //closes the window; find a way to catch the X button
        private void ButtonDone_Click(object sender, EventArgs e)
        {
            //opener.Close(); idk why it's here but here it is
            this.Close();
        }

        #region Arrow button calls
        private void ButtonLeftArrow_Click(object sender, EventArgs e)
        {
            _xAxis--;
            helperC.AdjustText(false, true);
        }

        private void ButtonRightArrow_Click(object sender, EventArgs e)
        {
            _xAxis++;
            helperC.AdjustText(false, true);
        }

        private void ButtonUpArrow_Click(object sender, EventArgs e)
        {
            _yAxis++;
            helperC.AdjustText(false, false);
        }

        private void ButtonDownArrow_Click(object sender, EventArgs e)
        {
            _yAxis--;
            helperC.AdjustText(false, false);
        }
        #endregion

        #region getters and setters
        public string TextBoxUpArrow
        {
            get => textBoxUpArrow.Text;
            set { textBoxUpArrow.Text = value; }
        }
        public string TextBoxDownArrow
        {
            get => textBoxDownArrow.Text;
            set { textBoxDownArrow.Text = value; }
        }
        public string TextBoxLeftArrow
        {
            get => textBoxLeftArrow.Text;
            set { textBoxLeftArrow.Text = value; }
        }
        public string TextBoxRightArrow
        {
            get => textBoxRightArrow.Text;
            set { textBoxRightArrow.Text = value; }
        }

        public static int F2_xAxis { get { return _xAxis; } set { _xAxis = value; } }
        public static int F2_yAxis { get { return _yAxis; } set { _yAxis = value; } }
        #endregion

        private void ButtonAcceptChange_Click(object sender, EventArgs e)
        {
            
        }
    }
}
