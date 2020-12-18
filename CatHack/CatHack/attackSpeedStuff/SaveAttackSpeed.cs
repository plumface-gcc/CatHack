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
using tessnet2;
using IronOcr;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;

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

                Rectangle rectRecurse = new Rectangle(x, y, w, h);
                Bitmap bmpRecurse = new Bitmap(rectRecurse.Width, rectRecurse.Height, PixelFormat.Format32bppArgb);
                Graphics newGraphic = Graphics.FromImage(bmpRecurse);
                newGraphic.CopyFromScreen(rectRecurse.Left, rectRecurse.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
                bmpRecurse.Save(@"C:\Users\" + userName + @"\Documents\recurseImg.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                imageCapture.Image = bmpRecurse;

                var output = new IronTesseract();

                output.Configuration.PageSegmentationMode = TesseractPageSegmentationMode.SingleBlock;
                output.Configuration.WhiteListCharacters = "0123456789.";

                var input = new OcrInput(@"C:\Users\" + userName + @"\Documents\recurseImg.jpeg");

                input = input.EnhanceResolution();
                //input = input.DeNoise();

                var result = output.Read(input);
                var final = result.Text;
      
                if (rgx.IsMatch(final))
                {
                    //Console.WriteLine(final + "    " + count);

                    //count += 1;

                    bmpRecurse.Dispose();
                    System.IO.File.Delete(@"C:\Users\" + userName + @"\Documents\recurseImg.jpeg");

                    try
                    {
                        attackSpeed = float.Parse(final);
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    bmpRecurse.Dispose();
                    System.IO.File.Delete(@"C:\Users\" + userName + @"\Documents\recurseImg.jpeg");
                }
            }
        }
        public float getAttackSpeed()
        {
            return attackSpeed;
        }
    }
}
