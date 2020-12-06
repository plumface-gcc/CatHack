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
    public partial class CatHack : Form
    {
        public CatHack()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScreenshotArea area = new ScreenshotArea();
            //this.Hide();
            area.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScreenshotArea area = new ScreenshotArea();
            area.Show();
        }
    }
}
