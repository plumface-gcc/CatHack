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

namespace CatHack
{
    public partial class SaveImage : Form
    {

        public bool loop = true;
        public int count = 1;
        public static string pattern = @"([1-9]+[.])\w+";
        public static float tAttackCooldown;
        public static float tAttackWindup;
        public static float baseAttackWindup;
        public static float attackSpeed;

        public static float cAttackTime;
        public static float WindupPercent;
        public static float bWindupTime;
        public static float WindupModifier;

        Regex rgx = new Regex(pattern);

        public SaveImage(Int32 x, Int32 y, Int32 w, Int32 h, Size s)
        {
            InitializeComponent();

            while (loop)
            {
                Rectangle rectRecurse = new Rectangle(x, y, w, h);
                Bitmap bmpRecurse = new Bitmap(rectRecurse.Width, rectRecurse.Height, PixelFormat.Format32bppArgb);
                Graphics newGraphic = Graphics.FromImage(bmpRecurse);
                newGraphic.CopyFromScreen(rectRecurse.Left, rectRecurse.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
                bmpRecurse.Save(@"D:\Users\Maks Klimenko\Documents\recurseImg.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                imageCapture.Image = bmpRecurse;

                var output = new IronTesseract();

                output.Configuration.PageSegmentationMode = TesseractPageSegmentationMode.SingleBlock;
                output.Configuration.WhiteListCharacters = "0123456789.";

                var input = new OcrInput(@"D:\Users\Maks Klimenko\Documents\recurseImg.jpeg");

                input = input.EnhanceResolution();
                //input = input.DeNoise();

                var result = output.Read(input);
                var final = result.Text;
      
                if (rgx.IsMatch(final))
                {
                    Console.WriteLine(final + "    " + count);

                    count += 1;

                    Output(final);

                    System.Threading.Thread.Sleep(50);

                    bmpRecurse.Dispose();
                    System.IO.File.Delete(@"D:\Users\Maks Klimenko\Documents\recurseImg.jpeg");

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
                    System.IO.File.Delete(@"D:\Users\Maks Klimenko\Documents\recurseImg.jpeg");
                }
            }
        }

        public static void Output(string input)
        {
            CatHack catHackForm = new CatHack();

            catHackForm.attackSpeedBox.Text = input;
        }

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, String lpWindowName);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]

        static extern uint RegisterWindowMessage(string lpString);
        private static readonly int VK_SNAPSHOT = 0x20; //This is the space key.

        /// <summary>
        /// Handles calculating attack speed cooldown and time.
        /// </summary>
        public static void OrbWalkTest(object sender, EventArgs e)
        {
            short keyState = GetAsyncKeyState(VK_SNAPSHOT);
            bool spaceKeyIsPressed = ((keyState >> 15) & 0x0001) == 0x0001;
            bool unprocessedPress = ((keyState >> 0) & 0x0001) == 0x0001;

            try
            {
                if (spaceKeyIsPressed)
                {
                    CatHackMain cathack = new CatHackMain();
                    tAttackCooldown = (1 / attackSpeed) * 1000;
                    int tAttackCooldownFinal = Convert.ToInt32(tAttackCooldown);

                    cAttackTime = 1 / attackSpeed;
                    WindupPercent = 17.544f / 100;
                    bWindupTime = (1 / 0.658f) * WindupPercent;
                    tAttackWindup = bWindupTime + ((cAttackTime * WindupPercent) - bWindupTime);

                    tAttackWindup = tAttackWindup * 1000;

                    int tAttackWindupFinal = Convert.ToInt32(tAttackWindup);

                    Keyboard keyboard = new Keyboard();

                    keyboard.SendKeyDown(Keyboard.ScanCodeShort.KEY_A);
                    keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_A);
                    System.Threading.Thread.Sleep(tAttackCooldownFinal);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);

                    if(cathack.getSpaceGlide() == true)
                    {
                        System.Threading.Thread.Sleep(int.Parse(cathack.getUserPing())); //Spaceglide mode (current user ping only, dps loss of ~200)
                    }

                    if(cathack.getKiteMode() == true && cathack.getThresholdCheck() == false)
                    {
                        int delayAndPing = int.Parse(cathack.getUserPing());
                        int finalDelay = delayAndPing + 20;
                        System.Threading.Thread.Sleep(finalDelay); //Kite mode (current user ping + 20, dps loss of ~300)   
                    }

                    if(cathack.getKiteMode() == true && cathack.getThresholdCheck() == true)
                    {
                        if (attackSpeed > 2.50)
                        {                       
                            System.Threading.Thread.Sleep(int.Parse(cathack.getUserPing())); //Spaceglide mode (current user ping only, dps loss of ~200)
                        }
                        else
                        {
                            int delayAndPing = int.Parse(cathack.getUserPing());
                            int finalDelay = delayAndPing + 20;
                            System.Threading.Thread.Sleep(finalDelay); //Kite mode (current user ping + 20, dps loss of ~300)    
                        }
                    }

                    tAttackCooldown = 0;
                    cAttackTime = 0;
                    WindupPercent = 0;
                    bWindupTime = 0;
                    tAttackCooldownFinal = 0;
                    tAttackWindupFinal = 0;
                }
            }

            catch (DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (OverflowException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
