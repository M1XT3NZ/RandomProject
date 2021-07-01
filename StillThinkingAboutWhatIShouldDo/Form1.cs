using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

using IniParser;
using IniParser.Model; //I will maybe use the ini parser (dont really like xml)
using System.Media;
using Bleak;
using System.Net;

//using Telepathy;
using Message = Telepathy.Message;
using Event = Telepathy.EventType;

namespace StillThinkingAboutWhatIShouldDo
{
    public partial class Form1 : MetroForm
    {
        #region Declaration

        public bool Update { get; set; }

        //private readonly int Interval;
        //public string UpdateInterval = "1";

        #endregion Declaration

        public Form1()
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
            metroTabControl1.TabPages.Remove(metroTabPage4);
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

            //Properties.Settings.Default.Number;

            string[] commandLineArgs = Environment.GetCommandLineArgs();
            commandLineArgs.SetValue("-iamdev", 0);
            for (int i = 0; i < commandLineArgs.Length; i++)
            {
                if (commandLineArgs[i] == "-iamdev")
                {
                    metroTabControl1.TabPages.Insert(2, metroTabPage3);
                }
                else if (commandLineArgs[i] == "-injector")
                {
                    metroTabControl1.TabPages.Insert(3, metroTabPage4);
                }
                //else
                //{
                //    metroTabControl1.TabPages.Remove(metroTabPage4);
                //    metroTabControl1.TabPages.Remove(metroTabPage3);
                //}
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