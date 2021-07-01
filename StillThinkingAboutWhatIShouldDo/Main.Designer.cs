namespace StillThinkingAboutWhatIShouldDo
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.ColorChanger = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Chat = new MetroFramework.Controls.MetroTabPage();
            this.Port_txt = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Nickname = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Client_IP = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.BT_SendMessage = new MetroFramework.Controls.MetroButton();
            this.Message_Chat = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Chat_TextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.BT_CloseConnection = new MetroFramework.Controls.MetroButton();
            this.BT_Connect = new MetroFramework.Controls.MetroButton();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.chConnectionId = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.StyleManager_Man = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.Chat.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager_Man)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(3, 29);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 19);
            this.metroToggle1.TabIndex = 1;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.MetroToggle1_CheckedChanged);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.Chat);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Padding = new System.Drawing.Point(6, 8);
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(892, 356);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroToggle1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(884, 314);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Settings";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(2, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Dark Mode";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.ColorChanger);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(884, 314);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Dev";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // ColorChanger
            // 
            this.ColorChanger.AutoSize = true;
            this.ColorChanger.Location = new System.Drawing.Point(14, 48);
            this.ColorChanger.Name = "ColorChanger";
            this.ColorChanger.Size = new System.Drawing.Size(80, 19);
            this.ColorChanger.TabIndex = 2;
            this.ColorChanger.Text = "Off";
            this.ColorChanger.UseSelectable = true;
            this.ColorChanger.CheckedChanged += new System.EventHandler(this.ColorChanger_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "CRASHES";
            // 
            // Chat
            // 
            this.Chat.Controls.Add(this.Port_txt);
            this.Chat.Controls.Add(this.Nickname);
            this.Chat.Controls.Add(this.Client_IP);
            this.Chat.Controls.Add(this.metroButton6);
            this.Chat.Controls.Add(this.BT_SendMessage);
            this.Chat.Controls.Add(this.Message_Chat);
            this.Chat.Controls.Add(this.Chat_TextBox);
            this.Chat.Controls.Add(this.BT_CloseConnection);
            this.Chat.Controls.Add(this.BT_Connect);
            this.Chat.HorizontalScrollbarBarColor = true;
            this.Chat.HorizontalScrollbarHighlightOnWheel = false;
            this.Chat.HorizontalScrollbarSize = 10;
            this.Chat.Location = new System.Drawing.Point(4, 38);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(884, 314);
            this.Chat.TabIndex = 5;
            this.Chat.Text = "Chat";
            this.Chat.VerticalScrollbarBarColor = true;
            this.Chat.VerticalScrollbarHighlightOnWheel = false;
            this.Chat.VerticalScrollbarSize = 10;
            // 
            // Port_txt
            // 
            this.Port_txt.AutoCompleteCustomSource = null;
            this.Port_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Port_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Port_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Port_txt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Port_txt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Port_txt.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Port_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Port_txt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Port_txt.Image = null;
            this.Port_txt.IsDerivedStyle = true;
            this.Port_txt.Lines = null;
            this.Port_txt.Location = new System.Drawing.Point(767, 7);
            this.Port_txt.MaxLength = 32767;
            this.Port_txt.Multiline = false;
            this.Port_txt.Name = "Port_txt";
            this.Port_txt.ReadOnly = false;
            this.Port_txt.Size = new System.Drawing.Size(114, 30);
            this.Port_txt.Style = MetroSet_UI.Enums.Style.Light;
            this.Port_txt.StyleManager = null;
            this.Port_txt.TabIndex = 13;
            this.Port_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Port_txt.ThemeAuthor = "Narwin";
            this.Port_txt.ThemeName = "MetroLite";
            this.Port_txt.UseSystemPasswordChar = false;
            this.Port_txt.WatermarkText = "Port";
            // 
            // Nickname
            // 
            this.Nickname.AutoCompleteCustomSource = null;
            this.Nickname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Nickname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Nickname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Nickname.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Nickname.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Nickname.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nickname.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Nickname.Image = null;
            this.Nickname.IsDerivedStyle = true;
            this.Nickname.Lines = null;
            this.Nickname.Location = new System.Drawing.Point(767, 43);
            this.Nickname.MaxLength = 32767;
            this.Nickname.Multiline = false;
            this.Nickname.Name = "Nickname";
            this.Nickname.ReadOnly = false;
            this.Nickname.Size = new System.Drawing.Size(114, 30);
            this.Nickname.Style = MetroSet_UI.Enums.Style.Light;
            this.Nickname.StyleManager = null;
            this.Nickname.TabIndex = 12;
            this.Nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Nickname.ThemeAuthor = "Narwin";
            this.Nickname.ThemeName = "MetroLite";
            this.Nickname.UseSystemPasswordChar = false;
            this.Nickname.WatermarkText = "Your NickName";
            // 
            // Client_IP
            // 
            this.Client_IP.AutoCompleteCustomSource = null;
            this.Client_IP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Client_IP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Client_IP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Client_IP.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Client_IP.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Client_IP.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Client_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Client_IP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Client_IP.Image = null;
            this.Client_IP.IsDerivedStyle = true;
            this.Client_IP.Lines = null;
            this.Client_IP.Location = new System.Drawing.Point(767, 79);
            this.Client_IP.MaxLength = 32767;
            this.Client_IP.Multiline = false;
            this.Client_IP.Name = "Client_IP";
            this.Client_IP.ReadOnly = false;
            this.Client_IP.Size = new System.Drawing.Size(114, 30);
            this.Client_IP.Style = MetroSet_UI.Enums.Style.Light;
            this.Client_IP.StyleManager = null;
            this.Client_IP.TabIndex = 11;
            this.Client_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Client_IP.ThemeAuthor = "Narwin";
            this.Client_IP.ThemeName = "MetroLite";
            this.Client_IP.UseSystemPasswordChar = false;
            this.Client_IP.WatermarkText = "Client/Server-IP";
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.Transparent;
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton6.DisplayFocus = true;
            this.metroButton6.Location = new System.Drawing.Point(767, 115);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(114, 29);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton6.TabIndex = 10;
            this.metroButton6.Text = "Connect To Server IP";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.UseVisualStyleBackColor = false;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // BT_SendMessage
            // 
            this.BT_SendMessage.BackColor = System.Drawing.Color.Transparent;
            this.BT_SendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BT_SendMessage.DisplayFocus = true;
            this.BT_SendMessage.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BT_SendMessage.Location = new System.Drawing.Point(527, 278);
            this.BT_SendMessage.Name = "BT_SendMessage";
            this.BT_SendMessage.Size = new System.Drawing.Size(138, 29);
            this.BT_SendMessage.Style = MetroFramework.MetroColorStyle.White;
            this.BT_SendMessage.TabIndex = 9;
            this.BT_SendMessage.Text = "Send";
            this.BT_SendMessage.UseSelectable = true;
            this.BT_SendMessage.UseVisualStyleBackColor = false;
            this.BT_SendMessage.Click += new System.EventHandler(this.BT_SendMessage_Click);
            // 
            // Message_Chat
            // 
            this.Message_Chat.AutoCompleteCustomSource = null;
            this.Message_Chat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Message_Chat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Message_Chat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Message_Chat.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Message_Chat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Message_Chat.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Message_Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Message_Chat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Message_Chat.Image = null;
            this.Message_Chat.IsDerivedStyle = true;
            this.Message_Chat.Lines = null;
            this.Message_Chat.Location = new System.Drawing.Point(18, 278);
            this.Message_Chat.MaxLength = 32767;
            this.Message_Chat.Multiline = false;
            this.Message_Chat.Name = "Message_Chat";
            this.Message_Chat.ReadOnly = false;
            this.Message_Chat.Size = new System.Drawing.Size(503, 30);
            this.Message_Chat.Style = MetroSet_UI.Enums.Style.Light;
            this.Message_Chat.StyleManager = null;
            this.Message_Chat.TabIndex = 8;
            this.Message_Chat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Message_Chat.ThemeAuthor = "Narwin";
            this.Message_Chat.ThemeName = "MetroLite";
            this.Message_Chat.UseSystemPasswordChar = false;
            this.Message_Chat.WatermarkText = "";
            // 
            // Chat_TextBox
            // 
            this.Chat_TextBox.AutoCompleteCustomSource = null;
            this.Chat_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Chat_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Chat_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Chat_TextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Chat_TextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Chat_TextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Chat_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chat_TextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Chat_TextBox.Image = null;
            this.Chat_TextBox.IsDerivedStyle = true;
            this.Chat_TextBox.Lines = null;
            this.Chat_TextBox.Location = new System.Drawing.Point(18, 13);
            this.Chat_TextBox.MaxLength = 2147483647;
            this.Chat_TextBox.Multiline = true;
            this.Chat_TextBox.Name = "Chat_TextBox";
            this.Chat_TextBox.ReadOnly = true;
            this.Chat_TextBox.Size = new System.Drawing.Size(647, 259);
            this.Chat_TextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.Chat_TextBox.StyleManager = null;
            this.Chat_TextBox.TabIndex = 7;
            this.Chat_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Chat_TextBox.ThemeAuthor = "Narwin";
            this.Chat_TextBox.ThemeName = "MetroLite";
            this.Chat_TextBox.UseSystemPasswordChar = false;
            this.Chat_TextBox.WatermarkText = "";
            // 
            // BT_CloseConnection
            // 
            this.BT_CloseConnection.BackColor = System.Drawing.Color.Transparent;
            this.BT_CloseConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BT_CloseConnection.DisplayFocus = true;
            this.BT_CloseConnection.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BT_CloseConnection.Location = new System.Drawing.Point(763, 282);
            this.BT_CloseConnection.Name = "BT_CloseConnection";
            this.BT_CloseConnection.Size = new System.Drawing.Size(121, 29);
            this.BT_CloseConnection.Style = MetroFramework.MetroColorStyle.White;
            this.BT_CloseConnection.TabIndex = 6;
            this.BT_CloseConnection.Text = "Close Connection";
            this.BT_CloseConnection.UseSelectable = true;
            this.BT_CloseConnection.UseVisualStyleBackColor = false;
            // 
            // BT_Connect
            // 
            this.BT_Connect.BackColor = System.Drawing.Color.Transparent;
            this.BT_Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BT_Connect.DisplayFocus = true;
            this.BT_Connect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BT_Connect.Location = new System.Drawing.Point(763, 225);
            this.BT_Connect.Name = "BT_Connect";
            this.BT_Connect.Size = new System.Drawing.Size(114, 29);
            this.BT_Connect.Style = MetroFramework.MetroColorStyle.White;
            this.BT_Connect.TabIndex = 6;
            this.BT_Connect.Text = "Connect";
            this.BT_Connect.UseSelectable = true;
            this.BT_Connect.UseVisualStyleBackColor = false;
            this.BT_Connect.Click += new System.EventHandler(this.BT_Connect_Click);
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.AutoScroll = true;
            this.metroTabPage5.Controls.Add(this.metroLabel5);
            this.metroTabPage5.Controls.Add(this.metroLabel4);
            this.metroTabPage5.HorizontalScrollbar = true;
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(884, 314);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "About";
            this.metroTabPage5.VerticalScrollbar = true;
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(177, 23);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(16, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 23);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "About : Program";
            // 
            // chConnectionId
            // 
            this.chConnectionId.Text = "IP";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            // 
            // StyleManager_Man
            // 
            this.StyleManager_Man.Owner = this;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(883, 7);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(46, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "X";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(932, 436);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Michael";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.Chat.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager_Man)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroTabControl metroTabControl1;
        public MetroFramework.Controls.MetroToggle metroToggle1;
        public MetroFramework.Components.MetroStyleManager StyleManager_Man;
        public MetroFramework.Controls.MetroTabPage metroTabPage2;
        public MetroFramework.Controls.MetroTabPage metroTabPage3;
        public MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        public MetroFramework.Controls.MetroButton BT_CloseConnection;
        public MetroFramework.Controls.MetroButton BT_Connect;
        public MetroFramework.Controls.MetroButton BT_SendMessage;
        public MetroFramework.Controls.MetroButton metroButton6;
        public MetroSet_UI.Controls.MetroSetTextBox Port_txt;
        public MetroSet_UI.Controls.MetroSetTextBox Client_IP;
        public MetroSet_UI.Controls.MetroSetTextBox Chat_TextBox;
        public MetroSet_UI.Controls.MetroSetTextBox Message_Chat;
        public MetroSet_UI.Controls.MetroSetTextBox Nickname;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroToggle ColorChanger;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public MetroFramework.Controls.MetroTabPage metroTabPage5;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public System.Windows.Forms.Timer timer1;
        public MetroFramework.Controls.MetroTabPage Chat;
        public System.Windows.Forms.ColumnHeader chConnectionId;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.ColumnHeader columnHeader7;
        public System.Windows.Forms.ColumnHeader columnHeader8;
        public System.Windows.Forms.ColumnHeader columnHeader9;
        public System.Windows.Forms.ColumnHeader columnHeader10;
        public System.Windows.Forms.ColumnHeader columnHeader11;
    }
}

