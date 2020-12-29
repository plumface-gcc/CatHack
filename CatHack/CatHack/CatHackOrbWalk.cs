using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CatHack
{
    class CatHackOrbWalk
    {
        private static short keyState;
        //private static short keyStateChamp;
        private static int userPing;
        private static float userPingFloat;

        private static float attackSpeed;
        private static float tAttackCooldown;
        private static float tAttackWindup;

        private static float WindupPercent;
        private static float bWindupTime;
        private static float cAttackTime;

        private static readonly int VK_SPACE = 0x20;
        private static readonly int VK_MOUSE4 = 0x05;
        private static readonly int VK_MOUSE5 = 0x06;
        private static readonly int VK_V = 0x56;
        private static readonly int VK_C = 0x43;
        private static readonly int VK_G = 0x47;
        private static readonly int VK_X = 0x58;
        private static readonly int VK_Q = 0x51;
        private static readonly int VK_1 = 0x30;

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, String lpWindowName);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern uint RegisterWindowMessage(string lpString);

        /// <summary>
        /// Handles calculating attack speed cooldown and time.
        /// Kite Mode = (current user ping + 20, dps loss of ~300) 
        /// Space Glide Mode = (current user ping only, dps loss of ~200)
        /// </summary>
        [STAThread]
        public static void OrbWalk()
        {
            CatHackMain cathack = new CatHackMain();
            SaveAttackSpeed attkSpeed = new SaveAttackSpeed();
            SaveUserPing savePing = new SaveUserPing();

            if (cathack.getUserKeycode() == "0x05")
            {
                keyState = GetAsyncKeyState(VK_MOUSE4);
            }
            if (cathack.getUserKeycode() == "0x06")
            {
                keyState = GetAsyncKeyState(VK_MOUSE5);
            }
            if (cathack.getUserKeycode() == "0x56")
            {
                keyState = GetAsyncKeyState(VK_V);
            }
            if (cathack.getUserKeycode() == "0x43")
            {
                keyState = GetAsyncKeyState(VK_C);
            }
            if (cathack.getUserKeycode() == "0x47")
            {
                keyState = GetAsyncKeyState(VK_G);
            }
            if (cathack.getUserKeycode() == "0x58")
            {
                keyState = GetAsyncKeyState(VK_X);
            } 
            if (cathack.getUserKeycode() == "0x20")
            {
                keyState = GetAsyncKeyState(VK_SPACE);
            }

            //keyStateChamp = GetAsyncKeyState(VK_Q);

            //bool keyIsPressedTest = ((keyStateChamp >> 15) & 0x0001) == 0x0001;
            //bool unprocessedPressTest = ((keyStateChamp >> 0) & 0x0001) == 0x0001;
            bool keyIsPressed = ((keyState >> 15) & 0x0001) == 0x0001;
            bool unprocessedPress = ((keyState >> 0) & 0x0001) == 0x0001;

            try
            {
                if (keyIsPressed && cathack.getCatHack()) // If bound key is pressed AND cathack checkbox is checked
                {

                    userPingFloat = savePing.getUserPing();
                    attackSpeed = attkSpeed.getAttackSpeed();
                    Console.WriteLine(attackSpeed + " | " + userPingFloat);

                    userPing = (int)userPingFloat;

                    tAttackCooldown = (1 / attackSpeed) * 1000;
                    int tAttackCooldownFinal = Convert.ToInt32(tAttackCooldown);

                    float champWindupPercent = cathack.getWindupPercent();
                    float champBaseWindupTime = cathack.getBaseWindupTime();
                    float champWindupModifier = cathack.getWindupModifier();
                   
                    cAttackTime = 1 / attackSpeed;
                    WindupPercent = (champWindupPercent) / 100;
                    bWindupTime = (1 / champBaseWindupTime) * WindupPercent;
                    tAttackWindup = bWindupTime + ((cAttackTime * WindupPercent) - bWindupTime) * champWindupModifier;                  

                    tAttackWindup = tAttackWindup * 1000;

                    int tAttackWindupFinal = Convert.ToInt32(tAttackWindup);

                    KeyboardOut keyboard = new KeyboardOut();

                    /*
                    if (cathack.getSelectedChampion() == "Vayne" && keyIsPressedTest)
                    {
                        Console.WriteLine("xD");
                        System.Threading.Thread.Sleep(100);
                    }*/

                    keyboard.SendKeyDown(KeyboardOut.ScanCodeShort.KEY_A);
                    keyboard.SendKeyUp(KeyboardOut.ScanCodeShort.KEY_A);

                    if (cathack.getKalistaExploit() == true && attackSpeed > 2.50)
                    {
                        System.Threading.Thread.Sleep(userPing + 3); 
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(tAttackCooldownFinal); 
                    }

                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);

                    if (cathack.getSpaceGlide() == true) // if only spaceglide is checked
                    {
                        System.Threading.Thread.Sleep(userPing + 20); 
                    }

                    if (cathack.getKiteMode() == true && cathack.getThresholdCheck() == false)  // if kite mode is checked AND Orbwalk threshold is not checked
                    {
                        System.Threading.Thread.Sleep(tAttackWindupFinal); //Kite mode 
                    }

                    if (cathack.getKiteMode() == true && cathack.getThresholdCheck() == true) // if kite mode is checked AND Orbwalk threshold is checked
                    {
                        if (attackSpeed > 2.50)
                        {
                            System.Threading.Thread.Sleep(userPing); //Spaceglide mode 
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(tAttackWindupFinal); //Kite mode 
                        }
                    }

                    tAttackCooldown = 0;
                    cAttackTime = 0;
                    WindupPercent = 0;
                    bWindupTime = 0;
                    tAttackCooldownFinal = 0;
                    tAttackWindupFinal = 0;
                    attackSpeed = 0;
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
