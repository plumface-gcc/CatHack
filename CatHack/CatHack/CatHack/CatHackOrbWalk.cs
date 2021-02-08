using CatHack.modules;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CatHack
{
    class CatHackOrbWalk
    {
        private static short keyState;
        private static int userPing;
        private static int LastAATick;
        private static int LastAATick2;
        private static float userPingFloat;
        private static int LastMoveCommandT;
        private static bool IsOrbAttackable = true;

        private static float attackSpeed;
        private static float tAttackCooldown;
        private static float tAttackWindup;

        private static float WindupPercent;
        private static float bWindupTime;
        private static float cAttackTime;

        private static Point LastMovePoint;

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        /// <summary>
        /// Handles calculating the current champion's attack windup
        /// </summary>
        /// <returns>tAttackWindupFinal</returns>
        public static int getAttackWindup()
        {
            CatHackMain cathack = new CatHackMain();

            attackSpeed = LocalPlayer.GetAttackSpeed();

            userPing = (int)userPingFloat;
            tAttackCooldown = (1 / attackSpeed) * 1000;

            try
            {
                int tAttackCooldownFinal = Convert.ToInt32(tAttackCooldown);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            float champWindupPercent = cathack.getWindupPercent();
            float champBaseWindupTime = cathack.getBaseWindupTime();
            float champWindupModifier = cathack.getWindupModifier();

            cAttackTime = 1 / attackSpeed;
            WindupPercent = (champWindupPercent) / 100;
            bWindupTime = (1 / champBaseWindupTime) * WindupPercent;
            tAttackWindup = bWindupTime + ((cAttackTime * WindupPercent) - bWindupTime) * champWindupModifier;

            tAttackWindup *= 1000;

            int tAttackWindupFinal = Convert.ToInt32(tAttackWindup);

            return tAttackWindupFinal;
        }

        public static int getAttackWindupTest()
        {
            CatHackMain cathack = new CatHackMain();
            float champWindupPercent = cathack.getWindupPercent();

            int calc = (int)((1 / LocalPlayer.GetAttackSpeed() * 1000) * champWindupPercent);

            return calc;
        }

        public static int getAttackDelay()
        {
            return (int)(LocalPlayer.GetAttackSpeed() / 1000);
        }

        public static bool CanAttack()
        {
            return LastAATick + getAttackDelay() + SaveUserPing.getUserPing() / 2 < Environment.TickCount;
            //return Environment.TickCount + (SaveUserPing.getUserPing() / 2) + 25 >= LastAATick + (getAttackDelay() * 1000);
        }

        public static bool CanMove()
        {
            return LastMoveCommandT < Environment.TickCount;
        }

        /// <summary>
        /// Handles moving the mouse and sending keystrokes.
        /// </summary>      
        public static void OrbWalkTest()
        {
            Point enemyPos = modules.ChampPosition.GetEnemyPosition();
            Random rnd = new Random();

            short keyStateTemp = GetAsyncKeyState(0x20);
            bool keyIsPressed = ((keyStateTemp >> 15) & 0x0001) == 0x0001;

            if (keyIsPressed && CatHackMain.getCatHack())
            {
                if (CanAttack() && enemyPos != Point.Empty)
                { 
                    LastMovePoint = Cursor.Position; // save original position of cursor before attacking an enemy

                    KeyMouseHandler.IssueOrder(OrderEnum.AttackUnit, enemyPos); // attack le enemy
                    KeyMouseHandler.IssueOrder(OrderEnum.AttackUnit, enemyPos);

                    LastAATick2 = (int)((ApiHandler.GetGameTime() * 1000) + getAttackWindupTest() + SaveUserPing.getUserPing());

                    LastAATick = Environment.TickCount;              
                    LastMoveCommandT = Environment.TickCount + getAttackWindupTest();
                }
                if (CanMove() && enemyPos != Point.Empty)
                {
                    KeyMouseHandler.IssueOrder(OrderEnum.MoveTo, LastMovePoint);
                    LastMovePoint = Cursor.Position;

                    LastMoveCommandT = Environment.TickCount + rnd.Next(50, 80);
                }
                else
                {
                    if ((ApiHandler.GetGameTime() * 1000) >= LastAATick2)
                    {
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                    }
                    else
                    {
                        if (enemyPos == Point.Empty)
                        {
                            LastMovePoint = Cursor.Position;
                        }

                        KeyMouseHandler.IssueOrder(OrderEnum.MoveTo, LastMovePoint);
                    }
                }
            }
        }
    }
}
