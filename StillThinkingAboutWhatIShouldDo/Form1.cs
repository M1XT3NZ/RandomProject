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

namespace StillThinkingAboutWhatIShouldDo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            this.StyleManager = GEILO;
            
        }
        
        public void something()
        {
            MessageBox.Show("hello", "hello", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

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
            metroToggle1.Checked = Properties.Settings.Default.Thingy;

            metroTabControl1.TabPages.Remove(metroTabPage3);
            string[] commandLineArgs = Environment.GetCommandLineArgs();
            for (int i = 0; i < commandLineArgs.Length; i++)
            {
                if (commandLineArgs[i] == "-iamdev")
                {
                    metroTabControl1.TabPages.Insert(2, metroTabPage3);
                    
                }

            }
        }

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

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroToggle2_CheckedChanged(object sender, EventArgs e)
        {
            //crashes the way im doing it need rework. Maybe crashes because of the style manager but whatever xD
            while (metroToggle2.Checked)
            {
                GEILO.Style = MetroColorStyle.Default;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Black;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.White;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Silver;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Blue;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Green;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Lime;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Orange;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Brown;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Pink;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Magenta;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Purple;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Red;
                Thread.Sleep(1000);
                GEILO.Style = MetroColorStyle.Yellow;

            }
        }

        private void MetroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
