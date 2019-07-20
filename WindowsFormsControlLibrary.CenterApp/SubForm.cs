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
        private FormWindow formWindow;

        private static int _xAxis = 0;
        private static int _yAxis = 0;

        Method tempMethod = new Method();

        public SubForm()
        {

        }

        public SubForm(FormWindow formWindow)
        {
            this.formWindow = formWindow;
            InitializeComponent();
            opener = ParentForm;
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            //FormWindow.ArrowAdjust(true, 1);
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
        //left button iteration
        private void ButtonLeftArrow_Click(object sender, EventArgs e)
        {
            _xAxis--;
            tempMethod.AdjustText(false, true, _xAxis);
        }

        //right button iteration
        private void ButtonRightArrow_Click(object sender, EventArgs e)
        {
            _xAxis++;
            tempMethod.AdjustText(false, true, _xAxis);
        }

        //up button iteration
        private void ButtonUpArrow_Click(object sender, EventArgs e)
        {
            _yAxis++;
            tempMethod.AdjustText(false, false, _yAxis);
        }

        //down button iteration
        private void ButtonDownArrow_Click(object sender, EventArgs e)
        {
            _yAxis--;
            tempMethod.AdjustText(false, false, _yAxis);
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

        public static int F2_xAxis { get { return _xAxis; } private set { _xAxis = value; } }
        public static int F2_yAxis { get { return _yAxis; } set { _yAxis = value; } }
        #endregion


    }
}
