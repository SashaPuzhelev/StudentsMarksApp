using System;
using System.Windows.Forms;


namespace StudentsMarksApp
{
    public partial class FormExit : Form
    {
        public FormExit()
        {
            InitializeComponent();
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ButtonNoClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ButtonNoClose_Click(sender, e);
        }
    }
}
