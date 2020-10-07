using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace OOP4_WindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (radioButton_Save.Checked)
            {
                StreamWriter sw = new StreamWriter("file_for_save.txt", false);
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        sw.Write(dataGridView1[j, i].Value + "\t");
                    }
                    sw.Write("\n");
                }
                sw.Close();
            }
            else
            {
                BackColor = Color.White;
                dataGridView1.GridColor = Color.Black;
                Size = dataGridView1.Size;
            }
        }

        private void Chacked_Changed(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void More_Click(object sender, EventArgs e)
        {
            if (button1.Text == "More") {
                Height = 485;
                button1.Text = "Less";
            }
            else {
                Height = 432;
                button1.Text = "More";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Height = 432;
            string temp_str = File.ReadAllText("table_name.txt");
            string[] table = temp_str.Split(' ');
            foreach (string id in table)
                dataGridView1.Columns.Add(id, id);

            string[] temp_string = File.ReadAllLines("table_data.txt");
            for (int i = 0, j = 0; i < temp_string.Length; i++, j = 0) {
                table = temp_string[i].Split(' ');
                dataGridView1.Rows.Add(table[j], table[++j], table[++j], table[++j]);
            }
        }
        
    }
}
