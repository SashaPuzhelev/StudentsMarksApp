namespace StudentsMarksApp
{
    partial class FormGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroup));
            this.textBoxSurnames = new System.Windows.Forms.TextBox();
            this.labelinfoStudents = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxNameFile = new System.Windows.Forms.TextBox();
            this.labelNameGroup = new System.Windows.Forms.Label();
            this.textBoxNameGroup = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.checkBoxSortAlphabet = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxSurnames
            // 
            this.textBoxSurnames.Location = new System.Drawing.Point(332, 27);
            this.textBoxSurnames.MaxLength = 2000;
            this.textBoxSurnames.Multiline = true;
            this.textBoxSurnames.Name = "textBoxSurnames";
            this.textBoxSurnames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSurnames.Size = new System.Drawing.Size(130, 270);
            this.textBoxSurnames.TabIndex = 19;
            // 
            // labelinfoStudents
            // 
            this.labelinfoStudents.AutoSize = true;
            this.labelinfoStudents.Location = new System.Drawing.Point(329, 11);
            this.labelinfoStudents.Name = "labelinfoStudents";
            this.labelinfoStudents.Size = new System.Drawing.Size(58, 13);
            this.labelinfoStudents.TabIndex = 20;
            this.labelinfoStudents.Text = "Студенты:";
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelInfo.Location = new System.Drawing.Point(15, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(311, 55);
            this.labelInfo.TabIndex = 21;
            this.labelInfo.Text = ", введите фамилии студентов или откройте файл с фамилиями";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(236, 58);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(90, 21);
            this.buttonOpen.TabIndex = 22;
            this.buttonOpen.Text = "Открыть файл";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            this.buttonOpen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormGroup);
            // 
            // textBoxNameFile
            // 
            this.textBoxNameFile.Location = new System.Drawing.Point(15, 58);
            this.textBoxNameFile.Name = "textBoxNameFile";
            this.textBoxNameFile.ReadOnly = true;
            this.textBoxNameFile.Size = new System.Drawing.Size(218, 20);
            this.textBoxNameFile.TabIndex = 23;
            this.textBoxNameFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormGroup);
            // 
            // labelNameGroup
            // 
            this.labelNameGroup.AutoSize = true;
            this.labelNameGroup.Location = new System.Drawing.Point(12, 110);
            this.labelNameGroup.Name = "labelNameGroup";
            this.labelNameGroup.Size = new System.Drawing.Size(75, 13);
            this.labelNameGroup.TabIndex = 24;
            this.labelNameGroup.Text = "Шифр группы";
            // 
            // textBoxNameGroup
            // 
            this.textBoxNameGroup.Location = new System.Drawing.Point(143, 103);
            this.textBoxNameGroup.MaxLength = 20;
            this.textBoxNameGroup.Name = "textBoxNameGroup";
            this.textBoxNameGroup.Size = new System.Drawing.Size(183, 20);
            this.textBoxNameGroup.TabIndex = 25;
            this.textBoxNameGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormGroup);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(12, 142);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(52, 13);
            this.labelSubject.TabIndex = 28;
            this.labelSubject.Text = "Предмет";
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Location = new System.Drawing.Point(223, 274);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.buttonExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormGroup);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContinue.Location = new System.Drawing.Point(15, 276);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(86, 23);
            this.buttonContinue.TabIndex = 31;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            this.buttonContinue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormGroup);
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(140, 139);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(186, 21);
            this.comboBoxSubjects.TabIndex = 32;
            this.comboBoxSubjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormGroup);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp.Location = new System.Drawing.Point(304, 274);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(22, 23);
            this.buttonHelp.TabIndex = 35;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            this.buttonHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormGroup);
            // 
            // checkBoxSortAlphabet
            // 
            this.checkBoxSortAlphabet.AutoSize = true;
            this.checkBoxSortAlphabet.Location = new System.Drawing.Point(169, 228);
            this.checkBoxSortAlphabet.Name = "checkBoxSortAlphabet";
            this.checkBoxSortAlphabet.Size = new System.Drawing.Size(157, 17);
            this.checkBoxSortAlphabet.TabIndex = 37;
            this.checkBoxSortAlphabet.Text = "Сортировать по алфавиту";
            this.checkBoxSortAlphabet.UseVisualStyleBackColor = true;
            this.checkBoxSortAlphabet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormGroup);
            // 
            // FormGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(474, 311);
            this.Controls.Add(this.checkBoxSortAlphabet);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.textBoxNameGroup);
            this.Controls.Add(this.labelNameGroup);
            this.Controls.Add(this.textBoxNameFile);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelinfoStudents);
            this.Controls.Add(this.textBoxSurnames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGroup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxSurnames;
        private System.Windows.Forms.Label labelinfoStudents;
        public System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBoxNameFile;
        private System.Windows.Forms.Label labelNameGroup;
        private System.Windows.Forms.TextBox textBoxNameGroup;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.CheckBox checkBoxSortAlphabet;
    }
}