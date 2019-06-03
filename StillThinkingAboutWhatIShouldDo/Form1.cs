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

namespace StillThinkingAboutWhatIShouldDo
{
    
    public partial class Form1 : MetroForm
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();

            this.StyleManager = GEILO;
            //GEILO is obviously the style manager from the MetroFramework :D
            
        }

        #region Formload/stuff
        public void something()
        {
            MessageBox.Show("hello", "hello", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void MetroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked)
            {

                GEILO.Theme = MetroThemeStyle.Dark;
                Properties.Settings.Default.Thingy = true;
                Properties.Settings.Default.Save();
                //Mecha.Theme = MetroThemeStyle.Dark;
                //GEILO.Style = MetroColorStyle.Black;
            }
            if (metroToggle1.Checked == false)
            {

                GEILO.Theme = MetroThemeStyle.Light;
                Properties.Settings.Default.Thingy = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            WebClient death = new WebClient();
            var ping = new System.Net.NetworkInformation.Ping();
            ping.Send("www.tulexnow.de");               
            var result = ping.Send("www.tulexnow.de");

            if (result.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                MessageBox.Show("","hi");
            }

            metroToggle1.Checked = Properties.Settings.Default.Thingy;


            count = Properties.Settings.Default.Number;
            metroLabel5.Text = Properties.Settings.Default.Number.ToString();
            //Properties.Settings.Default.Number;
            danke();


           // metroTabControl1.TabPages.Remove(metroTabPage4);
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
        async void danke()
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
        #endregion

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
                        MetroMessageBox.Show(this,"The File doesnt Exist", "ATTENTION", MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
        #endregion

        #region test
        private async void MetroToggle2_CheckedChanged(object sender, EventArgs e)
        {
            //Was just a fun thing to try probably couldve been done better...
            while (metroToggle2.Checked)
            {
                GEILO.Style = MetroColorStyle.Default;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Black;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.White;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Silver;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Blue;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Green;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Lime;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Orange;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Brown;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Pink;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Magenta;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Purple;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Red;
                await Task.Delay(500);
                GEILO.Style = MetroColorStyle.Yellow;

            }
        }
        #endregion

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


            var path = metroTextBox3.Text;
            var file = File.ReadAllBytes(path);
            var injector = new Injector(InjectionMethod.CreateThread, "csgo", path, true);

                //var dllBaseAddress = injector.InjectDll();

            injector.InjectDll();

                // injector.HideDllFromPeb();
                //injector.EjectDll();

               // injector.Dispose();

           
        }
        #endregion

        /*
        private void MetroButton3_Click(object sender, EventArgs e)
        {
            var filedialog = new OpenFileDialog();
            filedialog.ShowDialog();
            var GeileKekse = filedialog.FileName.ToString();

            filedialog.RestoreDirectory = true;
            metroTextBox3.Text = GeileKekse;
        }
        */
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
        #endregion



        public void SetUser_Click(object sender, EventArgs e)
        {
            var User = UserNameBox.Text;

            Username.Text = User;
        }
        public void MetroButton6_Click(object sender, EventArgs e)
        {
            var message = ChatboxMessage.Text;
            var User = Username.Text;


            Chatbox.AppendText(User + " : " + message + Environment.NewLine);
            ChatboxMessage.Text = "";


        }


    }
}
