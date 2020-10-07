using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace OOP3_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Peremena Dmitry\nGroup: IPZ 18-2", "About");
        }

        private void Coincidence_Click(object sender, EventArgs e)
        {
            int[] tempArr1 = new int[Matrix1.ColumnCount];
            int[] tempArr2 = new int[Matrix2.ColumnCount];
            for (int j = 0; j < Matrix1.RowCount - 1; j++)
            {
                for (int i = 0; i < Matrix1.ColumnCount; i++)
                {
                    tempArr1[i] = Convert.ToInt32(Matrix1[j, i].Value);
                    tempArr2[i] = Convert.ToInt32(Matrix2[j, i].Value);
                }

                for (int i = 0; i < Matrix1.ColumnCount; i++)
                {
                    if (tempArr1[i] == tempArr2[i])
                        Matrix3[j, i].Value = tempArr1[i];
                    else
                        Matrix3[j, i].Value = "!=";
                }
            }
        }

        private void Transpose_Click(object sender, EventArgs e)
        {
            int[] tempArr1 = new int[Matrix1.ColumnCount];
            int[] tempArr2 = new int[Matrix2.ColumnCount];
            for (int j = 0; j < Matrix1.RowCount - 1; j++)
            {
                for (int i = 0; i < Matrix1.ColumnCount; i++)
                {
                    tempArr1[i] = Convert.ToInt32(Matrix1[i, j].Value);
                    tempArr2[i] = Convert.ToInt32(Matrix1[j, i].Value);
                }
                for (int i = 0; i < Matrix1.ColumnCount; i++)
                {
                    Matrix3[i, j].Value = tempArr2[i];
                    Matrix3[j, i].Value = tempArr1[i];
                }
            }
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < Matrix1.RowCount - 1; j++)
                for (int i = 0; i < Matrix1.ColumnCount; i++)
                    Matrix3[i, j].Value = Convert.ToInt32(Matrix1[i, j].Value) + Convert.ToInt32(Matrix2[i, j].Value);
        }

        private void Line_Sort(object sender, EventArgs e)
        {
            int[] tempArr1 = new int[Matrix1.ColumnCount];
            int[] tempArr2 = new int[Matrix2.ColumnCount];
            for (int j = 0; j < Matrix1.RowCount; j++)
            {
                for (int i = 0; i < Matrix1.ColumnCount; i++) {
                    tempArr1[i] = Convert.ToInt32(Matrix1[i, j].Value);
                    tempArr2[i] = Convert.ToInt32(Matrix2[i, j].Value);
                }
                    
                Array.Sort(tempArr1);
                Array.Sort(tempArr2);
                    
                for (int i = 0; i < Matrix1.ColumnCount; i++) {
                    Matrix1[i, j].Value = tempArr1[i];
                    Matrix2[i, j].Value = tempArr2[i];
                }
            }
        }

        private void Column_Sort(object sender, EventArgs e)
        {
            int[] tempArr1 = new int[Matrix1.ColumnCount];
            int[] tempArr2 = new int[Matrix2.ColumnCount];
            for (int j = 0; j < Matrix1.RowCount - 1; j++)
            {
                for (int i = 0; i < Matrix1.ColumnCount; i++)
                {
                    tempArr1[i] = Convert.ToInt32(Matrix1[j, i].Value);
                    tempArr2[i] = Convert.ToInt32(Matrix2[j, i].Value);
                }

                Array.Sort(tempArr1);
                Array.Sort(tempArr2);

                for (int i = 0; i < Matrix1.ColumnCount; i++)
                {
                    Matrix1[j, i].Value = tempArr1[i];
                    Matrix2[j, i].Value = tempArr2[i];
                }
            }
        }

        private void Show_Hide(object sender, EventArgs e)
        {
            if (Matrix1.Visible) {
                Matrix1.Visible = false;
                Matrix2.Visible = false;
            }
            else {
                Matrix1.Visible = true;
                Matrix2.Visible = true;
            } 
        }

        private void Enabled_Disabled(object sender, EventArgs e)
        {
            if (Matrix1.Enabled) {
                Matrix1.Enabled = false;
                Matrix2.Enabled = false;
            }
            else {
                Matrix1.Enabled = true;
                Matrix2.Enabled = true;
            }
        }

        private void Table_Color(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.Cancel)
                return;
            Matrix1.GridColor = color.Color;
            Matrix2.GridColor = color.Color;
        }

        private void Text_Color(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.Cancel)
                return;
            Matrix1.DefaultCellStyle.ForeColor = color.Color;
            Matrix2.DefaultCellStyle.ForeColor = color.Color;
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var a = Matrix1[0, 0].Value;
            var b = Matrix1[0, 1].Value;
            var c = Matrix1[0, 2].Value;
            var d = Matrix1[0, 3].Value;
            string[,] mtr1, mtr2, mtr3;
            mtr1 = new string[Matrix1.RowCount, Matrix1.ColumnCount];
            mtr2 = new string[Matrix2.RowCount, Matrix2.ColumnCount];
            mtr3 = new string[Matrix3.RowCount, Matrix3.ColumnCount];
            for (int i = 0; i < Matrix1.RowCount - 1; i++)
            {
                for (int j = 0; j < Matrix1.ColumnCount; j++)
                {
                    mtr1[j, i] = Convert.ToString(Matrix1[j, i].Value);
                    mtr2[j, i] = Convert.ToString(Matrix2[j, i].Value);
                    mtr3[j, i] = Convert.ToString(Matrix3[j, i].Value);
                }
            }
            SaveMatrix sm = new SaveMatrix();
            sm.Save(mtr1, "File1.txt");
            sm.Save(mtr2, "File2.txt");
            sm.Save(mtr3, "File3.txt");
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (File.Exists("File1.txt") && File.Exists("File2.txt"))
            {
                string[] f1 = File.ReadAllLines("File1.txt");
                string[] f2 = File.ReadAllLines("File2.txt");
                for (int i = 0; i < f1.Length; i++)
                {
                    string[] text1 = f1[i].Split(' ');
                    string[] text2 = f2[i].Split(' ');
                    Matrix1.Rows.Add(text1[0], text1[1], text1[2], text1[3], text1[4]);
                    Matrix2.Rows.Add(text2[0], text2[1], text2[2], text2[3], text2[4]);
                    Matrix3.Rows.Add(null, null, null, null, null);
                }
            }
            else
                MessageBox.Show("File1 or File2 not found!", "Error");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                Matrix1.Columns.Add(Convert.ToString(i), Convert.ToString(i));
                Matrix2.Columns.Add(Convert.ToString(i), Convert.ToString(i));
                Matrix3.Columns.Add(Convert.ToString(i), Convert.ToString(i));
            }

        }
    }
}
