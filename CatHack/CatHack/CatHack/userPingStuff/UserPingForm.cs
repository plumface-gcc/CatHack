using System;
using System.Windows.Forms;

namespace CatHack
{
    public partial class UserPingForm : Form
    {
        public UserPingForm()
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
