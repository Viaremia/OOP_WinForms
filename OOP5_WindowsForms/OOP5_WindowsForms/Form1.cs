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

namespace OOP5_WindowsForms
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Session.mdb";
        private OleDbConnection grid2_dbConnection;
        private OleDbConnection grid1_dbConnection;
        private string DataPath = null;

        public Form1()
        {
            InitializeComponent();
            AutoLoad_Data();
        }
        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OOP_LR5\nAutor: Peremena Dmitry\nGroup: IPZ-18-2", "About");
        }
        //Data
        private void InrtQ_DltQ_UpdtQ_Click(object sender, EventArgs e)
        {
            //string s = "INSERT INTO [Session] ([ID], [Group], [Surname], [Subject], [Mark]) VALUES ('11', 'IPZ', 'Raskov', 'OOP', '5')";
            try
            {
                using (OleDbCommand command = new OleDbCommand(textBox1.Text, grid1_dbConnection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption!");
            }
        }
        
        private void SampleQ_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                using (OleDbCommand command = new OleDbCommand(textBox1.Text, grid1_dbConnection))
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption!");
            }
        }

        private void DownloadDB2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                string query = "SELECT * FROM [Session]";
                using (OleDbCommand command = new OleDbCommand(query, grid2_dbConnection))
                {
                    if (dataGridView2.Rows.Count != 0)
                        dataGridView2.Rows.Clear();
                    OleDbDataReader reader = command.ExecuteReader();
                    int i = dataGridView2.ColumnCount;
                    while (reader.Read())
                        dataGridView2.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
            else
                MessageBox.Show("Connect database_2!", "Warning!");
            
        }

        private void DownloadDB1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string query = "SELECT * FROM [Session]";
                using (OleDbCommand command = new OleDbCommand(query, grid1_dbConnection))
                {
                    if (dataGridView1.Rows.Count != 0)
                        dataGridView1.Rows.Clear();
                    OleDbDataReader reader = command.ExecuteReader();
                    int i = dataGridView1.ColumnCount;
                    while (reader.Read())
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
            else
                MessageBox.Show("Connect database_1!", "Warning!");
        }
        // Service
        private void SetPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "DB file(*.mdb)|*.mdb";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            DataPath = openFile.FileName;
        }
        //Help functions
        private void AutoLoad_Data()
        {
            grid2_dbConnection = new OleDbConnection(connectString);
            grid2_dbConnection.Open();

            string query = "SELECT * FROM [Session]";
            using (OleDbCommand command = new OleDbCommand(query, grid2_dbConnection))
            {
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    dataGridView2.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
            }
        }

        private void ClckBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EN. Query input format:\n" +
                "RU. Формат ввода запроса:\n\n" +
                "1. SELECT * FROM [Session]\n" +
                "2. SELECT * FROM [Session] ORDER BY [Mark]\n" +
                "3. INSERT INTO [Session] ([ID], [Group], ...) VALUES ('1', 'IPZ', ...)\n" +
                "4. UPDATE [Session] SET [Group] = 'ASA', [Mark] = '1' WHERE [ID] = 2\n" +
                "5. DELETE FROM [Session] WHERE [ID] = 9\n", "Rules/Правила");
        }

        private void Form_Close(object sender, EventArgs e)
        {
            grid2_dbConnection.Close();
            grid1_dbConnection.Close();
        }
        //File
        private void Finish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisconnectDB_Click(object sender, EventArgs e)
        {
            if (DataPath != null) {
                grid1_dbConnection.Close();
                grid2_dbConnection.Close();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                dataGridView2.Rows.Clear();
                dataGridView1.Rows.Clear();
            }
            else
                MessageBox.Show("No connection!", "Warning!");
        }

        private void ConnectDB_Click(object sender, EventArgs e)
        {
            if (DataPath != null)
            {
                grid1_dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DataPath);
                grid1_dbConnection.Open();
                checkBox1.Checked = true;
            }
            else
                MessageBox.Show("Please, set data path!", "Warning!");
        }
    }
}
