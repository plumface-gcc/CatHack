using IronOcr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatHack
{
    public partial class SaveUserPing : Form
    {
        private bool loop = true;
        private static string userName = Environment.UserName;
        private static string pattern = @"(^[0-9]{1,3}$)";
        private int count = 1;
        private String userPing;

        Regex rgx = new Regex(pattern);

        public SaveUserPing(){}

        public SaveUserPing(Int32 x, Int32 y, Int32 w, Int32 h, Size s)
        {
            InitializeComponent();

            while (loop)
            {
                Rectangle rectRecurse = new Rectangle(x, y, w, h);
                Bitmap bmpRecurse = new Bitmap(rectRecurse.Width, rectRecurse.Height, PixelFormat.Format32bppArgb);
                Graphics newGraphic = Graphics.FromImage(bmpRecurse);
                newGraphic.CopyFromScreen(rectRecurse.Left, rectRecurse.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
                bmpRecurse.Save(@"C:\Users\" + userName + @"\Documents\recurseImg2.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                imageCapture.Image = bmpRecurse;

                var output = new IronTesseract();

                output.Configuration.PageSegmentationMode = TesseractPageSegmentationMode.SingleBlock;
                output.Configuration.WhiteListCharacters = "0123456789.";

                var input = new OcrInput(@"C:\Users\" + userName + @"\Documents\recurseImg2.jpeg");
                input = input.EnhanceResolution();

                var result = output.Read(input);
                var final = result.Text;

                if (rgx.IsMatch(final))
                {
                    //Console.WriteLine(final + "    " + count);

                    bmpRecurse.Dispose();
                    System.IO.File.Delete(@"C:\Users\" + userName + @"\Documents\recurseImg2.jpeg");

                    userPing = final;
                }
                else
                {
                    bmpRecurse.Dispose();
                    System.IO.File.Delete(@"C:\Users\" + userName + @"\Documents\recurseImg2.jpeg");
                }
            }
        }

        public int getUserPing()
        {
            return Convert.ToInt32(userPing);
        }
    }
}
