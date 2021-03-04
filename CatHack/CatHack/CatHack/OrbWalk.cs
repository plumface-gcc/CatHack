using CatHack.modules;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CatHack
{
    /*
     * Huge credits to jiingz for orbwalking source code
     * Huge credits aswell to admiralzero for pixelsearch source and league API source
     * www.unknowncheats.me/forum/league-of-legends/ 
     */
    class OrbWalk
    {
        private static int LastAATick;
        private static int LastMoveCommandT;
        private static int moving;
        private static int attacking;
        private static Point LastMovePoint;

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        public static int GetAttackWindup()
        {
            CatHackMain cathack = new CatHackMain();
            float champWindupPercent = cathack.getWindupPercent();

            int calc = (int)((1 / LocalPlayer.GetAttackSpeed() * 1000) * champWindupPercent);

            return calc;
        }

        public static int GetAttackDelay()
        {
            return (int)(1000.0f / LocalPlayer.GetAttackSpeed());
        }

        public static bool CanAttack()
        {
            return LastAATick + GetAttackDelay() + SaveUserPing.getUserPing() / 2 - 10 < Environment.TickCount;
        }

        public static bool CanMove(float extraWindup)
        {
            return LastMoveCommandT < Environment.TickCount + extraWindup;
        }

        /// <summary>
        /// Handles checking when to move the mouse and when to attack.
        /// </summary>      
        public static void OrbWalkEnemy()
        {
            short keyStateTemp = GetAsyncKeyState(0x20);
            bool keyIsPressed = ((keyStateTemp >> 15) & 0x0001) == 0x0001;

            if (keyIsPressed && CatHackMain.getCatHack())
            {
                Point enemyPos = modules.ChampPosition.GetEnemyPosition();
                Random rnd = new Random();

                if (CanAttack() && enemyPos != Point.Empty)
                {
                    attacking++;
                    System.Diagnostics.Debug.WriteLine("attacking" + " | " + attacking);

                    LastMovePoint = Cursor.Position; // save original position of cursor before attacking an enemy
                    KeyMouseHandler.IssueOrder(OrderEnum.AttackUnit, enemyPos); // attack le enemy

                    LastAATick = Environment.TickCount;
                    LastMoveCommandT = Environment.TickCount + GetAttackWindup();

                    KeyMouseHandler.IssueOrder(OrderEnum.MoveMouse, LastMovePoint); // move back cursor to original position, but don't right click
                }
                else if (CanMove(CatHackMain.getExtraWindup()))
                {
                    moving++;
                    System.Diagnostics.Debug.WriteLine("moving" + " | " + moving);

                    KeyMouseHandler.IssueOrder(OrderEnum.RightClick);

                    LastMovePoint = Cursor.Position;
                    LastMoveCommandT = Environment.TickCount + rnd.Next(50, 80);
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