using ClassLibrary;
using StudentsMarksApp.Forms;
using System;
using System.Windows.Forms;

namespace StudentsMarksApp
{
    public partial class FormName : Form
    {
        private Button button1;
        private Button button2;
        private TextBox textBoxName;

        public FormName()
        {
            InitializeComponent();
        }
        private void OpenFormGroup()
        {
            var formGroup = new FormGroup();
            formGroup.Show();
            this.Hide();
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            FormExit formExitName = new FormExit();
            formExitName.ShowDialog();
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            new User(textBoxName.Text.Trim());
            if (User.Name != null)
                OpenFormGroup();
        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            var formReference = new FormReference();
            formReference.ShowDialog();
        }
        private void KeyDown_FormName(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonOK_Click(sender, e);
            if (e.KeyCode == Keys.Escape)
                ButtonExit_Click(sender, e);
        }
        private void FormName_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(226, 197);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormName
            // 
            this.ClientSize = new System.Drawing.Size(699, 414);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
