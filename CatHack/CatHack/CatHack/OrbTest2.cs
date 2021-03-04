using CatHack.modules;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CatHack
{
    class OrbTest2
    {
        private static int LastAATick;
        private static int ticksTillAttack;
        private static int ticksToMove;
        private static int LastAATick2;
        private static float LastMoveCommandT;
        private static int prev_orbtime;
        private static Point LastMovePoint;
        private static readonly Random rnd;

        private static float WindupPercent;
        private static float bWindupTime;
        private static float cAttackTime;

        private static float attackSpeed;
        private static float tAttackCooldown;
        private static float tAttackWindup;


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
            return (int)(1000.0f / LocalPlayer.GetAttackSpeed());
        }

        public static bool CanIssueOrder()
        {
            return Environment.TickCount - LastAATick + SaveUserPing.getUserPing() + 70 >= getAttackDelay() * 1000;
        }

        public static bool CanBeAborted()
        {
            if (Environment.TickCount - LastAATick >= getAttackWindup() * 1000 + SaveUserPing.getUserPing() / 10f)
            {
                return true;
            }
            return false;
        }

        public static bool CanAttack()
        {
            /*
            return Environment.TickCount + SaveUserPing.getUserPing() / 2 + 25 >= LastAATick + GetAttackDelay() * 1000;

            if (LastAATick <= Environment.TickCount)
            {
                return (Environment.TickCount + SaveUserPing.getUserPing() / 2 >= LastAATick + GetAttackDelay() + 50);
                return (Environment.TickCount + SaveUserPing.getUserPing() / 2 >= LastAATick + GetAttackDelay() * 1000);
            }
            return false;

           return Environment.TickCount + SaveUserPing.getUserPing() / 2 + 25 >= LastAATick + GetAttackDelay() * 1000;
            */
            if (Environment.TickCount - /* ?? */ LastAATick <= 100 + SaveUserPing.getUserPing())
            {
                return false;
            }
            return CanIssueOrder();
        }

        public static bool CanMove(float extraWindup)
        {
            //return (ApiHandler.GetGameTime() + SaveUserPing.getUserPing() / 2 >= LastAATick + GetAttackDelay() * 1000 + extraWindup);

            //if (LastAATick <= Environment.TickCount)
            //{
            //return LastMoveCommandT < Environment.TickCount + extraWindup;
            //}
            if (Environment.TickCount - /* ?? */ LastAATick <= 100 + SaveUserPing.getUserPing())
            {
                return false;
            }
            return CanBeAborted();

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
                Console.WriteLine(SaveUserPing.getUserPing());

                if (CanAttack() && enemyPos != Point.Empty)
                {
                    KeyMouseHandler.IssueOrder(OrderEnum.AttackUnit, enemyPos);

                    LastMovePoint = Cursor.Position; // save original position of cursor before attacking an enemy
                    LastAATick = Environment.TickCount;
                    KeyMouseHandler.IssueOrder(OrderEnum.MoveTo, LastMovePoint);

                }
                if (CanMove(10) && enemyPos != Point.Empty)
                {
                    KeyMouseHandler.IssueOrder(OrderEnum.MoveTo, LastMovePoint);
                    LastMovePoint = Cursor.Position;
                }
                else
                {
                    if (enemyPos == Point.Empty)
                    {
                        LastMovePoint = Cursor.Position;
                    }
                    if (!(CanAttack()) || (!(CanMove(0))))
                    {
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
