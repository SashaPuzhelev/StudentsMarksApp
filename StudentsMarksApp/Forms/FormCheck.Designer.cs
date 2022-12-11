namespace StudentsMarksApp
{
    partial class FormCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheck));
            this.listBoxSurnames = new System.Windows.Forms.ListBox();
            this.labelinfoStudents = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelNameGroup = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSurnames
            // 
            this.listBoxSurnames.FormattingEnabled = true;
            this.listBoxSurnames.Location = new System.Drawing.Point(238, 28);
            this.listBoxSurnames.Name = "listBoxSurnames";
            this.listBoxSurnames.ScrollAlwaysVisible = true;
            this.listBoxSurnames.Size = new System.Drawing.Size(129, 277);
            this.listBoxSurnames.TabIndex = 1;
            this.listBoxSurnames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormCheck);
            // 
            // labelinfoStudents
            // 
            this.labelinfoStudents.AutoSize = true;
            this.labelinfoStudents.Location = new System.Drawing.Point(235, 9);
            this.labelinfoStudents.Name = "labelinfoStudents";
            this.labelinfoStudents.Size = new System.Drawing.Size(58, 13);
            this.labelinfoStudents.TabIndex = 21;
            this.labelinfoStudents.Text = "Студенты:";
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelInfo.Location = new System.Drawing.Point(15, 11);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(214, 65);
            this.labelInfo.TabIndex = 22;
            this.labelInfo.Text = ", проверьте, верно ли введены данные";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNameGroup
            // 
            this.labelNameGroup.AutoSize = true;
            this.labelNameGroup.Location = new System.Drawing.Point(12, 74);
            this.labelNameGroup.Name = "labelNameGroup";
            this.labelNameGroup.Size = new System.Drawing.Size(81, 13);
            this.labelNameGroup.TabIndex = 23;
            this.labelNameGroup.Text = "Шифр группы: ";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 116);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(126, 13);
            this.labelCount.TabIndex = 24;
            this.labelCount.Text = "Количество студентов: ";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(12, 157);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(58, 13);
            this.labelSubject.TabIndex = 25;
            this.labelSubject.Text = "Предмет: ";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturn.Location = new System.Drawing.Point(146, 282);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(58, 23);
            this.buttonReturn.TabIndex = 26;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            this.buttonReturn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormCheck);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContinue.Location = new System.Drawing.Point(15, 282);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(67, 23);
            this.buttonContinue.TabIndex = 27;
            this.buttonContinue.Text = "Далее";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            this.buttonContinue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormCheck);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp.Location = new System.Drawing.Point(210, 282);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(22, 23);
            this.buttonHelp.TabIndex = 37;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            this.buttonHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormCheck);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(85, 282);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(55, 23);
            this.buttonExit.TabIndex = 38;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.buttonExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_FormCheck);
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(376, 313);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelNameGroup);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelinfoStudents);
            this.Controls.Add(this.listBoxSurnames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxSurnames;
        private System.Windows.Forms.Label labelinfoStudents;
        public System.Windows.Forms.Label labelInfo;
        public System.Windows.Forms.Label labelNameGroup;
        public System.Windows.Forms.Label labelCount;
        public System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExit;
    }
}