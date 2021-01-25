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
        private static float userPingFloat;
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
        public static int getAttackCooldown()
        {
            SaveAttackSpeed attkSpeed = new SaveAttackSpeed();
            CatHackMain cathack = new CatHackMain();

            attackSpeed = attkSpeed.getAttackSpeed();

            userPing = (int)userPingFloat;
            tAttackCooldown = (1 / attackSpeed) * 1000;

            try
            {
                int tAttackCooldownFinal = Convert.ToInt32(tAttackCooldown);
            }
            catch(OverflowException e)
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

        /// <summary>
        /// Handles moving the mouse and sending keystrokes.
        /// </summary>      
        public static void OrbWalkTest()
        {
            Point enemyPos = modules.ChampPosition.GetEnemyPosition();

            short keyStateTemp = GetAsyncKeyState(0x43); 
            bool keyIsPressed = ((keyStateTemp >> 15) & 0x0001) == 0x0001;      

            if (keyIsPressed && CatHackMain.getCatHack())
            {
                if (IsOrbAttackable && enemyPos != Point.Empty)
                {
                    LastMovePoint = Cursor.Position;

                    KeyMouseHandler.IssueOrder(OrderEnum.AttackUnit, enemyPos);
                    System.Threading.Thread.Sleep(getAttackCooldown());
                    KeyMouseHandler.IssueOrder(OrderEnum.MoveTo, LastMovePoint);

                    LastAATick = (int)((ApiHandler.GetGameTime() * 1000) + getAttackCooldown());
                    Console.WriteLine(LastAATick);

                    IsOrbAttackable = false;
                }
                else
                {
                    if ((ApiHandler.GetGameTime() * 1000) >= LastAATick)
                    {
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);

                        IsOrbAttackable = true;
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
