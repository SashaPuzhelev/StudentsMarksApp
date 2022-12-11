using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using ClassLibrary;
using StudentsMarksApp.Forms;

namespace StudentsMarksApp
{
    public partial class FormGroup : Form
    {
        public FormGroup()
        {
            InitializeComponent();
            MaximizeBox = false;
            labelInfo.Text = User.Name + labelInfo.Text;
            using (var sr = new StreamReader("File.txt", Encoding.UTF8))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                    comboBoxSubjects.Items.Add(str);
            } 
        }
        void SortAlphabet(string[] str)
        {
            string temp;
            for (int i = 0; i < str.Length; i++)
                for (int j = i + 1; j < str.Length; j++)
                    if (str[i].CompareTo(str[j]) > 0)
                    {
                        temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
                FormExit formExitGroup = new FormExit();
                formExitGroup.ShowDialog();
        }
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            textBoxNameFile.Text = openFileDialog.FileName;
            textBoxSurnames.Clear();

            if (textBoxNameFile.Text.Length != 0)
                textBoxSurnames.Text = File.ReadAllText(textBoxNameFile.Text, Encoding.UTF8);
        }
        private void OpenFormCheck()
        {
            var formCheck = new FormCheck();
            formCheck.Show();
            this.Hide();
        }
        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            int errors = 0;
            if (textBoxSurnames.Lines.Length < 1)
            {
                MessageBox.Show("Вы не ввели фамилий!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors++;
            }
            if (string.IsNullOrWhiteSpace(comboBoxSubjects.Text))
            {
                MessageBox.Show("Вы не выбрали предмет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors++;
            }
            if (string.IsNullOrWhiteSpace(textBoxNameGroup.Text))
            {
                MessageBox.Show("Вы не ввели шифр группы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors++;
            }
            for (int i = 0; i < textBoxSurnames.Lines.Length; i++)
                if (!CheckValidCharForLetters(textBoxSurnames.Lines[i]))
                {
                    MessageBox.Show("Фамилии должны состоять только из букв!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errors++;
                    break;
                }
            if (errors == 0)
            {
                List<string> listSurnames = new List<string>();
                for (int i = 0; i < textBoxSurnames.Lines.Length; i++)
                    if (!string.IsNullOrWhiteSpace(textBoxSurnames.Lines[i]))
                        listSurnames.Add(textBoxSurnames.Lines[i].Trim());

                Students.Surnames = listSurnames.ToArray();

                if (checkBoxSortAlphabet.Checked == true)
                    SortAlphabet(Students.Surnames);

                StudentsGroup.Subject = comboBoxSubjects.Text;
                StudentsGroup.Count = listSurnames.Count;
                StudentsGroup.Name = textBoxNameGroup.Text;
                OpenFormCheck();
            }
        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            var formReference = new FormReference();
            formReference.ShowDialog();
        }
        private void KeyDown_FormGroup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonContinue_Click(sender, e);
            if (e.KeyCode == Keys.Escape)
                ButtonExit_Click(sender, e);
        }
        private bool CheckValidCharForLetters(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (!Char.IsLetter(str, i))
                    if (Char.IsWhiteSpace(str, i))
                        continue;
                    else
                        return false;
            return true;
        }
        private void FormGroup_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
