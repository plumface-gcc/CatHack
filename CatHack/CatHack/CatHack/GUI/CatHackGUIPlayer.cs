using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatHack.GUI
{
    public partial class CatHackGUIPlayer : Form
    {
        private bool mouseDown;
        private Point offset;
        private static bool savePingCheck;
        private static bool savedPingCheck;
        private static String userKeycode;

        public CatHackGUIPlayer()
        {
            InitializeComponent();
            savePingArea.IsOn = Properties.Settings.Default.savePingCheck;
            savedPingArea.IsOn = Properties.Settings.Default.savedPingCheck;
            userKeycode = Properties.Settings.Default.keycodeInput;
            textBox1.Text = Properties.Settings.Default.keycodeInput;
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
            Properties.Settings.Default.keycodeInput = textBox1.Text;
            Properties.Settings.Default.Save();

            CatHackGUI mainForm = new CatHackGUI();
            mainForm.Show();
            this.Hide();
        }

    }
}
