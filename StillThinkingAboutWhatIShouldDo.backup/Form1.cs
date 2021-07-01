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
using System.Data.Design;

namespace StillThinkingAboutWhatIShouldDo
{
    public partial class Form1 : MetroForm
    {
        #region Declaration

        private readonly int Interval;
        private bool IsRunningS = false;
        private Telepathy.Client client = new Telepathy.Client();
        private Telepathy.Server server = new Telepathy.Server();

        #endregion Declaration

        private int count = 0;

        public Form1()
        {
            InitializeComponent();
            Interval = Convert.ToInt16(UpdateInterval);
            this.StyleManager = StyleManager_Man;

            Update = true;
        }

        public int ConnectionID = 500;
        public bool Update { get; set; }

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

        public string UpdateInterval = "1";

        private void Form1_Load(object sender, EventArgs e)
        {
            //Server.MainServer.Send(ConnectionID, Encoding.ASCII.GetBytes("[<MESSAGE>]Opened chat"));

            //ConnectLoop();

            WebClient death = new WebClient();
            var ping = new System.Net.NetworkInformation.Ping();
            ping.Send("www.tulexnow.de");
            var result = ping.Send("www.tulexnow.de");

            if (result.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                //MessageBox.Show("","hi");
            }

            metroToggle1.Checked = Properties.Settings.Default.Thingy;

            count = Properties.Settings.Default.Number;
            metroLabel5.Text = Properties.Settings.Default.Number.ToString();
            //Properties.Settings.Default.Number;
            danke();

            //metroTabControl1.TabPages.Remove(metroTabPage4);
            //metroTabControl1.TabPages.Remove(metroTabPage3);
            string[] commandLineArgs = Environment.GetCommandLineArgs();
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
            }
        }

        private async void danke()
        {
            while (true)
            {
                await Task.Delay(1000);
                metroLabel3.Text = "Waiting to Inject.";
                await Task.Delay(1000);
                metroLabel3.Text = "Waiting to Inject..";
                await Task.Delay(1000);
                metroLabel3.Text = "Waiting to Inject...";
            }
        }

        #endregion Formload/stuff

        #region ExitButton/Tests

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                if (metroComboBox1.SelectedIndex.Equals(0))
                {
                    MetroMessageBox.Show(this, "This is a sad box", "WTF WHY IDIOT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (metroComboBox1.SelectedIndex.Equals(1))
                {
                    string file = "Hello_world";
                    File.Exists(file);
                    if (File.Exists(file))
                    {
                        Process.Start("Hello_World");
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "The File doesnt Exist", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            if (metroCheckBox1.Checked == false)
            {
                string test = metroTextBox1.Text;
                MessageBox.Show(test, "test");
            }
        }

        #endregion ExitButton/Tests

        #region test

        private async void MetroToggle2_CheckedChanged(object sender, EventArgs e)
        {
            //Was just a fun thing to try probably couldve been done better...
            while (metroToggle2.Checked)
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

                //new Task(() => {
                //    for (int i = 0; i < 15; i++)
                //    {
                //        if (i == 15)
                //        {
                //            i = 0;
                //        }
                //        this.BeginInvoke((MethodInvoker)delegate
                //        {
                //            StyleManager.Style = (MetroColorStyle)i;
                //        });

                //    }
                //}).Start();
            }
        }

        #endregion test

        #region Injector

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            var filedialog = new OpenFileDialog();
            filedialog.ShowDialog();
            var GeileKekse = filedialog.FileName.ToString();

            filedialog.RestoreDirectory = true;
            metroTextBox3.Text = GeileKekse;
        }

        public void MetroButton4_Click(object sender, EventArgs e)
        {
            var path = metroTextBox3.Text;
            var file = File.ReadAllBytes(path);
            if (metroRadioButton1.Checked)
            {
                var injector = new Injector(InjectionMethod.ManualMap, "csgo", path, true);

                injector.InjectDll();
            }

            /*
                string testy = metroTextBox2.Text;
                Process[] processes = Process.GetProcessesByName(testy);

                foreach (Process proces2 in processes)
                {
                int test = proces2.Id;

                var path = metroTextBox3.Text;
                string name1 = metroTextBox2.Text;
                var name = name1;
                var target = Process.GetProcessesByName(name).FirstOrDefault();

                //MessageBox.Show(path, name1);
                var file = File.ReadAllBytes(path);
                var randomiseDllName = false;
                */

            var injector2 = new Injector(InjectionMethod.CreateThread, "csgo", path, true);

            //var dllBaseAddress = injector.InjectDll();

            injector2.InjectDll();

            injector2.HideDllFromPeb();
            //injector.EjectDll();

            // injector.Dispose();
        }

        #endregion Injector

        #region soundplay/uselessList

        public void MetroLabel4_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 10)
            {
                Stream str = Properties.Resources.SoundOfSilence;
                SoundPlayer player = new SoundPlayer(str);
                player.Play();
            }
            metroLabel5.Text = count.ToString();

