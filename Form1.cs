using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pintApp2.Properties;
using System.Xml;
using ZedGraph;

namespace pintApp2
{
    public partial class MainWindow : Form
    {
        //-- Data Structral Part
        private List<Player> players = new List<Player>();
        private TagBurner tagBurner;
        private ZedGraphControl profitPloter = new ZedGraphControl();
        int initialBullets = 0;
        private string portName = "COM1";
        private bool isConnected = false;
        Player topPlayer = new Player();
        int blueTotalBulletAmoutn = 0;
        int redTotalBulletAmoutn = 0;
        uint gameTimestamp = 0;
        UInt64 appTimestamp = 0;

        GraphPane gPane;
        PointPairList listBlue = new PointPairList();
        PointPairList listRed = new PointPairList();
      
        private int searchByID(int id)
        {
            for (int i = 0; i < players.Count; ++i)
                if (players[i].ID == id)
                    return i;
            return -1;
        }

        private int searchByName(string id)
        {
            for (int i = 0; i < players.Count; ++i)
                if (players[i].Name == id)
                    return i;
            return -1;
        }

        private void completeFields(int i)
        {
            if (i == -1) return;
            text_play_id.Text = text_game_id.Text = players[i].ID.ToString();
            text_play_name.Text = players[i].Name;
            lab_game_amount.Text = "Bullets Amount: " + (players[i].Bullets * (int)num_set_bulletAmount.Value).ToString();
        }

        private void refreshAllResults()
        {
            calculateResults();
            refreshListView();
            refreshTextSummery();
        }

        private void refreshOnRequestBullets(bool isRed)
        {
            calculateResults();
            refreshListView();
            refreshTextSummery();
            addPlotDetail(isRed);
        }

        private void refreshListView()
        {
            list_play_players.Items.Clear();
            foreach (Player p in players)
                list_play_players.Items.Add(new ListViewItem(new string[4]{p.ID.ToString(), p.Name,
                        (p.IsRed?"red":"blue"), (p.Bullets*(int)num_set_bulletAmount.Value).ToString()}, list_play_players.Groups[(p.IsRed ? 0 : 1)]));
        }

        private void calculateResults()
        {
            blueTotalBulletAmoutn = 0;
            redTotalBulletAmoutn = 0;

            foreach (Player p in players)
            {
                if (p.IsRed)
                    redTotalBulletAmoutn += p.Bullets;
                else
                    blueTotalBulletAmoutn += p.Bullets;

                if (topPlayer.Bullets < p.Bullets)
                    topPlayer = p;
            }
        }

        private void addPlotDetail(bool isRed)
        {
            if (isRed)
                listRed.Add(appTimestamp, redTotalBulletAmoutn);
            else
                listBlue.Add(appTimestamp, blueTotalBulletAmoutn);

            profitPloter.AxisChange();
        }

        private void clearPlotings()
        {
            listBlue.Clear();
            listRed.Clear();
            profitPloter.AxisChange();
        }

        private void refreshTextSummery()
        {
            lab_profig_generalData.Text =
                "Total Player Numbers : " + players.Count.ToString() +
                "\nTotal Bullets      : " + ((redTotalBulletAmoutn + blueTotalBulletAmoutn) * (int)num_set_bulletAmount.Value).ToString() + " (" + (redTotalBulletAmoutn + blueTotalBulletAmoutn).ToString() + " Packs)" +
                
                "\nTeam Blue Bullets  : " + (blueTotalBulletAmoutn * (int)num_set_bulletAmount.Value).ToString() + " (" + blueTotalBulletAmoutn.ToString() + " Packs)" +
                "\nTeam Red Bullets   : " + (redTotalBulletAmoutn * (int)num_set_bulletAmount.Value).ToString() + " (" + redTotalBulletAmoutn.ToString() + " Packs)" +
                
                "\nTop Player         : " + topPlayer.Name + " (" + (topPlayer.Bullets * (int)num_set_bulletAmount.Value).ToString() + " Bullets / " + topPlayer.Bullets.ToString() + " Packs)";
        }

