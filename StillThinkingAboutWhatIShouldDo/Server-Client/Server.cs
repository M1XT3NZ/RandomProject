using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StillThinkingAboutWhatIShouldDo.Server_Client
{
    public static class Server
    {
        private static Telepathy.Server server = new Telepathy.Server();
        private static Telepathy.Client client = Server_Client.TClient.GetClient();
        private static bool IsRunningS = false;
        private static Form1 _form;

        public static void StartServer()
        {
            switch (IsRunningS)
            {
                case true:
                    var result = MessageBox.Show("You are actually running a Server. Do you really want to Connect another Person?\nThis Will Close youre own Server.", "2", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult.Yes == result)
                    {
                        server.Stop();
                        client.Connect(_form.Client_IP.Text, Convert.ToInt32(_form.Port_txt.Text));
                        IsRunningS = false;
                    }
                    else if (DialogResult.No == result)
                    {
                        return;
                    }
                    break;

                case false:
                    server.Start(Convert.ToInt32(_form.Port_txt.Text)); IsRunningS = true;

                    Timer test = new Timer();
                    test.Tick += Test_Tick;
                    test.Interval = 1;
                    test.Start();
                    break;
            }
        }

        private static void Test_Tick(object sender, EventArgs e)
        {
        }
    }
}