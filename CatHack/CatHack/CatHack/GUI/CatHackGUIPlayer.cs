using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatHack.GUI
{
    public partial class CatHackGUIPlayer : Form
    {
        private static char orbwalkKey;
        private bool mouseDown;
        private Point offset;
        private static bool savePingCheck;
        private static bool savedPingCheck;
        private static String userKeycode;
        private static string userName = Environment.UserName;
        private String path = @"C:\Users\" + userName + @"\Documents\userData.txt";
        private static int x, y, xSize, ySize;

        public CatHackGUIPlayer()
        {
            InitializeComponent();
            savePingArea.IsOn = Properties.Settings.Default.savePingCheck;
            savedPingArea.IsOn = Properties.Settings.Default.savedPingCheck;
            userKeycode = Properties.Settings.Default.keycodeInput;
            orbKey.Text = Properties.Settings.Default.keycodeInput;
         
            try
            {
                string[] lines;
                var list = new List<string>();

                var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                lines = list.ToArray();

                x = Int32.Parse(lines[0]);
                y = Int32.Parse(lines[1]);
                xSize = Int32.Parse(lines[2]);
                ySize = Int32.Parse(lines[3]);

                textBox1.Text = lines[0];
                textBox3.Text = lines[1];
                textBox2.Text = lines[2];
                textBox4.Text = lines[3];
            }
            catch (FileNotFoundException err)
            {
                FileStream fs = File.Create(path);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void savedPingArea_sliderValueChanged(object sender, EventArgs e)
        {
            if (savedPingArea.IsOn == true)
            {
                savedPingCheck = !savedPingCheck;
                savePingCheck = false;
                savePingArea.IsOn = false;
            }
        }

        private void savePingArea_sliderValueChanged(object sender, EventArgs e)
        {
            if(savePingArea.IsOn == true)
            {
                savePingCheck = !savePingCheck;
                savedPingCheck = false;
                savedPingArea.IsOn = false;
            }
        }

        public static bool getSavePingCheck()
        {
            return savePingCheck;
        }

        public static bool getSavedPingCheck()
        {
            return savedPingCheck;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.savePingCheck = savePingArea.IsOn;
            Properties.Settings.Default.savedPingCheck = savedPingArea.IsOn;
            Properties.Settings.Default.keycodeInput = orbKey.Text;
            Properties.Settings.Default.Save();

            CatHackGUI mainForm = new CatHackGUI();
            mainForm.Show();
            this.Hide();

            this.SaveWindowPosition();
        }

        private void RestoreWindowPosition()
        {
            if (Properties.Settings.Default.HasSetDefaults)
            {
                this.WindowState = Properties.Settings.Default.WindowState;
                this.Location = Properties.Settings.Default.Location;
                this.Size = Properties.Settings.Default.Size;
            }
        }

        private void SaveWindowPosition()
        {
            Properties.Settings.Default.WindowState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = this.Location;
                Properties.Settings.Default.Size = this.Size;
            }
            else
            {
                Properties.Settings.Default.Location = this.RestoreBounds.Location;
                Properties.Settings.Default.Size = this.RestoreBounds.Size;
            }

            Properties.Settings.Default.HasSetDefaults = true;

            Properties.Settings.Default.Save();
        }

        private void CatHackGUIPlayer_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
        }

        private void orbKey_TextChanged(object sender, EventArgs e)
        {
            try
            {
                orbwalkKey = char.Parse(orbKey.Text);
            }
            catch(FormatException err)
            {
                if (Char.IsWhiteSpace(orbwalkKey))
                {
                    orbKey.Text = "spc";
                }
            }
        }

        public static char getOrbwalkKey()
        {
            return orbwalkKey;
        }
    }
}
