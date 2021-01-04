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
        private static string pattern = @"(^[0-9]{2,2}$)";
        private static float userPing; // XDDDDD???

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
                output.Configuration.WhiteListCharacters = "0123456789";

                var input = new OcrInput(@"C:\Users\" + userName + @"\Documents\recurseImg2.jpeg");
                input = input.EnhanceResolution();

                var result = output.Read(input);
                var final = result.Text;

                if (rgx.IsMatch(final))
                {
                    bmpRecurse.Dispose();
                    input.Dispose();
                    System.IO.File.Delete(@"C:\Users\" + userName + @"\Documents\recurseImg2.jpeg");

                    try
                    {
                        userPing = float.Parse(final);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    bmpRecurse.Dispose();
                    input.Dispose();
                    System.IO.File.Delete(@"C:\Users\" + userName + @"\Documents\recurseImg2.jpeg");
                }
            }
        }

        public float getUserPing()
        {
            return userPing;
        }
    }
}
