namespace OOP_Lr2_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countOfWordsInTheTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countOfLettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findTheWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelEditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.listBox_Fonts = new System.Windows.Forms.ListBox();
            this.textBox_Statistic = new System.Windows.Forms.TextBox();
            this.comboBox_Fnt_Size = new System.Windows.Forms.ComboBox();
            this.listBox_Words = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutThisProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.finishWorkToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.openToolStripMenuItem.Text = "Open file";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveFileToolStripMenuItem.Text = "Save file";
            // 
            // finishWorkToolStripMenuItem
            // 
            this.finishWorkToolStripMenuItem.Name = "finishWorkToolStripMenuItem";
            this.finishWorkToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.finishWorkToolStripMenuItem.Text = "Finish work";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textColorToolStripMenuItem,
            this.textSizeToolStripMenuItem,
            this.textFontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.textColorToolStripMenuItem.Text = "Text color";
            // 
            // textSizeToolStripMenuItem
            // 
            this.textSizeToolStripMenuItem.Name = "textSizeToolStripMenuItem";
            this.textSizeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.textSizeToolStripMenuItem.Text = "Text size";
            // 
            // textFontToolStripMenuItem
            // 
            this.textFontToolStripMenuItem.Name = "textFontToolStripMenuItem";
            this.textFontToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.textFontToolStripMenuItem.Text = "Text font";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countOfWordsInTheTextToolStripMenuItem,
            this.countOfLettersToolStripMenuItem,
            this.uppercaseToolStripMenuItem,
            this.findTheWordsToolStripMenuItem,
            this.cancelEditingToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // countOfWordsInTheTextToolStripMenuItem
            // 
            this.countOfWordsInTheTextToolStripMenuItem.Name = "countOfWordsInTheTextToolStripMenuItem";
            this.countOfWordsInTheTextToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.countOfWordsInTheTextToolStripMenuItem.Text = "Count of words in the text";
            // 
            // countOfLettersToolStripMenuItem
            // 
            this.countOfLettersToolStripMenuItem.Name = "countOfLettersToolStripMenuItem";
            this.countOfLettersToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.countOfLettersToolStripMenuItem.Text = "Count of letters in the text";
            // 
            // uppercaseToolStripMenuItem
            // 
            this.uppercaseToolStripMenuItem.Name = "uppercaseToolStripMenuItem";
            this.uppercaseToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.uppercaseToolStripMenuItem.Text = "Uppercase";
            // 
            // findTheWordsToolStripMenuItem
            // 
            this.findTheWordsToolStripMenuItem.Name = "findTheWordsToolStripMenuItem";
            this.findTheWordsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.findTheWordsToolStripMenuItem.Text = "Find the words";
            this.findTheWordsToolStripMenuItem.Click += new System.EventHandler(this.Find_Words);
            // 
            // cancelEditingToolStripMenuItem
            // 
            this.cancelEditingToolStripMenuItem.Name = "cancelEditingToolStripMenuItem";
            this.cancelEditingToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cancelEditingToolStripMenuItem.Text = "Cancel editing";
            this.cancelEditingToolStripMenuItem.Click += new System.EventHandler(this.Cancel_Editing);
            // 
            // aboutThisProgramToolStripMenuItem
            // 
            this.aboutThisProgramToolStripMenuItem.Name = "aboutThisProgramToolStripMenuItem";
            this.aboutThisProgramToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutThisProgramToolStripMenuItem.Text = "About";
            this.aboutThisProgramToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 51);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(605, 355);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // listBox_Fonts
            // 
            this.listBox_Fonts.FormattingEnabled = true;
            this.listBox_Fonts.Items.AddRange(new object[] {
            "Tahoma",
            "Arial",
            "Times New Roman",
            "Calibri"});
            this.listBox_Fonts.Location = new System.Drawing.Point(642, 51);
            this.listBox_Fonts.Name = "listBox_Fonts";
            this.listBox_Fonts.Size = new System.Drawing.Size(120, 30);
            this.listBox_Fonts.TabIndex = 2;
            this.listBox_Fonts.Click += new System.EventHandler(this.TxtFont_Click);
            // 
            // textBox_Statistic
            // 
            this.textBox_Statistic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Statistic.Location = new System.Drawing.Point(642, 186);
            this.textBox_Statistic.MaxLength = 1;
            this.textBox_Statistic.Name = "textBox_Statistic";
            this.textBox_Statistic.Size = new System.Drawing.Size(120, 20);
            this.textBox_Statistic.TabIndex = 3;
            // 
            // comboBox_Fnt_Size
            // 
            this.comboBox_Fnt_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Fnt_Size.FormattingEnabled = true;
            this.comboBox_Fnt_Size.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.comboBox_Fnt_Size.Location = new System.Drawing.Point(642, 240);
            this.comboBox_Fnt_Size.Name = "comboBox_Fnt_Size";
            this.comboBox_Fnt_Size.Size = new System.Drawing.Size(120, 21);
            this.comboBox_Fnt_Size.TabIndex = 4;
            // 
            // listBox_Words
            // 
            this.listBox_Words.FormattingEnabled = true;
            this.listBox_Words.Location = new System.Drawing.Point(642, 120);
            this.listBox_Words.Name = "listBox_Words";
            this.listBox_Words.Size = new System.Drawing.Size(120, 30);
            this.listBox_Words.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Space for some text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(639, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Statistic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(639, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fonts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(639, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Font size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(639, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Words";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Words);
            this.Controls.Add(this.comboBox_Fnt_Size);
            this.Controls.Add(this.textBox_Statistic);
            this.Controls.Add(this.listBox_Fonts);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countOfWordsInTheTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countOfLettersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppercaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findTheWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelEditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisProgramToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ListBox listBox_Fonts;
        private System.Windows.Forms.TextBox textBox_Statistic;
        private System.Windows.Forms.ComboBox comboBox_Fnt_Size;
        private System.Windows.Forms.ListBox listBox_Words;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

