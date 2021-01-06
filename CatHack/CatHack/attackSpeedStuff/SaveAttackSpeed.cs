using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using Tesseract;

namespace CatHack
{
    public partial class SaveAttackSpeed : Form
    {
        private bool loop = true;
        private static string pattern = @"([1-9]+[.])\w+";
        private static string userName = Environment.UserName;
        private static float attackSpeed;

        Regex rgx = new Regex(pattern);

        public SaveAttackSpeed() {}

        public SaveAttackSpeed(Int32 x, Int32 y, Int32 w, Int32 h, Size s)
        {
            InitializeComponent();

            while (loop)
            {
                System.Threading.Thread.Sleep(1000);

                Rectangle rectRecurse = new Rectangle(x, y, w, h);
                Bitmap bmpRecurse = new Bitmap(rectRecurse.Width, rectRecurse.Height, PixelFormat.Format32bppArgb);
                Graphics newGraphic = Graphics.FromImage(bmpRecurse);
                newGraphic.CopyFromScreen(rectRecurse.Left, rectRecurse.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
                bmpRecurse.Save(@"C:\Users\" + userName + @"\Documents\recurseImg.bmp", System.Drawing.Imaging.ImageFormat.Jpeg);
                imageCapture.Image = bmpRecurse;

                var ocr = new TesseractEngine(@"C:\Users\" + userName + @"\Documents\tessdata", "eng", EngineMode.TesseractOnly);
                ocr.SetVariable("tessedit_char_whitelist", "0123456789.");

                var img = Pix.LoadFromFile(@"C:\Users\" + userName + @"\Documents\recurseImg.bmp");
                var res = ocr.Process(img);

                var final = res.GetText();
                ocr.Dispose();
                bmpRecurse.Dispose();

                if (rgx.IsMatch(final))
                {
                    try
                    {
                        attackSpeed = float.Parse(final);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        public float getAttackSpeed()
        {
            return attackSpeed;
        }
    }
}
