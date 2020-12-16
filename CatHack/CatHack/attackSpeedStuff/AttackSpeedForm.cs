using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

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
