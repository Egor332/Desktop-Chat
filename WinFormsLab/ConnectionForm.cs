using Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLab
{
    public partial class ConnectionForm : Form
    {
        private Form1 CallingForm;

        public bool Connected { get; set; } 
        public ConnectionForm(Form1 callingForm)
        {
            InitializeComponent();
            AddressText.Text = "localhost";
            PortText.Text = "9000";
            UserText.Text = "user";
            KeyText.Text = "";
            ConnectionBar.Value = 0;
            CallingForm = callingForm;            
            Connected = false;

        }

        private void ShowKeyBox_CheckedChanged(object sender, EventArgs e)
        {
            KeyText.UseSystemPasswordChar = !KeyText.UseSystemPasswordChar;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ConnectButton.Enabled = false;           
            if (!Connect())
            {
                ConnectionFail();
                return;
            }
            ConnectionBar.Value = 25;
            ConfirmConnection();          
        }

        private void ConfirmConnection()
        {
            
            try
            {
                Messages.Authorization authorization = new Messages.Authorization(UserText.Text, KeyText.Text);
                StreamWriter sw = new StreamWriter(CallingForm.client.GetStream());
                sw.WriteLine(JsonSerializer.Serialize(authorization));
                sw.Flush();
                ConnectionBar.Value = 50;

                StreamReader sr = new StreamReader(CallingForm.client.GetStream());
                Messages.Message msg = (JsonSerializer.Deserialize<Messages.Message>(sr.ReadLine()));
                ConnectionBar.Value = 75;

                if (msg.Text == Messages.Message.Authorized)
                {
                    ConnectionSuccess();
                }
                else
                {
                    ConnectionFail();
                };
            }
            catch (Exception ex)
            {
                ConnectionFail();
                return;
            }           
        }

        private void ConnectionSuccess()
        {
            ConnectionBar.Value = 100;
            MessageBox.Show("Success", "Connection");
            CallingForm.UserName = UserText.Text;
            Connected = true;
            this.Close();
        }

        private void ConnectionFail()
        {
            MessageBox.Show("Fail", "Connection");
            ConnectionBar.Value = 0;
            ConnectButton.Enabled = true;
        }

        private bool Connect()
        {
            int port = int.Parse(PortText.Text);
            CallingForm.client  = new TcpClient();
            try
            {
                CallingForm.client.Connect(AddressText.Text, port);
                return true;
            } 
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
