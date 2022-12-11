namespace StudentsMarksApp
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.listBoxNumeralSurnamesMarks = new System.Windows.Forms.ListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelNameGroup = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelArithmeticMean = new System.Windows.Forms.Label();
            this.labelQualityOfKnowledge = new System.Windows.Forms.Label();
            this.labelAcademicPerformance = new System.Windows.Forms.Label();
            this.groupBoxChoiceSort = new System.Windows.Forms.GroupBox();
            this.radioButtonQualityOfKnowledge = new System.Windows.Forms.RadioButton();
            this.radioButtonnAcademicPerformance = new System.Windows.Forms.RadioButton();
            this.radioButtonSortAlphabet = new System.Windows.Forms.RadioButton();
            this.radioButtonSortMarks = new System.Windows.Forms.RadioButton();
            this.radioButtonSortNumeral = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxChoiceSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxNumeralSurnamesMarks
            // 
            this.listBoxNumeralSurnamesMarks.FormattingEnabled = true;
            this.listBoxNumeralSurnamesMarks.Location = new System.Drawing.Point(12, 12);
            this.listBoxNumeralSurnamesMarks.Name = "listBoxNumeralSurnamesMarks";
            this.listBoxNumeralSurnamesMarks.ScrollAlwaysVisible = true;
            this.listBoxNumeralSurnamesMarks.Size = new System.Drawing.Size(154, 316);
            this.listBoxNumeralSurnamesMarks.TabIndex = 1;
            this.listBoxNumeralSurnamesMarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Location = new System.Drawing.Point(370, 305);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(82, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.buttonExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            // 
            // labelNameGroup
            // 
            this.labelNameGroup.AutoSize = true;
            this.labelNameGroup.Location = new System.Drawing.Point(173, 12);
            this.labelNameGroup.Name = "labelNameGroup";
            this.labelNameGroup.Size = new System.Drawing.Size(81, 13);
            this.labelNameGroup.TabIndex = 24;
            this.labelNameGroup.Text = "Шифр группы: ";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(172, 31);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(126, 13);
            this.labelCount.TabIndex = 25;
            this.labelCount.Text = "Количество студентов: ";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(172, 53);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(58, 13);
            this.labelSubject.TabIndex = 26;
            this.labelSubject.Text = "Предмет: ";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp.Location = new System.Drawing.Point(342, 305);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(22, 23);
            this.buttonHelp.TabIndex = 27;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            this.buttonHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            // 
            // buttonSort
            // 
            this.buttonSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSort.Location = new System.Drawing.Point(172, 305);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(82, 23);
            this.buttonSort.TabIndex = 28;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            this.buttonSort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            // 
            // labelArithmeticMean
            // 
            this.labelArithmeticMean.AutoSize = true;
            this.labelArithmeticMean.Location = new System.Drawing.Point(172, 75);
            this.labelArithmeticMean.Name = "labelArithmeticMean";
            this.labelArithmeticMean.Size = new System.Drawing.Size(184, 13);
            this.labelArithmeticMean.TabIndex = 29;
            this.labelArithmeticMean.Text = "Средняя арифмитическая оценка: ";
            // 
            // labelQualityOfKnowledge
            // 
            this.labelQualityOfKnowledge.AutoSize = true;
            this.labelQualityOfKnowledge.Location = new System.Drawing.Point(172, 120);
            this.labelQualityOfKnowledge.Name = "labelQualityOfKnowledge";
            this.labelQualityOfKnowledge.Size = new System.Drawing.Size(99, 13);
            this.labelQualityOfKnowledge.TabIndex = 30;
            this.labelQualityOfKnowledge.Text = "Качество знаний: ";
            // 
            // labelAcademicPerformance
            // 
            this.labelAcademicPerformance.AutoSize = true;
            this.labelAcademicPerformance.Location = new System.Drawing.Point(172, 97);
            this.labelAcademicPerformance.Name = "labelAcademicPerformance";
            this.labelAcademicPerformance.Size = new System.Drawing.Size(88, 13);
            this.labelAcademicPerformance.TabIndex = 31;
            this.labelAcademicPerformance.Text = "Успеваемость: ";
            // 
            // groupBoxChoiceSort
            // 
            this.groupBoxChoiceSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxChoiceSort.Controls.Add(this.radioButtonQualityOfKnowledge);
            this.groupBoxChoiceSort.Controls.Add(this.radioButtonnAcademicPerformance);
            this.groupBoxChoiceSort.Controls.Add(this.radioButtonSortAlphabet);
            this.groupBoxChoiceSort.Controls.Add(this.radioButtonSortMarks);
            this.groupBoxChoiceSort.Controls.Add(this.radioButtonSortNumeral);
            this.groupBoxChoiceSort.Location = new System.Drawing.Point(172, 148);
            this.groupBoxChoiceSort.Name = "groupBoxChoiceSort";
            this.groupBoxChoiceSort.Size = new System.Drawing.Size(280, 151);
            this.groupBoxChoiceSort.TabIndex = 32;
            this.groupBoxChoiceSort.TabStop = false;
            this.groupBoxChoiceSort.Text = ", выберите сортировку по";
            // 
            // radioButtonQualityOfKnowledge
            // 
            this.radioButtonQualityOfKnowledge.AutoSize = true;
            this.radioButtonQualityOfKnowledge.Location = new System.Drawing.Point(6, 127);
            this.radioButtonQualityOfKnowledge.Name = "radioButtonQualityOfKnowledge";
            this.radioButtonQualityOfKnowledge.Size = new System.Drawing.Size(109, 17);
            this.radioButtonQualityOfKnowledge.TabIndex = 37;
            this.radioButtonQualityOfKnowledge.TabStop = true;
            this.radioButtonQualityOfKnowledge.Text = "качеству знаний";
            this.radioButtonQualityOfKnowledge.UseVisualStyleBackColor = true;
            // 
            // radioButtonnAcademicPerformance
            // 
            this.radioButtonnAcademicPerformance.AutoSize = true;
            this.radioButtonnAcademicPerformance.Location = new System.Drawing.Point(6, 104);
            this.radioButtonnAcademicPerformance.Name = "radioButtonnAcademicPerformance";
            this.radioButtonnAcademicPerformance.Size = new System.Drawing.Size(97, 17);
            this.radioButtonnAcademicPerformance.TabIndex = 36;
            this.radioButtonnAcademicPerformance.TabStop = true;
            this.radioButtonnAcademicPerformance.Text = "успеваемости";
            this.radioButtonnAcademicPerformance.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortAlphabet
            // 
            this.radioButtonSortAlphabet.AutoSize = true;
            this.radioButtonSortAlphabet.Checked = true;
            this.radioButtonSortAlphabet.Location = new System.Drawing.Point(6, 35);
            this.radioButtonSortAlphabet.Name = "radioButtonSortAlphabet";
            this.radioButtonSortAlphabet.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSortAlphabet.TabIndex = 33;
            this.radioButtonSortAlphabet.TabStop = true;
            this.radioButtonSortAlphabet.Text = "алфавиту";
            this.radioButtonSortAlphabet.UseVisualStyleBackColor = true;
            this.radioButtonSortAlphabet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            // 
            // radioButtonSortMarks
            // 
            this.radioButtonSortMarks.AutoSize = true;
            this.radioButtonSortMarks.Location = new System.Drawing.Point(6, 58);
            this.radioButtonSortMarks.Name = "radioButtonSortMarks";
            this.radioButtonSortMarks.Size = new System.Drawing.Size(69, 17);
            this.radioButtonSortMarks.TabIndex = 34;
            this.radioButtonSortMarks.Text = "оценкам";
            this.radioButtonSortMarks.UseVisualStyleBackColor = true;
            this.radioButtonSortMarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            // 
            // radioButtonSortNumeral
            // 
            this.radioButtonSortNumeral.AutoSize = true;
            this.radioButtonSortNumeral.Location = new System.Drawing.Point(6, 81);
            this.radioButtonSortNumeral.Name = "radioButtonSortNumeral";
            this.radioButtonSortNumeral.Size = new System.Drawing.Size(108, 17);
            this.radioButtonSortNumeral.TabIndex = 35;
            this.radioButtonSortNumeral.Text = "номеру журнала";
            this.radioButtonSortNumeral.UseVisualStyleBackColor = true;
            this.radioButtonSortNumeral.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(260, 305);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(76, 23);
            this.buttonSave.TabIndex = 33;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(464, 335);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxChoiceSort);
            this.Controls.Add(this.labelAcademicPerformance);
            this.Controls.Add(this.labelQualityOfKnowledge);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelArithmeticMean);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelNameGroup);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listBoxNumeralSurnamesMarks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            this.groupBoxChoiceSort.ResumeLayout(false);
            this.groupBoxChoiceSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNumeralSurnamesMarks;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Label labelNameGroup;
        public System.Windows.Forms.Label labelCount;
        public System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelArithmeticMean;
        private System.Windows.Forms.Label labelQualityOfKnowledge;
        private System.Windows.Forms.Label labelAcademicPerformance;
        private System.Windows.Forms.GroupBox groupBoxChoiceSort;
        private System.Windows.Forms.RadioButton radioButtonSortAlphabet;
        private System.Windows.Forms.RadioButton radioButtonSortMarks;
        private System.Windows.Forms.RadioButton radioButtonSortNumeral;
        private System.Windows.Forms.RadioButton radioButtonQualityOfKnowledge;
        private System.Windows.Forms.RadioButton radioButtonnAcademicPerformance;
        private System.Windows.Forms.Button buttonSave;
    }
}