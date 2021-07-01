using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Telepathy;

namespace WannabeChat
{
    public partial class Main : MetroForm
    {
        #region Declaration

        public bool Update { get; set; }

        //private readonly int Interval;
        //public string UpdateInterval = "1";

        #endregion Declaration

        public Main()
        {
            InitializeComponent();
            //Interval = Convert.ToInt16(UpdateInterval);
            this.StyleManager = StyleManager_Man;

            Update = true;
        }

        #region Formload/stuff

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void MetroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked)
            {
                StyleManager_Man.Theme = MetroThemeStyle.Dark;
                Properties.Settings.Default.Thingy = true;
                Properties.Settings.Default.Save();
                //Mecha.Theme = MetroThemeStyle.Dark;
                //GEILO.Style = MetroColorStyle.Black;
            }
            if (metroToggle1.Checked == false)
            {
                StyleManager_Man.Theme = MetroThemeStyle.Light;
                Properties.Settings.Default.Thingy = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTabControl1.TabPages.Remove(metroTabPage3);

            //This was suppposed to be a ping to the server that then looks up if there is an update
            //available or not

            //var ping = new System.Net.NetworkInformation.Ping();
            //ping.Send("www.tulexnow.de");
            //var result = ping.Send("www.tulexnow.de");
            //if (result.Status == System.Net.NetworkInformation.IPStatus.Success)
            //{
            //    //MessageBox.Show("","hi");
            //}

            //Just some small properties
            metroToggle1.Checked = Properties.Settings.Default.Thingy;

            metroLabel5.Text = Properties.Settings.Default.Number.ToString();

            string[] commandLineArgs = Environment.GetCommandLineArgs();
            for (int i = 0; i < commandLineArgs.Length; i++)
            {
                if (commandLineArgs[i] == "-iamdev")
                {
                    metroTabControl1.TabPages.Insert(2, metroTabPage3);
                }
            }
        }

        #endregion Formload/stuff

        #region ExitButton/Tests

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion ExitButton/Tests

        #region test

        private async void ColorChanger_CheckedChanged(object sender, EventArgs e)
        {
            //Was just a fun thing to try probably couldve been done better...
            while (ColorChanger.Checked)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (i == 15)
                    {
                        i = 0;
                    }
                    await Task.Delay(500);
                    StyleManager.Style = (MetroColorStyle)i;
                }
            }
        }

        #endregion test

        public static string GetIPAddress()
        {
            using (WebClient client = new WebClient())
            {
                string htmlCode = client.DownloadString("http://www.myexternalip.com/raw");
                return htmlCode;
            }
        }

        private void GetIp_Click(object sender, EventArgs e)
        {
            string ipaddress = GetIPAddress();

            Clipboard.SetText(ipaddress);
        }

        private void BT_Connect_Click(object sender, EventArgs e)
        {
            Server_Client.Server.StartServer();
        }

        private void BT_SendMessage_Click(object sender, EventArgs e)
        {
            Server_Client.Client.SendMessage();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Server_Client.Client.ConnectToIP();
        }
    }
}