using CatHack.modules;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CatHack
{
    class OrbTest1
    {
        private static int LastAATick;
        private static int LastAATick2;
        private static int LastMoveCommandT;
        private static Point LastMovePoint;


        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        /// <summary>
        /// Handles calculating the current champion's attack windup
        /// </summary>
        /// <returns>Attack Windup</returns>
        public static int getAttackWindup()
        {
            CatHackMain cathack = new CatHackMain();
            float champWindupPercent = cathack.getWindupPercent();

            int calc = (int)((1 / LocalPlayer.GetAttackSpeed() * 1000) * champWindupPercent);

            return calc;
        }

        public static int getAttackDelay()
        {
            return (int)(LocalPlayer.GetAttackSpeed() / 1000.0f);
        }

        public static bool CanAttack()
        {
            return LastAATick + getAttackDelay() + SaveUserPing.getUserPing() / 2 < Environment.TickCount;
        }

        public static bool CanMove(float extraWindup)
        {
            //return ApiHandler.GetGameTime() + SaveUserPing.getUserPing() / 2 >= LastAATick + GetAttackDelay() * 1000 + extraWindup;
            return LastMoveCommandT < Environment.TickCount + extraWindup;
        }

        /// <summary>
        /// Handles moving the mouse and sending keystrokes.
        /// </summary>      
        public static void OrbWalk()
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

                    LastAATick2 = (int)((Environment.TickCount) + getAttackWindup() + SaveUserPing.getUserPing());
                    LastAATick = Environment.TickCount;
                    LastMoveCommandT = Environment.TickCount + getAttackWindup();
                }
                if (CanMove(0) && enemyPos != Point.Empty)
                {
                    LastMovePoint = Cursor.Position;
                    LastMoveCommandT = Environment.TickCount + rnd.Next(50, 80);
                }
                else
                {
                    if ((Environment.TickCount) >= LastAATick2)
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
                        if (!(CanAttack()) || (!(CanMove(0))))
                        {
                            KeyMouseHandler.IssueOrder(OrderEnum.MoveTo, LastMovePoint);
                        }
                        else
                        {
                            LastMovePoint = Cursor.Position;
                        }
                    }
                }
            }
        }
    }
}
