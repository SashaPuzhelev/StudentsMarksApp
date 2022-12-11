using ClassLibrary;
using StudentsMarksApp.Forms;
using System;
using System.Windows.Forms;
using System.IO;

namespace StudentsMarksApp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            for (int i = 0; i < StudentsGroup.Count; i++)
                listBoxNumeralSurnamesMarks.Items.Add($" {Students.Id[i]}. {Students.Surnames[i]} - {Students.Marks[i]}");

            labelCount.Text += StudentsGroup.Count;
            labelNameGroup.Text += StudentsGroup.Name;
            labelSubject.Text += StudentsGroup.Subject;
            groupBoxChoiceSort.Text = User.Name + groupBoxChoiceSort.Text;
            labelArithmeticMean.Text += ManipulationsWithMarks.CalculationArithmeticMeanOfCharArray(Students.Marks).ToString("0.00");
            labelAcademicPerformance.Text += $"{ManipulationsWithMarks.CalculationAcademicPerformance()} %";
            labelQualityOfKnowledge.Text += $"{ManipulationsWithMarks.CalculationQualityOfKnowledge()} %";
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            var formExit = new FormExit();
            formExit.ShowDialog();
        }
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            listBoxNumeralSurnamesMarks.Items.Clear();

            if (radioButtonSortAlphabet.Checked == true)
                SortStudents.SortAlphabet(0, Students.Surnames.Length);

            if (radioButtonSortMarks.Checked == true)
                SortStudents.SortMarksAlphavet();

            if (radioButtonSortNumeral.Checked == true)
                SortStudents.SortId();

            if (radioButtonnAcademicPerformance.Checked == true)
            {
                SortStudents.SortMarksAlphavet();
                for (int i = 0; i < StudentsGroup.Count; i++)
                    if (Students.Marks[i] == '2')
                        listBoxNumeralSurnamesMarks.Items.Add($" {Students.Id[i]}. {Students.Surnames[i]} - {Students.Marks[i]}");
                return;
            }
            if (radioButtonQualityOfKnowledge.Checked == true)
            {
                SortStudents.SortMarksAlphavet();
                for (int i = 0; i < StudentsGroup.Count; i++)
                    if (Students.Marks[i] == '3' || Students.Marks[i] == '2')
                    listBoxNumeralSurnamesMarks.Items.Add($" {Students.Id[i]}. {Students.Surnames[i]} - {Students.Marks[i]}");
                return;
            }
            for (int i = 0; i < StudentsGroup.Count; i++)
                listBoxNumeralSurnamesMarks.Items.Add($" {Students.Id[i]}. {Students.Surnames[i]} - {Students.Marks[i]}");
        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            var formReference = new FormReference();
            formReference.ShowDialog();
        }
        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonSort_Click(sender, e);
            if (e.KeyCode == Keys.Escape)
                ButtonExit_Click(sender, e);
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*)";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(labelNameGroup.Text);
                streamWriter.WriteLine(labelCount.Text);
                streamWriter.WriteLine(labelSubject.Text);
                streamWriter.WriteLine(labelArithmeticMean.Text);
                streamWriter.WriteLine(labelAcademicPerformance.Text);
                streamWriter.WriteLine(labelQualityOfKnowledge.Text);
                streamWriter.WriteLine("Список:");
                for (int i = 0; i < listBoxNumeralSurnamesMarks.Items.Count; i++)
                {
                    streamWriter.WriteLine(listBoxNumeralSurnamesMarks.Items[i]);
                }
                streamWriter.Close();
            }
                
        }
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
