using CatHack.GUI;
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
    public partial class CatHackGUI : Form
    {
        private bool mouseDown;
        private Point offset;
        
        public CatHackGUI()
        {
            InitializeComponent();

            CatHackGUIOrb orbForm = new CatHackGUIOrb();
            CatHackGUIChampions champForm = new CatHackGUIChampions();
            CatHackGUIPlayer playerForm = new CatHackGUIPlayer();

            int x = (panel5.Size.Width - label1.Size.Width) / 2;
            label1.Location = new Point(x, label1.Location.Y);
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

        private void OrbwalkingPicBox_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((Color)OrbwalkingPicBox.Tag == Color.FromArgb(28, 28, 28))
                {
                    OrbwalkingPicBox.Tag = Color.Cyan;
                }
                else
                {
                    OrbwalkingPicBox.Tag = Color.Cyan;
                }
            }
            catch (NullReferenceException er)
            {
                Console.WriteLine(er.Message);
            }
            orbLabel.ForeColor = Color.Cyan;
            OrbwalkingPicBox.Refresh();
        }

        private void OrbwalkingPicBox_Paint(object sender, PaintEventArgs e)
        {
            if (OrbwalkingPicBox.Tag == null)
            {
                OrbwalkingPicBox.Tag = Color.FromArgb(28, 28, 28);
            }
            ControlPaint.DrawBorder(e.Graphics, this.OrbwalkingPicBox.ClientRectangle, (Color)OrbwalkingPicBox.Tag, ButtonBorderStyle.Solid);
        }

        private void OrbwalkingPicBox_MouseLeave(object sender, EventArgs e)
        {
            if ((Color)OrbwalkingPicBox.Tag == Color.Cyan)
            {
                OrbwalkingPicBox.Tag = Color.FromArgb(28, 28, 28);
            }
            else
            {
                OrbwalkingPicBox.Tag = Color.FromArgb(28, 28, 28);
            }
            orbLabel.ForeColor = Color.FromArgb(120, 120, 120);
            OrbwalkingPicBox.Refresh();
        }

        private void ChampionsPicBox_Paint(object sender, PaintEventArgs e)
        {
            if (ChampionsPicBox.Tag == null)
            {
                ChampionsPicBox.Tag = Color.FromArgb(28, 28, 28);
            }
            ControlPaint.DrawBorder(e.Graphics, this.ChampionsPicBox.ClientRectangle, (Color)ChampionsPicBox.Tag, ButtonBorderStyle.Solid);
        }

        private void ChampionsPicBox_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((Color)ChampionsPicBox.Tag == Color.FromArgb(28, 28, 28))
                {
                    ChampionsPicBox.Tag = Color.Cyan;
                }
                else
                {
                    ChampionsPicBox.Tag = Color.Cyan;
                }
            }
            catch (NullReferenceException er)
            {
                Console.WriteLine(er.Message);
            }
            champLabel.ForeColor = Color.Cyan;
            ChampionsPicBox.Refresh();
        }

        private void ChampionsPicBox_MouseLeave(object sender, EventArgs e)
        {
            if ((Color)ChampionsPicBox.Tag == Color.Cyan)
            {
                ChampionsPicBox.Tag = Color.FromArgb(28, 28, 28);
            }
            else
            {
                ChampionsPicBox.Tag = Color.FromArgb(28, 28, 28);
            }
            champLabel.ForeColor = Color.FromArgb(120, 120, 120);
            ChampionsPicBox.Refresh();
        }

        private void PlayerPicBox_Paint(object sender, PaintEventArgs e)
        {
            if (PlayerPicBox.Tag == null)
            {
                PlayerPicBox.Tag = Color.FromArgb(28, 28, 28);
            }
            ControlPaint.DrawBorder(e.Graphics, this.PlayerPicBox.ClientRectangle, (Color)PlayerPicBox.Tag, ButtonBorderStyle.Solid);
        }

        private void PlayerPicBox_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if ((Color)PlayerPicBox.Tag == Color.FromArgb(28, 28, 28))
                {
                    PlayerPicBox.Tag = Color.Cyan;
                }
                else
                {
                    PlayerPicBox.Tag = Color.Cyan;
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            playerLabel.ForeColor = Color.Cyan;
            PlayerPicBox.Refresh();
        }

        private void PlayerPicBox_MouseLeave(object sender, EventArgs e)
        {
            if ((Color)PlayerPicBox.Tag == Color.Cyan)
            {
                PlayerPicBox.Tag = Color.FromArgb(28, 28, 28);
            }
            else
            {
                PlayerPicBox.Tag = Color.FromArgb(28, 28, 28);
            }
            playerLabel.ForeColor = Color.FromArgb(120, 120, 120);
            PlayerPicBox.Refresh();
        }

        private void OrbwalkingPicBox_MouseClick(object sender, MouseEventArgs e)
        {
            CatHackGUIOrb orbForm = new CatHackGUIOrb();
            orbForm.Show();
            this.Hide();
        }

        private void ChampionsPicBox_MouseClick(object sender, MouseEventArgs e)
        {
            CatHackGUIChampions champForm = new CatHackGUIChampions();
            champForm.Show();
            this.Hide();
        }

        private void PlayerPicBox_MouseClick(object sender, MouseEventArgs e)
        {
            CatHackGUIPlayer playerForm = new CatHackGUIPlayer();
            playerForm.Show();
            this.Hide();
        }
    }
}
