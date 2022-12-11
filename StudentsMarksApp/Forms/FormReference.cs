using System;
using System.Windows.Forms;

namespace StudentsMarksApp.Forms
{
    public partial class FormReference : Form
    {
        public FormReference()
        {
            InitializeComponent();
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ButtonClose_Click(sender, e);
        }
    }
}
