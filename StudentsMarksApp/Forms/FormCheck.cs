using System;
using System.Windows.Forms;
using StudentsMarksApp.Forms;
using ClassLibrary;

namespace StudentsMarksApp
{
    public partial class FormCheck : Form
    {
        public FormCheck()
        {
            InitializeComponent();
            labelInfo.Text = User.Name + labelInfo.Text;
            labelSubject.Text += StudentsGroup.Subject;
            labelCount.Text += StudentsGroup.Count;
            labelNameGroup.Text += StudentsGroup.Name;
            listBoxSurnames.Items.AddRange(Students.Surnames); 
        }
        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            var formMarks = new FormMarks();
            formMarks.Show();
            this.Hide();
        }
        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[1];
            form.Show();
            this.Close();
        }
        private void KeyDown_FormCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonContinue_Click(sender, e);

            if (e.KeyCode == Keys.Escape)
                ButtonExit_Click(sender, e);
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            var formExit = new FormExit();
            formExit.ShowDialog();
        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            var formReference = new FormReference();
            formReference.ShowDialog();
        }
    }
}