        public MainWindow()
        {
            InitializeComponent();

            //-- Intializing ploter
            tab_profit.Controls.Add(profitPloter);
            profitPloter.Location = new Point(10, 10);
            profitPloter.Size = new Size(tab_profit.Width - 20, tab_profit.Height - 120);
            profitPloter.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            gPane = profitPloter.GraphPane;

            isConnected = false;
            lab_set_status.Text = "Device Status : Disconnected.";

            //-- Loading config file
            rad_set_promp.Checked = Settings1.Default.promp;
            rad_set_pack.Checked = Settings1.Default.eachPack;
            rad_set_bullet.Checked = !Settings1.Default.eachPack;
            num_set_price.Value = Settings1.Default.price;
            num_set_initBullets.Value = Settings1.Default.initBullets;
            num_set_bulletAmount.Value = Settings1.Default.bulletsAmount;
            text_set_address.Text = Settings1.Default.tagConfigFile;
            portName = Settings1.Default.port;
            cbox_set_ports.SelectedItem = portName;


            openPort();
            tagBurner = new TagBurner(text_set_address.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup the graph
            gPane.Title.Text = "Profit Plotter";
            gPane.XAxis.Title.Text = "Time";
            gPane.YAxis.Title.Text = "Bullets";
            gPane.AddCurve("Team red", listRed, Color.Red);
            gPane.AddCurve("Team Blue", listBlue, Color.Blue);

            profitPloter.AxisChange();
        }

        private void but_game_request_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                if ((i = searchByID(Convert.ToInt32(text_game_id.Text.Trim()))) == -1)
                    players.Add(new Player(Convert.ToInt32(text_game_id.Text.Trim()), "", initialBullets+1));
                else
                    players[i].Bullets++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            completeFields((i != -1) ? i : players.Count - 1);
            refreshOnRequestBullets(players[(i != -1) ? i : players.Count - 1].IsRed);
        }

        private void but_play_add_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                if ((i = searchByID(Convert.ToInt32(text_play_id.Text.Trim()))) != -1)
                {
                    if (MessageBox.Show("The ID has already been registered.\nDo you want to edit?", "Alread Added...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        System.Windows.Forms.DialogResult.No)
                        return; //-- Ignoring Edit

                    if (text_play_name.Text != "")
                        list_play_players.Items[i].SubItems[1].Text = players[i].Name = text_play_name.Text;
                }
                else
                {
                    players.Add(new Player(Convert.ToInt32(text_play_id.Text.Trim()), text_play_name.Text.Trim(), initialBullets, sender.Equals(but_play_addRed), true));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                refreshAllResults();
            }

            text_play_name.Focus();
        }

        private void text_Enter(object sender, EventArgs e)
        {
            if (sender.Equals(text_play_id) && text_play_id.Text == "Tag ID")
                text_play_id.Text = "";
            if (sender.Equals(text_play_name) && text_play_name.Text == "Player Name")
                text_play_name.Text = "";
            if (sender.Equals(text_game_id) && text_game_id.Text == "Tag ID")
                text_game_id.Text = "";

            TextBox t = (TextBox)sender;
            t.SelectAll();
        }

        private void text_Leave(object sender, EventArgs e)
        {
            if (sender.Equals(text_play_id) && text_play_id.Text == "")
                text_play_id.Text = "Tag ID";
            if (sender.Equals(text_play_name) && text_play_name.Text == "")
                text_play_name.Text = "Player Name";
            if (sender.Equals(text_game_id) && text_game_id.Text == "")
                text_game_id.Text = "Tag ID";
        }

        private void text_play_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter) return;

            int i = 0;
            try
            {
                if ((i = searchByID(Convert.ToInt32(text_play_id.Text.Trim()))) != -1)
                    completeFields(i);
                else
                    MessageBox.Show("No one has registered with this Tag yet!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text_play_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter) return;


            int i = 0;
            try
            {
                if ((i = searchByName(text_play_name.Text.Trim())) != -1)
                    completeFields(i);
                else
                    MessageBox.Show("No one has registered with this Name yet!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (toggleGamePlayToolStripMenuItem.Checked)
            {
                gameTimestamp++;
                refreshGameTimer();
            }

            appTimestamp++;

            if (!isConnected && (appTimestamp % 23 == 0))
                openPort(true);
        }

        private void refreshGameTimer()
        {
            string sec = (gameTimestamp % 60).ToString(),
                min = ((gameTimestamp % 3600) / 60).ToString(),
                hour = ((gameTimestamp % 86400) / 3600).ToString(),
                day = (gameTimestamp / 86400).ToString();

            if (sec.Length < 2) sec = "0" + sec;
            if (min.Length < 2) min = "0" + min;
            min += ":";

            if (hour == "0") hour = "";
            else
            {
                if (hour.Length < 2) hour = "0" + hour;
                hour += ":";
            }

            if (day == "0") day = "";
            else if (day == "1") day = "1 day ";
            else day = day + " day ";

            lab_time.Text = day + hour + min + sec;
        }

        private void toggleGamePlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshGameTimer();
            toggleGamePlayToolStripMenuItem.Checked = !toggleGamePlayToolStripMenuItem.Checked;
        }

        private void resetTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimestamp = 0;
            refreshGameTimer();
        }

        private void resetSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            players.Clear();
            clearPlotings();
            refreshAllResults();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rad_set_promp.Checked && MessageBox.Show("If you close the application, all of your data will be lost!\nDo you confirm?", "Warning...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                this.Activate();
                return;
            }

            Settings1.Default.promp = rad_set_promp.Checked;
            Settings1.Default.eachPack = rad_set_pack.Checked;
            Settings1.Default.price = num_set_price.Value;
            Settings1.Default.initBullets = num_set_initBullets.Value;
            Settings1.Default.bulletsAmount = num_set_bulletAmount.Value;
            Settings1.Default.port = portName;
            Settings1.Default.tagConfigFile = text_set_address.Text;
            Settings1.Default.Save();

            tagBurner.save();

            if (isConnected)
                serialPort1.Close();
        }

