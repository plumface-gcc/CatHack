using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tesseract;

namespace CatHack
{
    public partial class SaveUserPing : Form
    {
        private bool loop = true;
        private static string userName = Environment.UserName;
        private static string pattern = @"(^[0-9]{2,2}$)";
        private static float userPing; // XDDDDD???

        Regex rgx = new Regex(pattern);

        public SaveUserPing() { }

        public SaveUserPing(Int32 x, Int32 y, Int32 w, Int32 h, Size s)
        {
            InitializeComponent();

            while (loop)
            {
                System.Threading.Thread.Sleep(700);

                Rectangle rectRecurse = new Rectangle(x, y, w, h);
                Bitmap bmpRecurse = new Bitmap(rectRecurse.Width, rectRecurse.Height, PixelFormat.Format32bppArgb);
                Graphics newGraphic = Graphics.FromImage(bmpRecurse);
                newGraphic.CopyFromScreen(rectRecurse.Left, rectRecurse.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
                bmpRecurse.Save(@"C:\Users\" + userName + @"\Documents\recurseImg2.bmp", System.Drawing.Imaging.ImageFormat.Jpeg);
                imageCapture.Image = bmpRecurse;

                var ocr = new TesseractEngine(@"C:\Users\" + userName + @"\Documents\tessdata", "eng", EngineMode.LstmOnly);
                ocr.SetVariable("tessedit_char_whitelist", "0123456789");

                var img = Pix.LoadFromFile(@"C:\Users\" + userName + @"\Documents\recurseImg2.bmp");
                var res = ocr.Process(img, PageSegMode.SingleBlock);

                var final = res.GetText();
                ocr.Dispose();
                bmpRecurse.Dispose();

                if (rgx.IsMatch(final))
                {
                    try
                    {
                        userPing = float.Parse(final);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        public static float getUserPing()
        {
            return userPing;
        }
    }
}
