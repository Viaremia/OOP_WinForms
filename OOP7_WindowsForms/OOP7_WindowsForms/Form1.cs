using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OOP7_WindowsForms
{
    public partial class Form1 : Form
    {
        private const string IPAddr = "127.0.0.1";
        private static IPEndPoint IPEndPoint;
        private static ManualResetEvent allDone = new ManualResetEvent(false);
        Socket server;
        Socket handler;
        //Socket client;
        //TcpListener listener;

        string Query = "SELECT * FROM [Session]";
        string connectingString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Session.mdb";
        OleDbConnection connection;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Server_Load(object sender, EventArgs e)
        {
                DataGrid_Load();
        }

        private async void Accept_Click(object sender, EventArgs e)
        {
            string data = null;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Some of the fields are not write in.", "Warning!");
            else
            {
                //listener = new TcpListener(IPAddress.Parse(IPAddr), int.Parse(textBox1.Text));

                //listener.Start();
                //try
                //{
                //    while (true)
                //    {
                //        //allDone.Reset();

                //        client = await listener.AcceptSocketAsync(); //AcceptSocket();
                //        while (client.Connected)
                //        {
                //            byte[] bytes = new byte[1024];
                //            int bytesRec = client.Receive(bytes);
                //            data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                //        }
                //        //allDone.WaitOne();

                //        //client.Close();
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}


                try
                {
                    IPEndPoint = new IPEndPoint(IPAddress.Parse(IPAddr), int.Parse(textBox1.Text));
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    server.Bind(IPEndPoint);
                    server.Listen(2);



                    while (true)
                    {
                        try
                        {
                            await Task.Run(() =>
                            {
                                handler = server.Accept();
                            });


                            StringBuilder builder = new StringBuilder();
                            byte[] bytes = new byte[1024];
                            //int bytesRec = server.Receive(bytes);
                            do
                            {
                                int bytesRec = handler.Receive(bytes);
                                builder.Append(Encoding.UTF8.GetString(bytes, 0, bytesRec));
                                //data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                                MessageBox.Show("Connect", "Message!");
                            }
                            while(handler.Available > 0);
                            


                            //while (handler.Connected)
                            //{
                            //    bytesRec = handler.Receive(bytes);
                            //    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                            //    MessageBox.Show("Sended", "Message");
                            //}
                            //handler.Shutdown(SocketShutdown.Both);
                            //handler.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    //await Task.Run(() => 
                    //{
                    //    while (true)
                    //    {
                    //        byte[] bytes = new byte[1024];

                    //        int bytesRec = handler.Receive(bytes);
                    //        data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    //        MessageBox.Show("Done", "Message");
                    //    }

                    //});
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //private async void Accept()
        //{
        //    for(; ; )
        //    {
        //        var handler = await Task.Factory.FromAsync<Socket>(server.BeginAccept, server.EndAccept, true);
        //        MessageBox.Show("Connected", "Message!");
        //    }
        //}

        private void DataGrid_Load()
        {
            try
            {
                connection = new OleDbConnection(connectingString);
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(Query, connection))
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Server_Closing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //server.Shutdown(SocketShutdown.Both);
                //handler.Shutdown(SocketShutdown.Both);
                //handler.Close();
                //server.Close();
                //client.Close();
                //listener.Stop();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
