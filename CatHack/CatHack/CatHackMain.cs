using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatHack
{
    public partial class CatHackMain : Form
    {
        public static bool checkSpaceGlide;
        public static bool checkKiteMode;
        public static bool thresholdCheck;
        public static bool cathackCheck;
        public static string userPing;
        public CatHackMain()
        {
            InitializeComponent();
        }

        public bool getCatHack()
        {
            return cathackCheck;
        }

        public bool getSpaceGlide()
        {
            return checkSpaceGlide;
        }

        public bool getKiteMode()
        {
            return checkKiteMode;
        }

        public bool getThresholdCheck()
        {
            return thresholdCheck;
        }

        public string getUserPing()
        {
            return userPing;
        }

        private void spaceGlideBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSpaceGlideBox.Checked)
            {
                checkSpaceGlide = true;
                checkKiteMode = false;
                thresholdCheck = false;
                checkKiteModeBox.Checked = false;
                thresholdCheckBox.Checked = false;
            }
        }

        private void kiteModeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKiteModeBox.Checked)
            {
                checkKiteMode = true;
                checkSpaceGlide = false;
                thresholdCheck = false;
                checkSpaceGlideBox.Checked = false;
                thresholdCheckBox.Checked = false;
            }
        }

        private void thresholdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (thresholdCheckBox.Checked)
            {
                checkSpaceGlide = false;
                checkKiteMode = true;
                thresholdCheck = true;        
                checkSpaceGlideBox.Checked = false;
                checkKiteModeBox.Checked = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userPing = textBox1.Text;
        }

        private void cathackStart_CheckedChanged(object sender, EventArgs e)
        {
            if (cathackStart.Checked)
            {
                cathackCheck = true;
            }
            else
            {
                cathackCheck = false;
            }
        }
    }
}
