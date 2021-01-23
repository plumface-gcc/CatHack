using System;
using System.Windows.Forms;

namespace CatHack
{
    public partial class AttackSpeedForm : Form
    {
        public AttackSpeedForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScreenshotAreaAttackSpeed area = new ScreenshotAreaAttackSpeed();
            this.Hide();
            area.Show();
        }
    }
}
