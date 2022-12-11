namespace StudentsMarksApp
{
    partial class FormExit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExit));
            this.buttonNoClose = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelQustion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNoClose
            // 
            this.buttonNoClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNoClose.Location = new System.Drawing.Point(208, 104);
            this.buttonNoClose.Name = "buttonNoClose";
            this.buttonNoClose.Size = new System.Drawing.Size(75, 23);
            this.buttonNoClose.TabIndex = 1;
            this.buttonNoClose.Text = "Нет";
            this.buttonNoClose.UseVisualStyleBackColor = true;
            this.buttonNoClose.Click += new System.EventHandler(this.ButtonNoClose_Click);
            this.buttonNoClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormExit_KeyDown);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Location = new System.Drawing.Point(12, 104);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Да";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.buttonExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormExit_KeyDown);
            // 
            // labelQustion
            // 
            this.labelQustion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQustion.Location = new System.Drawing.Point(28, 55);
            this.labelQustion.Name = "labelQustion";
            this.labelQustion.Size = new System.Drawing.Size(245, 46);
            this.labelQustion.TabIndex = 3;
            this.labelQustion.Text = "Вы действительно хотите выйти?";
            this.labelQustion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(295, 141);
            this.Controls.Add(this.labelQustion);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNoClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выход";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormExit_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNoClose;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelQustion;
    }
}