using System;
using System.Windows.Forms;

namespace Version_3_C
{
    public partial class InputBox : Form
    {
        private string _Answer;

        public InputBox(string question)
        {
            InitializeComponent();
            lblQuestion.Text = question;
            lblError.Text = "";
            txtAnswer.Focus();
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _Answer = txtAnswer.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string Answer
        {
            get { return _Answer; }
            //set { mAnswer = value; }
        }
    }
}