            //Properties.Settings.Default.Number = count;
            //Properties.Settings.Default.Save();
        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {
            // metroListView1.Columns.Add("ID");
            //metroListView1.Columns.Add("Name");
            string testy = metroTextBox2.Text;
            Process[] processes = Process.GetProcessesByName(testy);
            ListViewItem lstViewItems = null;
            foreach (Process process in processes)
            {
                lstViewItems = new ListViewItem();
                lstViewItems.Text = "Column A";

                lstViewItems.Text = process.Id.ToString();
                lstViewItems.SubItems.Add(process.ProcessName);
                // lstViewItems.SubItems.Add(process.StartTime.ToString());
                metroListView1.Items.Add(lstViewItems);
            }

            //metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion soundplay/uselessList

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
            string kekse = GetIPAddress();

            Clipboard.SetText(kekse);
        }

        private void BT_Connect_Click(object sender, EventArgs e)
        {
            if (IsRunningS)
            {
                var result = MessageBox.Show("You are actually running a Server already. Do you really want to Connect another Person?\nThis Will Close youre own Server.", "2", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == result)
                {
                    server.Stop();
                    client.Connect("localhost", Convert.ToInt32(Port_txt.Text));
                    IsRunningS = false;
                }
                else if (DialogResult.No == result)
                {
                    return;
                }
            }
            else
            {
                server.Start(Convert.ToInt32(Port_txt.Text)); IsRunningS = true;

                System.Windows.Forms.Timer test = new System.Windows.Forms.Timer();
                test.Tick += Test_Tick;
                test.Interval = 1;
                test.Start();
            }
        }

        private int id;

        private void Test_Tick(object sender, EventArgs e)
        {
            Telepathy.Message msg;
            while (server.GetNextMessage(out msg))
            {
                switch (msg.eventType)
                {
                    case Telepathy.EventType.Connected:
                        Console.WriteLine(msg.connectionId + " Connected");
                        id = msg.connectionId;
                        Chat_TextBox.AppendText(Environment.NewLine + msg.connectionId + " Connected");
                        break;

                    case Telepathy.EventType.Data:
                        Console.WriteLine(msg.connectionId + " Data: " + BitConverter.ToString(msg.data));

                        if (!IsRunningS)
                        {
                            Chat_TextBox.AppendText(Environment.NewLine + Encoding.ASCII.GetString(msg.data));
                        }

                        for (int i = 0; i < id + 1; i++)
                        {
                            if (IsRunningS)
                            {
                                server.Send(i, msg.data);
                            }
                        }

                        break;

                    case Telepathy.EventType.Disconnected:
                        Console.WriteLine(msg.connectionId + " Disconnected");
                        Chat_TextBox.AppendText(msg.connectionId + " Disconnected");
                        break;
                }
            }
        }

        private void BT_SendMessage_Click(object sender, EventArgs e)
        {
            Byte[] nice = Encoding.ASCII.GetBytes(Nickname.Text + " : " + Message_Chat.Text);
            client.Send(nice);
            Message_Chat.Text = "";
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            client.Connect(Client_IP.Text, Convert.ToInt32(Port_txt.Text));
            System.Windows.Forms.Timer Client_Tick = new System.Windows.Forms.Timer();
            Client_Tick.Tick += Client_Tick_Tick;
            Client_Tick.Interval = 1;
            Client_Tick.Start();
        }

        private void Client_Tick_Tick(object sender, EventArgs e)
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
                        Chat_TextBox.AppendText(Environment.NewLine + Encoding.ASCII.GetString(msg.data));
                        break;

                    case Telepathy.EventType.Disconnected:
                        Console.WriteLine("Disconnected");
                        break;
                }
            }
        }
    }
}