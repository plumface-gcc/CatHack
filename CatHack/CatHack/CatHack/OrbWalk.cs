using CatHack.modules;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CatHack
{
    class OrbWalk
    {
        private static int LastAATick;
        private static int LastMoveCommandT;
        private static int moving;
        private static int attacking;
        private static Point LastMovePoint;

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        /// <summary>
        /// Handles calculating the current champion's attack windup
        /// </summary>
        /// <returns>Attack Windup</returns>
        public static int getAttackWindup() // credit: jiingz
        {
            CatHackMain cathack = new CatHackMain();
            float champWindupPercent = cathack.getWindupPercent();

            int calc = (int)((1 / LocalPlayer.GetAttackSpeed() * 1000) * champWindupPercent);

            return calc;
        }

        public static int getAttackDelay() // credit: jiingz
        {
            return (int)(1000.0f / LocalPlayer.GetAttackSpeed());
        }

        public static bool CanAttack() // credit: jiingz
        {
            return Environment.TickCount + SaveUserPing.getUserPing() / 2 + 25 >= LastAATick + getAttackDelay();
        }

        public static bool CanMove(float extraWindup) // credit: jiingz
        {
            return LastMoveCommandT >= Environment.TickCount + extraWindup;
        }

        /// <summary>
        /// Handles checking when to move the mouse and when to attack.
        /// </summary>      
        public static void OrbWalkEnemy()
        {
            Point enemyPos = modules.ChampPosition.GetEnemyPosition(); // credit: admiralzero
            Random rnd = new Random();

            short keyStateTemp = GetAsyncKeyState(0x20);
            bool keyIsPressed = ((keyStateTemp >> 15) & 0x0001) == 0x0001;

            if (keyIsPressed && CatHackMain.getCatHack())
            {
                if (CanAttack() && enemyPos != Point.Empty)
                {
                    if (!CanMove(CatHackMain.getExtraWindup()))
                    {
                        attacking++;
                        System.Diagnostics.Debug.WriteLine("attacking" + " | " + attacking);

                        LastMovePoint = Cursor.Position; // save original position of cursor before attacking an enemy
                        KeyMouseHandler.IssueOrder(OrderEnum.AttackUnit, enemyPos); // attack le enemy

                        if (getAttackDelay() >= 400) // this is here so it doesn't cancel too many auto attacks at lower attack speeds
                        {
                            System.Threading.Thread.Sleep(10);
                        }

                        LastAATick = Environment.TickCount;
                        LastMoveCommandT = Environment.TickCount + getAttackWindup();

                        KeyMouseHandler.IssueOrder(OrderEnum.MoveMouse, LastMovePoint); // move back cursor to original position, but don't right click
                    }
                }
                if (CanMove(CatHackMain.getExtraWindup()) && enemyPos != Point.Empty)
                {
                    if (!CanAttack())
                    {
                        moving++;
                        System.Diagnostics.Debug.WriteLine("moving" + " | " + moving);

                        KeyMouseHandler.IssueOrder(OrderEnum.RightClick);

                        LastMovePoint = Cursor.Position;
                        LastMoveCommandT = Environment.TickCount + rnd.Next(50, 80);
                    }
                }
                else
                {
                    if (enemyPos == Point.Empty)
                    {
                        LastMovePoint = Cursor.Position;
                    }

                    KeyMouseHandler.IssueOrder(OrderEnum.RightClick);
                }
                System.Diagnostics.Debug.WriteLine("Last AA Tick: " + LastAATick + " | " + "Last Move Command Time: " + LastMoveCommandT + " | " + "Env TickCount: " + Environment.TickCount + " | " + "Ping: " + SaveUserPing.getUserPing());
            }
        }
    }
}