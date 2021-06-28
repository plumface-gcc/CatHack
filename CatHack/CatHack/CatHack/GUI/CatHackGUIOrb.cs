﻿ using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatHack.GUI;
using System.Windows.Forms;

namespace CatHack.GUI
{

    public partial class CatHackGUIOrb : Form
    {
        private static bool orbCheck;
        private static int extraWindup;
        private bool mouseDown;
        private Point offset;

        public CatHackGUIOrb()
        {
            InitializeComponent();
            OrbwalkToggle.IsOn = Properties.Settings.Default.orbToggleIsOn;
            KiteModeToggle.IsOn = Properties.Settings.Default.orbKiteIsOn;
            NormalModeToggle.IsOn = Properties.Settings.Default.orbNormalIsOn;
            RageModeToggle.IsOn = Properties.Settings.Default.orbRageIsOn;
            orbCheck = Properties.Settings.Default.orbCheck;
            extraWindup = Properties.Settings.Default.extraWindup;
            System.Diagnostics.Debug.WriteLine(extraWindup + " | " + orbCheck);
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

        public static int getExtraWindup()
        {
            return extraWindup;
        }

        public static bool getOrbCheck()
        {
            return orbCheck;
        }

        private void KiteModeToggle_sliderValueChanged(object sender, EventArgs e)
        {
            if (KiteModeToggle.IsOn == true)
            {
                NormalModeToggle.IsOn = false;
                RageModeToggle.IsOn = false;
                extraWindup = 3;
            }
        }

        private void NormalModeToggle_sliderValueChanged(object sender, EventArgs e)
        {
            if (NormalModeToggle.IsOn == true)
            {
                KiteModeToggle.IsOn = false;
                RageModeToggle.IsOn = false;
                extraWindup = 7;
            }
        }

        private void RageModeToggle_sliderValueChanged(object sender, EventArgs e)
        {
            if (RageModeToggle.IsOn == true)
            {
                KiteModeToggle.IsOn = false;
                NormalModeToggle.IsOn = false;
                extraWindup = 25;
            }
        }

        private void OrbwalkToggle_sliderValueChanged(object sender, EventArgs e)
        {
            if (OrbwalkToggle.IsOn == true)
            {
                orbCheck = true;
            }
            else
            {
                orbCheck = false;
            }
        }

        private void exitPicBox_MouseClick(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.orbCheck = getOrbCheck();
            Properties.Settings.Default.extraWindup = getExtraWindup();
            Properties.Settings.Default.orbToggleIsOn = OrbwalkToggle.IsOn;
            Properties.Settings.Default.orbNormalIsOn = NormalModeToggle.IsOn;
            Properties.Settings.Default.orbRageIsOn = RageModeToggle.IsOn;
            Properties.Settings.Default.Save();

            CatHackGUI mainForm = new CatHackGUI();
            mainForm.Show();
            this.Hide();
        }
    }
}