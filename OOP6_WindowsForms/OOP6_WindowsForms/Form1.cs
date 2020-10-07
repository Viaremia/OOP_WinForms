using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6_WindowsForms
{
    public partial class Form1 : Form
    {
        private string path = null;
        public static string connectingString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =";
        private OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(textBox1, "The samples of query:\n"+
                "SELECT * FROM [Session] WHERE [Mark] = 5\n" +
                "UPDATE [Session] SET [Group] = 'ASI', [Mark] = '1' WHERE [ID] = 9 ");
        }
        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OOP6_WinForms\nAutor: Peremena Dmitry\nGroup: IPZ-18-2", "About");
        }
        //Data
        private void ModificationQ_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbCommand command = new OleDbCommand(textBox1.Text, connection)) 
                {
                    command.ExecuteNonQuery();
                }
                using (OleDbCommand command = new OleDbCommand("SELECT * FROM [Session]", connection))
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (reader.Read())
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
            }
        }

        private void SampleQ_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbCommand command = new OleDbCommand(textBox1.Text, connection))
                {
                    dataGridView1.Rows.Clear();
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
            }
        }

        private void DownloadDB_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Session]";
            try
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
            }
        }

        //File
        private void FinishWork_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisconnectDB_Click(object sender, EventArgs e)
        {
            connection.Close();
            dataGridView1.Rows.Clear();
        }

        private void ConnectDB_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                connection = new OleDbConnection(connectingString + path);
                connection.Open();
            }
            else
                MessageBox.Show("Set database path", "Warning!");
        }
        //Service
        private void SetPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "DB file(*.mdb)|*.mdb";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            else
                path = openFile.FileName;
        }
    }
}
