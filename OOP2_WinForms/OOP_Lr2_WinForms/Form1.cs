using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lr2_WinForms
{
    public partial class Form1 : Form
    {
        string nativeText;

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Dmitry Peremena\nGroup: IPZ-18-2", "About");
        }
        //Option functions
        private void Cancel_Editing(object sender, EventArgs e)
        {
            richTextBox.Text = nativeText;
        }

        private void Find_Words(object sender, EventArgs e)
        {
            string[] textWords;
            textWords = richTextBox.Text.Split(' ');

            foreach (string word in textWords)
                foreach (char symb in word)
                    if (symb == Convert.ToChar(textBox_Statistic.Text.ToUpper()) || symb == Convert.ToChar(textBox_Statistic.Text.ToLower()))
                    {
                        listBox_Words.Items.Add(word);
                        break;
                    }
        }

        private void Upper_Text(object sender, EventArgs e)
        {
            richTextBox.Text = richTextBox.Text.ToUpper();
        }

        private void Letters_Count(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < richTextBox.Text.Length;i++)
                if (richTextBox.Text[i] != ' ')
                    count++;
            textBox_Statistic.Text = "Count of letters: " + count;
        }

        private void Words_Count(object sender, EventArgs e)
        {
            string[] wordsCount;
            wordsCount = richTextBox.Text.Split(' ');
            textBox_Statistic.Text = "Count of words: " + wordsCount.Length;
        }
        //Edit funcrions
        private void TxtFont_Click(object sender, EventArgs e)
        {
            int fontSize = Convert.ToInt32(comboBox_Fnt_Size.Text);
            string fontStyle = Convert.ToString(listBox_Fonts.Text);
            richTextBox.SelectionFont = new Font(fontStyle, fontSize, FontStyle.Regular);
        }

        private void FontSize_Click(object sender, EventArgs e)
        {
            int fontSize = Convert.ToInt32(comboBox_Fnt_Size.Text);
            string fontStyle = Convert.ToString(listBox_Fonts.Text);
            richTextBox.SelectionFont = new Font(fontStyle, fontSize, FontStyle.Regular);
        }

        private void TxtColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox.SelectionColor = color.Color; 
        }
        //File fuctions
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            
            saveFile.Filter = "Word file(*.doc)|*.rtf";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFile.FileName;
            richTextBox.SaveFile(filename);
            //richTextBox.SaveFile(filename);
            //File.WriteAllText(filename, richTextBox.Text);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text file(*.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFile.FileName;
            nativeText = File.ReadAllText(filename);
            richTextBox.Text = nativeText;
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            comboBox_Fnt_Size.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Fnt_Size.Text = Convert.ToString(comboBox_Fnt_Size.Items[0]);
            listBox_Fonts.Text = Convert.ToString(listBox_Fonts.Items[0]);
            textBox_Statistic.MaxLength = 1;
        }

        public Form1()
        {
            InitializeComponent();
            uppercaseToolStripMenuItem.Click += Upper_Text;
            countOfLettersToolStripMenuItem.Click += Letters_Count;
            countOfWordsInTheTextToolStripMenuItem.Click += Words_Count;
            textFontToolStripMenuItem.Click += TxtFont_Click;
            textSizeToolStripMenuItem.Click += FontSize_Click;
            textColorToolStripMenuItem.Click += TxtColor_Click;
            openToolStripMenuItem.Click += Open_Click;
            saveFileToolStripMenuItem.Click += Save_Click;
            finishWorkToolStripMenuItem.Click += Finish_Click;
        } 
    }
}
