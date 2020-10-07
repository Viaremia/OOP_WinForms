using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Peremena Dmitry\nGroup: IPZ-18-2", "About");
        }
         
        private void GetLast_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (MdiChildren.Count() > i)
                i++;
            MdiChildren[--i].Activate();
        }

        private void GetFirst_Click(object sender, EventArgs e)
        {
            MdiChildren[0].Activate();
        }

        private void SetNum_Click(object sender, EventArgs e)
        {
            for (int i = 0, j = 1; i < MdiChildren.Count(); i++, j++)
                MdiChildren[i].Text = j.ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            do
                MdiChildren[0].Close();
            while (MdiChildren.Count() > 0);
        }

        private void Mosaic_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void Cascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
    }
}
