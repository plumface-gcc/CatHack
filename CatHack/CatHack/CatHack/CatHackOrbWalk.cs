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
            return LastAATick + getAttackWindup() + SaveUserPing.getUserPing() / 2 < Environment.TickCount;
            //return ApiHandler.GetGameTime() + (SaveUserPing.getUserPing() / 2) + 25
                //>= LastAATick + (getAttackDelay() * 1000);
        }

        /// <summary>
        /// Handles moving the mouse and sending keystrokes.
        /// </summary>      
        public static void OrbWalkTest()
        {
            Point enemyPos = modules.ChampPosition.GetEnemyPosition();

            short keyStateTemp = GetAsyncKeyState(0x20);
            bool keyIsPressed = ((keyStateTemp >> 15) & 0x0001) == 0x0001;

            if (keyIsPressed && CatHackMain.getCatHack())
            {
                if (CanAttack() && enemyPos != Point.Empty)
                {
                    LastMovePoint = Cursor.Position;

                    KeyMouseHandler.IssueOrder(OrderEnum.AttackUnit, enemyPos);
                    KeyMouseHandler.IssueOrder(OrderEnum.AttackUnit, enemyPos);
                    System.Threading.Thread.Sleep((int)(SaveUserPing.getUserPing() / 2) + 25);
                    KeyMouseHandler.IssueOrder(OrderEnum.MoveTo, LastMovePoint);

                    LastAATick = (int)((Environment.TickCount * 1000) + getAttackWindupTest() + SaveUserPing.getUserPing());
                }
                else
                {
                    if ((LastAATick + getAttackDelay() + SaveUserPing.getUserPing() / 2 < Environment.TickCount))
                    {
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                    }                         
                    else
                    {
                        LastMovePoint = Cursor.Position;
                        KeyMouseHandler.IssueOrder(OrderEnum.MoveTo, LastMovePoint);
                        LastMovePoint = Cursor.Position;
                    }
                }
            }
        }
    }
}
