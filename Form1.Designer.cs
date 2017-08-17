namespace pintApp2
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Red", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Blue", System.Windows.Forms.HorizontalAlignment.Left);
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleGamePlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list_play_players = new System.Windows.Forms.ListView();
            this.cm_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cm_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cm_team = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cm_bullts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.but_set_saveTag = new System.Windows.Forms.Button();
            this.lab_set_rfid_edit = new System.Windows.Forms.TextBox();
            this.but_set_openfile = new System.Windows.Forms.Button();
            this.num_set_tagid = new System.Windows.Forms.NumericUpDown();
            this.lab_set_rfid = new System.Windows.Forms.Label();
            this.but_set_saveas = new System.Windows.Forms.Button();
            this.but_set_save = new System.Windows.Forms.Button();
            this.but_set_reload = new System.Windows.Forms.Button();
            this.but_set_browse = new System.Windows.Forms.Button();
            this.text_set_address = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lab_set_status = new System.Windows.Forms.Label();
            this.but_set_connect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rad_set_promp = new System.Windows.Forms.CheckBox();
            this.cbox_set_ports = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_set_pack = new System.Windows.Forms.RadioButton();
            this.rad_set_bullet = new System.Windows.Forms.RadioButton();
            this.num_set_bulletAmount = new System.Windows.Forms.NumericUpDown();
            this.num_set_initBullets = new System.Windows.Forms.NumericUpDown();
            this.num_set_price = new System.Windows.Forms.NumericUpDown();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tab_profit = new System.Windows.Forms.TabPage();
            this.lab_profig_generalData = new System.Windows.Forms.Label();
            this.tab_players = new System.Windows.Forms.TabPage();
            this.lab_time = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_game_amount = new System.Windows.Forms.Label();
            this.text_game_id = new System.Windows.Forms.TextBox();
            this.but_game_request = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_play_id = new System.Windows.Forms.TextBox();
            this.text_play_name = new System.Windows.Forms.TextBox();
            this.but_play_addBlue = new System.Windows.Forms.Button();
            this.but_play_addRed = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_set_tagid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_set_bulletAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_set_initBullets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_set_price)).BeginInit();
            this.tab_profit.SuspendLayout();
            this.tab_players.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.BackgroundImage")));
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 24);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(1084, 199);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetSessionToolStripMenuItem,
            this.reloadSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // resetSessionToolStripMenuItem
            // 
            this.resetSessionToolStripMenuItem.Name = "resetSessionToolStripMenuItem";
            this.resetSessionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.resetSessionToolStripMenuItem.Text = "&Reset Session";
            this.resetSessionToolStripMenuItem.Click += new System.EventHandler(this.resetSessionToolStripMenuItem_Click);
            // 
            // reloadSettingsToolStripMenuItem
            // 
            this.reloadSettingsToolStripMenuItem.Name = "reloadSettingsToolStripMenuItem";
            this.reloadSettingsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.reloadSettingsToolStripMenuItem.Text = "Re&load Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleGamePlayToolStripMenuItem,
            this.resetTimeToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // toggleGamePlayToolStripMenuItem
            // 
            this.toggleGamePlayToolStripMenuItem.Name = "toggleGamePlayToolStripMenuItem";
            this.toggleGamePlayToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toggleGamePlayToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.toggleGamePlayToolStripMenuItem.Text = "&Play";
            this.toggleGamePlayToolStripMenuItem.Click += new System.EventHandler(this.toggleGamePlayToolStripMenuItem_Click);
            // 
            // resetTimeToolStripMenuItem
            // 
            this.resetTimeToolStripMenuItem.Name = "resetTimeToolStripMenuItem";
            this.resetTimeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.resetTimeToolStripMenuItem.Text = "&Reset Time";
            this.resetTimeToolStripMenuItem.Click += new System.EventHandler(this.resetTimeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // productHelpToolStripMenuItem
            // 
            this.productHelpToolStripMenuItem.Name = "productHelpToolStripMenuItem";
            this.productHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.productHelpToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.productHelpToolStripMenuItem.Text = "Product Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // list_play_players
            // 
            this.list_play_players.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cm_ID,
            this.cm_name,
            this.cm_team,
            this.cm_bullts});
            this.list_play_players.Dock = System.Windows.Forms.DockStyle.Right;
            listViewGroup1.Header = "Red";
            listViewGroup1.Name = "lvgroup_red";
            listViewGroup2.Header = "Blue";
            listViewGroup2.Name = "lvgroup_blue";
            this.list_play_players.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.list_play_players.Location = new System.Drawing.Point(697, 223);
            this.list_play_players.Name = "list_play_players";
            this.list_play_players.Size = new System.Drawing.Size(387, 427);
            this.list_play_players.TabIndex = 1;
            this.list_play_players.UseCompatibleStateImageBehavior = false;
            this.list_play_players.View = System.Windows.Forms.View.Details;
            // 
            // cm_ID
            // 
            this.cm_ID.Text = "ID";
            this.cm_ID.Width = 49;
            // 
            // cm_name
            // 
            this.cm_name.Text = "Name";
            this.cm_name.Width = 135;
            // 
            // cm_team
            // 
            this.cm_team.Text = "Team";
            this.cm_team.Width = 68;
            // 
            // cm_bullts
            // 
            this.cm_bullts.Text = "Bullets";
            this.cm_bullts.Width = 90;
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.groupBox5);
            this.tab_settings.Controls.Add(this.groupBox4);
            this.tab_settings.Controls.Add(this.groupBox3);
            this.tab_settings.Location = new System.Drawing.Point(23, 4);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Size = new System.Drawing.Size(670, 419);
            this.tab_settings.TabIndex = 3;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.but_set_saveTag);
            this.groupBox5.Controls.Add(this.lab_set_rfid_edit);
            this.groupBox5.Controls.Add(this.but_set_openfile);
            this.groupBox5.Controls.Add(this.num_set_tagid);
            this.groupBox5.Controls.Add(this.lab_set_rfid);
            this.groupBox5.Controls.Add(this.but_set_saveas);
            this.groupBox5.Controls.Add(this.but_set_save);
            this.groupBox5.Controls.Add(this.but_set_reload);
            this.groupBox5.Controls.Add(this.but_set_browse);
            this.groupBox5.Controls.Add(this.text_set_address);
            this.groupBox5.Location = new System.Drawing.Point(32, 231);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(610, 141);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RFID/Tag Table";
            // 
            // but_set_saveTag
            // 
            this.but_set_saveTag.Location = new System.Drawing.Point(405, 86);
            this.but_set_saveTag.Name = "but_set_saveTag";
            this.but_set_saveTag.Size = new System.Drawing.Size(138, 23);
            this.but_set_saveTag.TabIndex = 10;
            this.but_set_saveTag.Text = "Save Change";
            this.but_set_saveTag.UseVisualStyleBackColor = true;
            this.but_set_saveTag.Click += new System.EventHandler(this.but_set_saveTag_Click);
            // 
            // lab_set_rfid_edit
            // 
            this.lab_set_rfid_edit.Location = new System.Drawing.Point(405, 33);
            this.lab_set_rfid_edit.Name = "lab_set_rfid_edit";
            this.lab_set_rfid_edit.Size = new System.Drawing.Size(138, 20);
            this.lab_set_rfid_edit.TabIndex = 9;
            this.lab_set_rfid_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lab_set_rfid_edit.Visible = false;
            this.lab_set_rfid_edit.TextChanged += new System.EventHandler(this.lab_set_rfid_edit_TextChanged);
            this.lab_set_rfid_edit.DoubleClick += new System.EventHandler(this.lab_set_rfid_DoubleClick);
            // 
            // but_set_openfile
            // 
            this.but_set_openfile.Location = new System.Drawing.Point(106, 86);
            this.but_set_openfile.Name = "but_set_openfile";
            this.but_set_openfile.Size = new System.Drawing.Size(75, 23);
            this.but_set_openfile.TabIndex = 8;
            this.but_set_openfile.Text = "Open File";
            this.but_set_openfile.UseVisualStyleBackColor = true;
            this.but_set_openfile.Click += new System.EventHandler(this.but_set_openfile_Click);
            // 
            // num_set_tagid
            // 
            this.num_set_tagid.Location = new System.Drawing.Point(405, 61);
            this.num_set_tagid.Name = "num_set_tagid";
            this.num_set_tagid.Size = new System.Drawing.Size(138, 20);
            this.num_set_tagid.TabIndex = 7;
            // 
            // lab_set_rfid
            // 
            this.lab_set_rfid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_set_rfid.Location = new System.Drawing.Point(405, 33);
            this.lab_set_rfid.Name = "lab_set_rfid";
            this.lab_set_rfid.Size = new System.Drawing.Size(138, 23);
            this.lab_set_rfid.TabIndex = 6;
            this.lab_set_rfid.Text = "-";
            this.lab_set_rfid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_set_rfid.DoubleClick += new System.EventHandler(this.lab_set_rfid_DoubleClick);
            // 
            // but_set_saveas
            // 
            this.but_set_saveas.Location = new System.Drawing.Point(268, 86);
            this.but_set_saveas.Name = "but_set_saveas";
            this.but_set_saveas.Size = new System.Drawing.Size(75, 23);
            this.but_set_saveas.TabIndex = 4;
            this.but_set_saveas.Text = "Save As ...";
            this.but_set_saveas.UseVisualStyleBackColor = true;
            this.but_set_saveas.Click += new System.EventHandler(this.but_set_saveas_Click);
            // 
            // but_set_save
            // 
            this.but_set_save.Location = new System.Drawing.Point(187, 86);
            this.but_set_save.Name = "but_set_save";
            this.but_set_save.Size = new System.Drawing.Size(75, 23);
            this.but_set_save.TabIndex = 3;
            this.but_set_save.Text = "Save";
            this.but_set_save.UseVisualStyleBackColor = true;
            this.but_set_save.Click += new System.EventHandler(this.but_set_save_Click);
            // 
            // but_set_reload
            // 
            this.but_set_reload.Location = new System.Drawing.Point(25, 86);
            this.but_set_reload.Name = "but_set_reload";
            this.but_set_reload.Size = new System.Drawing.Size(75, 23);
            this.but_set_reload.TabIndex = 2;
            this.but_set_reload.Text = "Reload";
            this.but_set_reload.UseVisualStyleBackColor = true;
            this.but_set_reload.Click += new System.EventHandler(this.but_set_reload_Click);
            // 
            // but_set_browse
            // 
            this.but_set_browse.Location = new System.Drawing.Point(317, 58);
            this.but_set_browse.Name = "but_set_browse";
            this.but_set_browse.Size = new System.Drawing.Size(26, 23);
            this.but_set_browse.TabIndex = 1;
            this.but_set_browse.Text = "...";
            this.but_set_browse.UseVisualStyleBackColor = true;
            this.but_set_browse.Click += new System.EventHandler(this.but_set_browse_Click);
            // 
            // text_set_address
            // 
            this.text_set_address.Location = new System.Drawing.Point(25, 60);
            this.text_set_address.Name = "text_set_address";
            this.text_set_address.Size = new System.Drawing.Size(300, 20);
            this.text_set_address.TabIndex = 0;
            this.text_set_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_set_address_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lab_set_status);
            this.groupBox4.Controls.Add(this.but_set_connect);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.rad_set_promp);
            this.groupBox4.Controls.Add(this.cbox_set_ports);
            this.groupBox4.Location = new System.Drawing.Point(377, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 191);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Device";
            // 
            // lab_set_status
            // 
            this.lab_set_status.AutoSize = true;
            this.lab_set_status.Location = new System.Drawing.Point(30, 77);
            this.lab_set_status.Name = "lab_set_status";
            this.lab_set_status.Size = new System.Drawing.Size(106, 13);
            this.lab_set_status.TabIndex = 3;
            this.lab_set_status.Text = "Device Status: None";
            // 
            // but_set_connect
            // 
            this.but_set_connect.Location = new System.Drawing.Point(160, 51);
            this.but_set_connect.Name = "but_set_connect";
            this.but_set_connect.Size = new System.Drawing.Size(75, 23);
            this.but_set_connect.TabIndex = 2;
            this.but_set_connect.Text = "Connect";
            this.but_set_connect.UseVisualStyleBackColor = true;
            this.but_set_connect.Click += new System.EventHandler(this.but_set_connect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ports:";
            // 
            // rad_set_promp
            // 
            this.rad_set_promp.AutoSize = true;
            this.rad_set_promp.Checked = true;
            this.rad_set_promp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rad_set_promp.Location = new System.Drawing.Point(33, 126);
            this.rad_set_promp.Name = "rad_set_promp";
            this.rad_set_promp.Size = new System.Drawing.Size(93, 17);
            this.rad_set_promp.TabIndex = 4;
            this.rad_set_promp.Text = "Promp On Exit";
            this.rad_set_promp.UseVisualStyleBackColor = true;
            // 
            // cbox_set_ports
            // 
            this.cbox_set_ports.FormattingEnabled = true;
            this.cbox_set_ports.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.cbox_set_ports.Location = new System.Drawing.Point(33, 53);
            this.cbox_set_ports.Name = "cbox_set_ports";
            this.cbox_set_ports.Size = new System.Drawing.Size(121, 21);
            this.cbox_set_ports.TabIndex = 0;
            this.cbox_set_ports.SelectedIndexChanged += new System.EventHandler(this.cbox_set_ports_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rad_set_pack);
            this.groupBox3.Controls.Add(this.rad_set_bullet);
            this.groupBox3.Controls.Add(this.num_set_bulletAmount);
            this.groupBox3.Controls.Add(this.num_set_initBullets);
            this.groupBox3.Controls.Add(this.num_set_price);
            this.groupBox3.Controls.Add(this.shapeContainer1);
            this.groupBox3.Location = new System.Drawing.Point(32, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 191);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bullets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Initial Bullets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bullets each pack:";
            // 
            // rad_set_pack
            // 
            this.rad_set_pack.AutoSize = true;
            this.rad_set_pack.Checked = true;
            this.rad_set_pack.Location = new System.Drawing.Point(199, 143);
            this.rad_set_pack.Name = "rad_set_pack";
            this.rad_set_pack.Size = new System.Drawing.Size(86, 17);
            this.rad_set_pack.TabIndex = 5;
            this.rad_set_pack.TabStop = true;
            this.rad_set_pack.Text = "each Packet";
            this.rad_set_pack.UseVisualStyleBackColor = true;
            // 
            // rad_set_bullet
            // 
            this.rad_set_bullet.AutoSize = true;
            this.rad_set_bullet.Location = new System.Drawing.Point(199, 119);
            this.rad_set_bullet.Name = "rad_set_bullet";
            this.rad_set_bullet.Size = new System.Drawing.Size(78, 17);
            this.rad_set_bullet.TabIndex = 4;
            this.rad_set_bullet.Text = "each Bullet";
            this.rad_set_bullet.UseVisualStyleBackColor = true;
            // 
            // num_set_bulletAmount
            // 
            this.num_set_bulletAmount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_set_bulletAmount.Location = new System.Drawing.Point(165, 30);
            this.num_set_bulletAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_set_bulletAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_set_bulletAmount.Name = "num_set_bulletAmount";
            this.num_set_bulletAmount.Size = new System.Drawing.Size(120, 20);
            this.num_set_bulletAmount.TabIndex = 3;
            this.num_set_bulletAmount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_set_bulletAmount.ValueChanged += new System.EventHandler(this.num_set_initBullets_ValueChanged);
            // 
            // num_set_initBullets
            // 
            this.num_set_initBullets.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_set_initBullets.Location = new System.Drawing.Point(165, 56);
            this.num_set_initBullets.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_set_initBullets.Name = "num_set_initBullets";
            this.num_set_initBullets.Size = new System.Drawing.Size(120, 20);
            this.num_set_initBullets.TabIndex = 1;
            this.num_set_initBullets.ValueChanged += new System.EventHandler(this.num_set_initBullets_ValueChanged);
            // 
            // num_set_price
            // 
            this.num_set_price.Location = new System.Drawing.Point(84, 130);
            this.num_set_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_set_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_set_price.Name = "num_set_price";
            this.num_set_price.Size = new System.Drawing.Size(79, 20);
            this.num_set_price.TabIndex = 2;
            this.num_set_price.Tag = "";
            this.num_set_price.ThousandsSeparator = true;
            this.num_set_price.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(322, 172);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 8;
            this.lineShape1.X2 = 307;
            this.lineShape1.Y1 = 85;
            this.lineShape1.Y2 = 85;
            // 
            // tab_profit
            // 
            this.tab_profit.Controls.Add(this.lab_profig_generalData);
            this.tab_profit.Location = new System.Drawing.Point(23, 4);
            this.tab_profit.Name = "tab_profit";
            this.tab_profit.Size = new System.Drawing.Size(670, 419);
            this.tab_profit.TabIndex = 2;
            this.tab_profit.Text = "Profit";
            this.tab_profit.UseVisualStyleBackColor = true;
            // 
            // lab_profig_generalData
            // 
            this.lab_profig_generalData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_profig_generalData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_profig_generalData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_profig_generalData.Location = new System.Drawing.Point(10, 320);
            this.lab_profig_generalData.Name = "lab_profig_generalData";
            this.lab_profig_generalData.Size = new System.Drawing.Size(650, 90);
            this.lab_profig_generalData.TabIndex = 0;
            this.lab_profig_generalData.Text = "Please Add Users To View the Game Profit";
            // 
            // tab_players
            // 
            this.tab_players.Controls.Add(this.lab_time);
            this.tab_players.Controls.Add(this.groupBox2);
            this.tab_players.Controls.Add(this.groupBox1);
            this.tab_players.Location = new System.Drawing.Point(23, 4);
            this.tab_players.Name = "tab_players";
            this.tab_players.Padding = new System.Windows.Forms.Padding(3);
            this.tab_players.Size = new System.Drawing.Size(670, 419);
            this.tab_players.TabIndex = 0;
            this.tab_players.Text = "Players";
            this.tab_players.UseVisualStyleBackColor = true;
            // 
            // lab_time
            // 
            this.lab_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_time.Font = new System.Drawing.Font("Quartz", 35.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_time.Location = new System.Drawing.Point(83, 234);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(505, 75);
            this.lab_time.TabIndex = 2;
            this.lab_time.Text = "00:00";
            this.lab_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_time.Click += new System.EventHandler(this.toggleGamePlayToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lab_game_amount);
            this.groupBox2.Controls.Add(this.text_game_id);
            this.groupBox2.Controls.Add(this.but_game_request);
            this.groupBox2.Location = new System.Drawing.Point(361, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Bullets";
            // 
            // lab_game_amount
            // 
            this.lab_game_amount.Location = new System.Drawing.Point(37, 57);
            this.lab_game_amount.Name = "lab_game_amount";
            this.lab_game_amount.Size = new System.Drawing.Size(163, 20);
            this.lab_game_amount.TabIndex = 3;
            this.lab_game_amount.Text = "Bullet Amount: 0";
            this.lab_game_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_game_id
            // 
            this.text_game_id.BackColor = System.Drawing.SystemColors.Window;
            this.text_game_id.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.text_game_id.Location = new System.Drawing.Point(40, 31);
            this.text_game_id.Name = "text_game_id";
            this.text_game_id.Size = new System.Drawing.Size(160, 20);
            this.text_game_id.TabIndex = 0;
            this.text_game_id.Text = "Tag ID";
            this.text_game_id.Enter += new System.EventHandler(this.text_Enter);
            this.text_game_id.Leave += new System.EventHandler(this.text_Leave);
            // 
            // but_game_request
            // 
            this.but_game_request.Location = new System.Drawing.Point(40, 83);
            this.but_game_request.Name = "but_game_request";
            this.but_game_request.Size = new System.Drawing.Size(160, 23);
            this.but_game_request.TabIndex = 2;
            this.but_game_request.Text = "Request";
            this.but_game_request.UseVisualStyleBackColor = true;
            this.but_game_request.Click += new System.EventHandler(this.but_game_request_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.text_play_id);
            this.groupBox1.Controls.Add(this.text_play_name);
            this.groupBox1.Controls.Add(this.but_play_addBlue);
            this.groupBox1.Controls.Add(this.but_play_addRed);
            this.groupBox1.Location = new System.Drawing.Point(83, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Player";
            // 
            // text_play_id
            // 
            this.text_play_id.Location = new System.Drawing.Point(14, 31);
            this.text_play_id.Name = "text_play_id";
            this.text_play_id.Size = new System.Drawing.Size(186, 20);
            this.text_play_id.TabIndex = 0;
            this.text_play_id.Text = "Tag ID";
            this.text_play_id.Enter += new System.EventHandler(this.text_Enter);
            this.text_play_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_play_id_KeyDown);
            this.text_play_id.Leave += new System.EventHandler(this.text_Leave);
            // 
            // text_play_name
            // 
            this.text_play_name.Location = new System.Drawing.Point(14, 57);
            this.text_play_name.Name = "text_play_name";
            this.text_play_name.Size = new System.Drawing.Size(186, 20);
            this.text_play_name.TabIndex = 1;
            this.text_play_name.Text = "Player Name";
            this.text_play_name.Enter += new System.EventHandler(this.text_Enter);
            this.text_play_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_play_name_KeyDown);
            this.text_play_name.Leave += new System.EventHandler(this.text_Leave);
            // 
            // but_play_addBlue
            // 
            this.but_play_addBlue.BackColor = System.Drawing.Color.Blue;
            this.but_play_addBlue.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_play_addBlue.ForeColor = System.Drawing.Color.White;
            this.but_play_addBlue.Location = new System.Drawing.Point(110, 83);
            this.but_play_addBlue.Name = "but_play_addBlue";
            this.but_play_addBlue.Size = new System.Drawing.Size(90, 30);
            this.but_play_addBlue.TabIndex = 3;
            this.but_play_addBlue.Text = "add to Blue";
            this.but_play_addBlue.UseVisualStyleBackColor = false;
            this.but_play_addBlue.Click += new System.EventHandler(this.but_play_add_Click);
            // 
            // but_play_addRed
            // 
            this.but_play_addRed.BackColor = System.Drawing.Color.Red;
            this.but_play_addRed.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_play_addRed.ForeColor = System.Drawing.Color.White;
            this.but_play_addRed.Location = new System.Drawing.Point(14, 83);
            this.but_play_addRed.Name = "but_play_addRed";
            this.but_play_addRed.Size = new System.Drawing.Size(90, 30);
            this.but_play_addRed.TabIndex = 2;
            this.but_play_addRed.Text = "add to Red";
            this.but_play_addRed.UseVisualStyleBackColor = false;
            this.but_play_addRed.Click += new System.EventHandler(this.but_play_add_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tab_players);
            this.tabControl1.Controls.Add(this.tab_profit);
            this.tabControl1.Controls.Add(this.tab_settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 223);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "tag_data.txt";
            this.openFileDialog1.Title = "Open Tag Configuration File";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Save Tag Configuration File";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 650);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.list_play_players);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "PintApp 0.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_settings.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_set_tagid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_set_bulletAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_set_initBullets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_set_price)).EndInit();
            this.tab_profit.ResumeLayout(false);
            this.tab_players.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleGamePlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView list_play_players;
        private System.Windows.Forms.ColumnHeader cm_ID;
        private System.Windows.Forms.ColumnHeader cm_name;
        private System.Windows.Forms.ColumnHeader cm_team;
        private System.Windows.Forms.ColumnHeader cm_bullts;
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.TabPage tab_profit;
        private System.Windows.Forms.Label lab_profig_generalData;
        private System.Windows.Forms.TabPage tab_players;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox text_game_id;
        private System.Windows.Forms.Button but_game_request;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_play_id;
        private System.Windows.Forms.TextBox text_play_name;
        private System.Windows.Forms.Button but_play_addBlue;
        private System.Windows.Forms.Button but_play_addRed;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown num_set_initBullets;
        private System.Windows.Forms.Label lab_game_amount;
        private System.Windows.Forms.NumericUpDown num_set_bulletAmount;
        private System.Windows.Forms.NumericUpDown num_set_price;
        private System.Windows.Forms.CheckBox rad_set_promp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_set_pack;
        private System.Windows.Forms.RadioButton rad_set_bullet;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_set_ports;
        private System.Windows.Forms.Button but_set_connect;
        private System.Windows.Forms.Label lab_set_status;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button but_set_openfile;
        private System.Windows.Forms.NumericUpDown num_set_tagid;
        private System.Windows.Forms.Label lab_set_rfid;
        private System.Windows.Forms.Button but_set_saveas;
        private System.Windows.Forms.Button but_set_save;
        private System.Windows.Forms.Button but_set_reload;
        private System.Windows.Forms.Button but_set_browse;
        private System.Windows.Forms.TextBox text_set_address;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox lab_set_rfid_edit;
        private System.Windows.Forms.Button but_set_saveTag;
    }
}