        private void num_set_initBullets_ValueChanged(object sender, EventArgs e)
        {
            initialBullets = (int)(-num_set_initBullets.Value/num_set_bulletAmount.Value);
            refreshAllResults();
        }

        private void serialDataProcess(string rfid)
        {
            string tag = string.Empty;
            try
            {
                tag = tagBurner.RFID2tag(rfid);
            }
            catch (NullReferenceException ex)
            {
                if (MessageBox.Show(this, "The given ID is not valid. Do you want to add it to the list?", "Invalid ID", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    return;
                tag = tagBurner.addNewTagRFID(rfid);
            }

            text_game_id.Text = tag;
            but_game_request_Click(this, null);//sender, e);
            lab_set_rfid.Text = lab_set_rfid_edit.Text = rfid;
            num_set_tagid.Value = Convert.ToInt32(tag);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string rfid = TagBurner.convertToValidString(serialPort1.ReadLine());
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        serialDataProcess(rfid);
                    }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool openPort(bool silent=false)
        {
            if (isConnected)
                serialPort1.Close();
            serialPort1.PortName = portName;

            lab_set_status.Text = "Device Status : Connecting...";

            try
            {
                serialPort1.Open();
            }
            catch
            {
                if (!silent)
                    MessageBox.Show("Can not connected to " + portName);
                this.Refresh();
                System.Threading.Thread.Sleep(1000);
                //return false;
            }

            lab_set_status.Text = "Device Status : " + (serialPort1.IsOpen ? "Connected!" : "Disconnected.");
            return (isConnected = serialPort1.IsOpen);
        }

        private void but_set_connect_Click(object sender, EventArgs e)
        {
            if (openPort())
                MessageBox.Show("Connected to " + portName);
        }

        private void cbox_set_ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            portName = cbox_set_ports.SelectedItem.ToString();
        }

        private void but_set_reload_Click(object sender, EventArgs e)
        {
            tagBurner = new TagBurner(text_set_address.Text);
        }

        private void text_set_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter)
                return;

            if (!System.IO.File.Exists(text_set_address.Text))
            {
                MessageBox.Show("No such file exists...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            but_set_reload_Click(sender, e);
        }

        private void but_set_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                text_set_address.Text = openFileDialog1.FileName;
                tagBurner.Address = openFileDialog1.FileName;
                but_set_reload_Click(sender, e);
            }
        }

        private void but_set_openfile_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(text_set_address.Text))
            {
                MessageBox.Show("No such file exists...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tagBurner.Address = text_set_address.Text;
            System.Diagnostics.Process.Start(tagBurner.Address);
        }

        private void but_set_save_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(text_set_address.Text))
            {
                MessageBox.Show("No such file exists...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tagBurner.save(text_set_address.Text);
        }

        private void but_set_saveas_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                text_set_address.Text = saveFileDialog1.FileName;
                tagBurner.save(text_set_address.Text);
            }
        }

        private void lab_set_rfid_DoubleClick(object sender, EventArgs e)
        {
            lab_set_rfid.Visible = !(lab_set_rfid_edit.Visible = !lab_set_rfid_edit.Visible);
        }

        private void lab_set_rfid_edit_TextChanged(object sender, EventArgs e)
        {
            lab_set_rfid.Text = lab_set_rfid_edit.Text;
        }

        private void but_set_saveTag_Click(object sender, EventArgs e)
        {
            tagBurner.changeTag(lab_set_rfid_edit.Text, num_set_tagid.Value.ToString());
        }
    }
}
