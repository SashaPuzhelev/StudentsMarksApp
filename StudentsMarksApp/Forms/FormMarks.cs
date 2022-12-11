using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;
using StudentsMarksApp.Forms;

namespace StudentsMarksApp
{
    public partial class FormMarks : Form
    {
        private int CountContinue;
        private bool CheckStrForInt(string str)
        {
            if (!int.TryParse(str, out _))
                return false;
            else
                return true;
        }
        private bool DublicateValidArray(int[] array, int valid)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == valid)
                    return false;
            return true;
        }
        private void OpenFormCheck()
        {
            var formCheck = new FormCheck();
            formCheck.Show();
            this.Close();
        }
        private void OpenFormMenu()
        {
            var formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }
        public FormMarks()
        {
            InitializeComponent();
            MaximizeBox = false;
            textBoxSurname.Text = Students.Surnames[0];
            textBoxNumeral.Text = $"1";
            Students.Marks = new char[StudentsGroup.Count];
            Students.Id  = new int[StudentsGroup.Count];
            using (var sr = new StreamReader("Marks.txt", Encoding.UTF8))
            {
                char c;
                while ((c = char.Parse(sr.ReadLine())) != ' ')
                    comboBoxMark.Items.Add(c);   
            }
        }
        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            if (CountContinue != 0)
            {
                CountContinue--;
                textBoxSurname.Clear();
                textBoxNumeral.Clear();

                textBoxNumeral.Text = Convert.ToString(Students.Id[CountContinue]);
                comboBoxMark.Text = Convert.ToString(Students.Marks[CountContinue]);
                textBoxSurname.Text = Students.Surnames[CountContinue];
                Students.Id[CountContinue] = 0;
            }
            else
                OpenFormCheck();
        }
        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            int errors = 0;
            if (!CheckStrForInt(textBoxNumeral.Text))
            {
                MessageBox.Show("Неверный формат нумерации!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors++;
            }
            if (string.IsNullOrWhiteSpace(comboBoxMark.Text))
            {
                MessageBox.Show("Вы не выбрали оценку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors++;
            }
            if (!DublicateValidArray(Students.Id, Convert.ToInt32(textBoxNumeral.Text)))
            {
                MessageBox.Show("Номер по журналу не должен повторяться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors++;
            }
            if (errors == 0)
            {
                Students.Marks[CountContinue] = Convert.ToChar(comboBoxMark.Text);
                Students.Id[CountContinue] = Convert.ToInt32(textBoxNumeral.Text);

                CountContinue++;
                if (CountContinue >= StudentsGroup.Count)
                    OpenFormMenu();
                else
                {
                    textBoxSurname.Clear();
                    textBoxNumeral.Clear();
                    comboBoxMark.SelectedIndex = -1;
                    textBoxSurname.Text = Students.Surnames[CountContinue];
                    textBoxNumeral.Text = Convert.ToString(CountContinue + 1);
                }
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            FormExit formExit = new FormExit();
            formExit.ShowDialog();
        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            var formReference = new FormReference();
            formReference.ShowDialog();
        }
        private void FormMarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonContinue_Click(sender, e);
            if (e.KeyCode == Keys.Escape)
                ButtonExit_Click(sender, e);
        }
    }
}
