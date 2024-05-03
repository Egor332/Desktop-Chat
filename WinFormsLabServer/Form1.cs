using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsLabServer
{
    public partial class Form2 : Form
    {
        private bool _Working = false;
        public List<(TcpClient cl, int Id)> Clients = new List<(TcpClient, int)>();
        private Dictionary<int, string> ClientsName = new Dictionary<int, string>();
        private int minAvaliableId = 5;

        public IPHostEntry? hostInfo = null;
        public TcpListener? Server = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LogText.Text = "";
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            _Working = !_Working;
            if (_Working)
            {
                // start pressed
                StartServer();
                Messages.Message msg = new Messages.Message("Server", "Listening for incoming connections...", DateTime.Now);
                WriteMessageToLog(msg);
                msg = new Messages.Message("Server", $"IP: {hostInfo.AddressList[1]}, Port {PortText.Text}", DateTime.Now);
                WriteMessageToLog(msg);

                AddressText.Enabled = false;
                PortText.Enabled = false;
                StartStopButton.Text = "Stop";

                AuthorizationCheck();

            }
            else
            {
                // stop pressed
                CloseConnectionLogic();
            }
        }

        private void CloseConnectionLogic()
        {
            DisconnectButton.PerformClick();
            Messages.Message msg = new Messages.Message("Server", "Shutting down current connection", DateTime.Now);
            WriteMessageToLog(msg);
            Server?.Stop();
            PortText.Enabled = true;
            AddressText.Enabled = true;
            StartStopButton.Text = "Start";

        }

        async private void AuthorizationCheck()
        {
            while (_Working)
            {
                TcpClient client;
                try
                {
                    client = await Server.AcceptTcpClientAsync();
                }
                catch (System.Net.Sockets.SocketException e)
                {
                    continue;
                }

                string userName;
                StreamReader sr = new StreamReader(client.GetStream());
                try
                {
                    Messages.Authorization msg = JsonSerializer.Deserialize<Messages.Authorization>(sr.ReadLine());
                    if (!CheckKey(KeyText.Text, msg.Key)) throw new Exception();
                    userName = msg.Sender;

                    Messages.Message backMsg = new Messages.Message("Server", Messages.Message.Authorized, DateTime.Now);
                    StreamWriter sw = new StreamWriter(client.GetStream());
                    sw.WriteLine(JsonSerializer.Serialize(backMsg));
                    sw.Flush();

                    Messages.Message authMsg = new Messages.Message("Server", $"{userName} has connected", DateTime.Now);
                    WriteMessageToLog(authMsg);

                    Clients.Add((client, minAvaliableId));
                    ClientsName.Add(minAvaliableId, userName);
                    ListenClient(client, minAvaliableId);

                    
                    string[] elements = { minAvaliableId.ToString(), userName, "Kick" };
                    ListViewItem item = new ListViewItem(elements);
                    listView1.Items.Add(item);
                    minAvaliableId++;
                }
                catch (Exception ex)
                {
                    sr.Close();
                    client.Close();
                }
            }
        }

        private void CloseClientByForce(TcpClient client, int Id)
        {
            DeleteItemFromList(Id);
            Messages.Message discMsg = new Messages.Message("Server", $"{ClientsName[Id]} has disconnected", DateTime.Now);
            WriteMessageToLog(discMsg);
            client.Close();
        }

        async private void ListenClient(TcpClient client, int Id)
        {
            while (client.Connected)
            {
                try
                {
                    StreamReader sr = new StreamReader(client.GetStream());
                    Messages.Message msg = JsonSerializer.Deserialize<Messages.Message>(await sr.ReadLineAsync());
                    BroadcastForAll(client, msg);
                }
                catch (Exception ex)
                {
                    CloseClientByForce(client, Id);
                    Clients.Remove((client, Id));
                }
            }
        }

        private void BroadcastForAll(TcpClient? client, Messages.Message msg)
        {
            WriteMessageToLog(msg);
            foreach ((TcpClient other, int Id)  in Clients)
            {
                if (other != client)
                {
                    StreamWriter sw = new StreamWriter(other.GetStream());
                    sw.WriteLine(JsonSerializer.Serialize(msg));
                    sw.Flush();
                }
            }
        }

        private bool CheckKey(string realKey, string recivedKey)
        {
            return realKey.Equals(recivedKey);
        }

        private void WriteMessageToLog(Messages.Message msg)
        {
            LogText.AppendText(msg.ToString());
            LogText.AppendText(Environment.NewLine);
        }

        private void StartServer()
        {
            try
            {
                hostInfo = Dns.GetHostEntry(AddressText.Text);
                Server = new TcpListener(hostInfo.AddressList[0], int.Parse(PortText.Text));
                Server.Start();
            }
            catch (Exception e)
            {
                ShowDialog();
            }
            _Working = true;
        }

        private void KeyCheck_CheckedChanged(object sender, EventArgs e)
        {
            KeyText.UseSystemPasswordChar = !KeyText.UseSystemPasswordChar;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Messages.Message msg = new Messages.Message("Server", SendText.Text, DateTime.Now);
            SendText.Text = "";
            BroadcastForAll(null, msg);
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {         
            foreach ((TcpClient client, int Id) in Clients)
            {
                CloseClientByForce(client, Id);
            }
        }

        private void DeleteItemFromList(int Id)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == Id.ToString())
                {
                    listView1.Items.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
