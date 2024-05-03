using System.Net.Sockets;
using System.Text.Json;

namespace WinFormsLab
{


    public partial class Form1 : Form
    {

        private bool _You;

        public string UserName;

        private bool _Connected = false;

        public TcpClient? client = new();

        public event EventHandler<Messages.Message>? MessageReceived;

        public Form1()
        {
            InitializeComponent();
            ChangeMenuOptions();
            this.MessageReceived += OnMessageRecived;
        }

        private void  ChangeMenuOptions()
        {
            ConnectOption.Enabled = !_Connected;
            DisconnectOption.Enabled = _Connected;
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                PrintMessage();
            }   
                
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            PrintMessage();
        }

        private void PrintMessage()
        {
            string text = sendTextBox.Text;
            sendTextBox.Text = "";
            MessageForm mf;
            if (!_Connected)
            {
                if (_You)
                {
                    UserName = "You";

                }
                else
                {
                    UserName = "notYou";

                }
                _You = !_You;
                mf = new MessageForm(UserName, text);
            }
            else
            { 
                Messages.Message msg = new Messages.Message(UserName, text, DateTime.Now);
                StreamWriter sw = new StreamWriter(client.GetStream());
                sw.WriteLine(JsonSerializer.Serialize(msg));
                sw.Flush();
                mf = new MessageForm("You", text);
                //UserName = "You";
            }

            // mf = new MessageForm(UserName, text);         
            mf.ResizeObject(msgArea.Width);
            msgArea.Controls.Add(mf);
        }

        private void msgArea_Resize(object sender, EventArgs e)
        {
            foreach (IResizeble mf in msgArea.Controls)
            {
                mf.ResizeObject(msgArea.Width);
            }

        }

        private void msgArea_ControlAdded(object sender, ControlEventArgs e)
        {
            msgArea.ScrollControlIntoView(e.Control);
        }

        private void ExitOption_Click(object sender, EventArgs e)
        {
            if (_Connected)
            {
                DisconnectOption.PerformClick();
            }
            Application.Exit();
        }

        private void DisconnectOption_Click(object sender, EventArgs e)
        {
            client.Close();
            _Connected = false;
            ShowStatus("Disconnected");
            ChangeMenuOptions();

        }

        private void ConnectOption_Click(object sender, EventArgs e)
        {
            ConnectionForm cf = new ConnectionForm(this);
            cf.ShowDialog();            
            _Connected = cf.Connected;
            ChangeMenuOptions();
            if (_Connected)
            {
                ShowStatus("Connected");
                _You = true;
            }
            ReadMessagesFromServer();
        }

        async private void ReadMessagesFromServer()
        {
            while (_Connected)
            {
                StreamReader sr = new StreamReader(client.GetStream());
                try
                {
                    Messages.Message msg = JsonSerializer.Deserialize<Messages.Message>(await sr.ReadLineAsync());
                    MessageReceived.Invoke(this, msg);
                }
                catch (Exception e)
                {
                    DisconnectOption.PerformClick();
                }               
            }
        }

        private void OnMessageRecived(object sender, Messages.Message msg) 
        {
            MessageForm mf = new MessageForm(msg.Sender, msg.Text, msg.Time.ToString("hh:mm"));
            mf.ResizeObject(msgArea.Width);
            msgArea.Controls.Add(mf);
        }

        private void ShowStatus(string status)
        {
            StatusMessage sm = new StatusMessage();
            sm.Text = status;
            sm.ForeColor = SystemColors.ControlDarkDark;
            msgArea.Controls.Add(sm);
            sm.ResizeObject(msgArea.Width);
            
            

        }
    }
}
