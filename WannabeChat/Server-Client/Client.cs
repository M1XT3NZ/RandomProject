using System;
using System.Text;

namespace WannabeChat.Server_Client
{
    public class Client
    {
        private static Telepathy.Client client = TClient.GetClient();

        private static Main _form;

        public static void SendMessage()
        {
            Byte[] nice = Encoding.ASCII.GetBytes(_form.Nickname.Text + " : " + _form.Message_Chat.Text);
            client.Send(nice);
            _form.Message_Chat.Text = "";
        }

        public static void ConnectToIP()
        {
            client.Connect(_form.Client_IP.Text, Convert.ToInt32(_form.Port_txt.Text));
            System.Windows.Forms.Timer _Client_Tick = new System.Windows.Forms.Timer();
            _Client_Tick.Tick += Client_Tick;
            _Client_Tick.Interval = 1;
            _Client_Tick.Start();
        }

        private static void Client_Tick(object sender, EventArgs e)
        {
            Telepathy.Message msg;
            while (client.GetNextMessage(out msg))
            {
                switch (msg.eventType)
                {
                    case Telepathy.EventType.Connected:
                        Console.WriteLine("Connected");
                        break;

                    case Telepathy.EventType.Data:
                        Console.WriteLine("Data: " + BitConverter.ToString(msg.data));
                        _form.Chat_TextBox.AppendText(Environment.NewLine + Encoding.ASCII.GetString(msg.data));
                        break;

                    case Telepathy.EventType.Disconnected:
                        Console.WriteLine("Disconnected");
                        break;
                }
            }
        }
    }

    public static class TClient
    {
        private static Telepathy.Client _client;

        public static Telepathy.Client GetClient()
        {
            if (_client != null)
                return _client;
            _client = new Telepathy.Client();

            return _client;
        }
    }
}