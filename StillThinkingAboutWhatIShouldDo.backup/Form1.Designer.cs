namespace StillThinkingAboutWhatIShouldDo
{
    partial class Form1
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Chat = new MetroFramework.Controls.MetroTabPage();
            this.Nickname = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Client_IP = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.BT_SendMessage = new MetroFramework.Controls.MetroButton();
            this.Message_Chat = new MetroSet_UI.Controls.MetroSetTextBox();
            this.Chat_TextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.BT_CloseConnection = new MetroFramework.Controls.MetroButton();
            this.BT_Connect = new MetroFramework.Controls.MetroButton();
            this.chConnectionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StyleManager_Man = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port_txt = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            this.Chat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager_Man)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(3, 29);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 1;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.MetroToggle1_CheckedChanged);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Maybe",
            "Hello World"});
            this.metroComboBox1.Location = new System.Drawing.Point(664, 14);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "Select something";
            this.metroComboBox1.Size = new System.Drawing.Size(134, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Controls.Add(this.Chat);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 5;
            this.metroTabControl1.Size = new System.Drawing.Size(892, 356);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroCheckBox1);
            this.metroTabPage1.Controls.Add(this.metroTextBox1);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.metroComboBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(884, 317);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(804, 49);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(54, 15);
            this.metroCheckBox1.TabIndex = 7;
            this.metroCheckBox1.Text = "TESTY";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(464, 14);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Write something";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(194, 23);
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Write something";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(804, 14);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(78, 29);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Execzte";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroToggle1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(884, 317);
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
            this.metroTabPage3.Controls.Add(this.metroToggle2);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(884, 317);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Dev";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.Location = new System.Drawing.Point(14, 48);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(80, 17);
            this.metroToggle2.TabIndex = 2;
            this.metroToggle2.Text = "Off";
            this.metroToggle2.UseSelectable = true;
            this.metroToggle2.CheckedChanged += new System.EventHandler(this.MetroToggle2_CheckedChanged);
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
            // metroTabPage4
            // 
            this.metroTabPage4.AutoScroll = true;
            this.metroTabPage4.Controls.Add(this.metroRadioButton1);
            this.metroTabPage4.Controls.Add(this.metroListView1);
            this.metroTabPage4.Controls.Add(this.metroButton5);
            this.metroTabPage4.Controls.Add(this.metroButton3);
            this.metroTabPage4.Controls.Add(this.metroTextBox3);
            this.metroTabPage4.Controls.Add(this.metroLabel3);
            this.metroTabPage4.Controls.Add(this.metroTextBox2);
            this.metroTabPage4.Controls.Add(this.metroButton4);
            this.metroTabPage4.HorizontalScrollbar = true;
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(884, 317);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Injector";
            this.metroTabPage4.VerticalScrollbar = true;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(222, 121);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(87, 15);
            this.metroRadioButton1.TabIndex = 11;
            this.metroRadioButton1.Text = "ManualMap";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(377, 42);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(504, 165);
            this.metroListView1.TabIndex = 10;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "sex1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "sex";
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(377, 213);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(112, 46);
            this.metroButton5.TabIndex = 9;
            this.metroButton5.Text = "Processes";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.MetroButton5_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(104, 50);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(112, 46);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "Browse";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(427, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(377, 13);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.PromptText = "PATH";
            this.metroTextBox3.ReadOnly = true;
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(449, 23);
            this.metroTextBox3.TabIndex = 7;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMark = "PATH";
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(104, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Waiting to Inject...";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(104, 13);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "type .exe name";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(149, 23);
            this.metroTextBox2.TabIndex = 4;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "type .exe name";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(104, 102);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(112, 46);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "Inject";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.MetroButton4_Click);
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
            this.metroTabPage5.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(884, 317);
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
            this.metroLabel4.Click += new System.EventHandler(this.MetroLabel4_Click);
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
            // Nickname
            // 
            this.Nickname.AutoCompleteCustomSource = null;
            this.Nickname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Nickname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Nickname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Nickname.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Nickname.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Nickname.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Nickname.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.Nickname.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Nickname.Image = null;
            this.Nickname.Lines = null;
            this.Nickname.Location = new System.Drawing.Point(767, 43);
            this.Nickname.MaxLength = 32767;
            this.Nickname.Multiline = false;
            this.Nickname.Name = "Nickname";
            this.Nickname.ReadOnly = false;
            this.Nickname.Size = new System.Drawing.Size(114, 30);
            this.Nickname.Style = MetroSet_UI.Design.Style.Light;
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
            this.Client_IP.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.Client_IP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Client_IP.Image = null;
            this.Client_IP.Lines = null;
            this.Client_IP.Location = new System.Drawing.Point(767, 79);
            this.Client_IP.MaxLength = 32767;
            this.Client_IP.Multiline = false;
            this.Client_IP.Name = "Client_IP";
            this.Client_IP.ReadOnly = false;
            this.Client_IP.Size = new System.Drawing.Size(114, 30);
            this.Client_IP.Style = MetroSet_UI.Design.Style.Light;
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
            this.Message_Chat.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.Message_Chat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Message_Chat.Image = null;
            this.Message_Chat.Lines = null;
            this.Message_Chat.Location = new System.Drawing.Point(18, 278);
            this.Message_Chat.MaxLength = 32767;
            this.Message_Chat.Multiline = false;
            this.Message_Chat.Name = "Message_Chat";
            this.Message_Chat.ReadOnly = false;
            this.Message_Chat.Size = new System.Drawing.Size(503, 30);
            this.Message_Chat.Style = MetroSet_UI.Design.Style.Light;
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
            this.Chat_TextBox.Font = new System.Drawing.Font("Segoe WP Light", 10F);
            this.Chat_TextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Chat_TextBox.Image = null;
            this.Chat_TextBox.Lines = null;
            this.Chat_TextBox.Location = new System.Drawing.Point(18, 13);
            this.Chat_TextBox.MaxLength = 2147483647;
            this.Chat_TextBox.Multiline = true;
            this.Chat_TextBox.Name = "Chat_TextBox";
            this.Chat_TextBox.ReadOnly = true;
            this.Chat_TextBox.Size = new System.Drawing.Size(647, 259);
            this.Chat_TextBox.Style = MetroSet_UI.Design.Style.Light;
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
            // 
            // BT_Connect
            // 
            this.BT_Connect.BackColor = System.Drawing.Color.Transparent;
            this.BT_Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BT_Connect.DisplayFocus = true;
            this.BT_Connect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BT_Connect.Location = new System.Drawing.Point(767, 243);
            this.BT_Connect.Name = "BT_Connect";
            this.BT_Connect.Size = new System.Drawing.Size(114, 29);
            this.BT_Connect.Style = MetroFramework.MetroColorStyle.White;
            this.BT_Connect.TabIndex = 6;
            this.BT_Connect.Text = "Connect";
            this.BT_Connect.UseSelectable = true;
            this.BT_Connect.Click += new System.EventHandler(this.BT_Connect_Click);
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
            // Port_txt
            // 
            this.Port_txt.AutoCompleteCustomSource = null;
            this.Port_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Port_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Port_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Port_txt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Port_txt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Port_txt.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Port_txt.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.Port_txt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Port_txt.Image = null;
            this.Port_txt.Lines = null;
            this.Port_txt.Location = new System.Drawing.Point(767, 7);
            this.Port_txt.MaxLength = 32767;
            this.Port_txt.Multiline = false;
            this.Port_txt.Name = "Port_txt";
            this.Port_txt.ReadOnly = false;
            this.Port_txt.Size = new System.Drawing.Size(114, 30);
            this.Port_txt.Style = MetroSet_UI.Design.Style.Light;
            this.Port_txt.StyleManager = null;
            this.Port_txt.TabIndex = 13;
            this.Port_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Port_txt.ThemeAuthor = "Narwin";
            this.Port_txt.ThemeName = "MetroLite";
            this.Port_txt.UseSystemPasswordChar = false;
            this.Port_txt.WatermarkText = "Port";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(932, 436);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Michael";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabPage5.PerformLayout();
            this.Chat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager_Man)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroToggle metroToggle1;
        public MetroFramework.Components.MetroStyleManager StyleManager_Man;
        public MetroFramework.Controls.MetroTabPage metroTabPage2;
        public MetroFramework.Controls.MetroTabPage metroTabPage3;
        public MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        public MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroListView metroListView1;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabPage Chat;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private System.Windows.Forms.ColumnHeader chConnectionId;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        public MetroFramework.Controls.MetroButton BT_CloseConnection;
        public MetroFramework.Controls.MetroButton BT_Connect;
        private MetroSet_UI.Controls.MetroSetTextBox Chat_TextBox;
        public MetroFramework.Controls.MetroButton BT_SendMessage;
        private MetroSet_UI.Controls.MetroSetTextBox Message_Chat;
        public MetroFramework.Controls.MetroButton metroButton6;
        private MetroSet_UI.Controls.MetroSetTextBox Client_IP;
        private MetroSet_UI.Controls.MetroSetTextBox Nickname;
        private MetroSet_UI.Controls.MetroSetTextBox Port_txt;
    }
}

