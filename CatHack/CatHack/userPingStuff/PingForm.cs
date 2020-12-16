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
    public partial class PingForm : Form
    {
        public PingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScreenshotAreaUserPing area = new ScreenshotAreaUserPing();
            this.Hide();
            area.Show();
        }
    }
}
