using CatHack.GUI;
using CatHack.modules;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;

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
        private static Point LastMovePoint;
        private static readonly Random rnd = new Random();

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        public static extern byte VkKeyScan(char ch);

        private static int GetAttackWindup()
        {
            float champWindupPercent = CatHackGUIChampions.getWindupPercent();

            int calc = (int)((1 / LocalPlayer.GetAttackSpeed() * 1000) * champWindupPercent);

            return calc;
        }

        private static int GetAttackDelay()
        {            
            return (int)(1000.0f / LocalPlayer.GetAttackSpeed());
        }

        private static bool CanAttack()
        {
            return LastAATick + GetAttackDelay() + SaveUserPing.getUserPing() / 2 < Environment.TickCount;
        }

        private static bool CanMove(float extraWindup)
        {
            if (CatHackGUIChampions.getSelectedChampion() == "Kalista")
            {
                return true;
            }
            else
            {
                return LastMoveCommandT < Environment.TickCount + extraWindup;
            }
        }


        /// <summary>
        /// Handles checking when to move the mouse and when to attack.
        /// </summary>      
        public static void OrbWalkEnemy()
        {
            int orbwalkKey = VkKeyScan(CatHackGUIPlayer.getOrbwalkKey());
            short keyStateTemp = GetAsyncKeyState(orbwalkKey);
            bool keyIsPressed = ((keyStateTemp >> 15) & 0x0001) == 0x0001;
            
            if (keyIsPressed && CatHackGUIOrb.getOrbCheck())
            {
                Point enemyPos = modules.ChampPosition.GetEnemyPosition();

                if (CanAttack() && enemyPos != Point.Empty)
                {
                    LastMovePoint = Cursor.Position; // save original position of cursor before attacking an enemy
                    KeyMouseHandler.IssueOrder(OrderEnum.AttackUnit, enemyPos); // attack le enemy

                    System.Threading.Thread.Sleep(5);

                    LastAATick = Environment.TickCount + 3;
                    LastMoveCommandT = Environment.TickCount + GetAttackWindup() + 3;

                    KeyMouseHandler.IssueOrder(OrderEnum.MoveMouse, LastMovePoint); // move back cursor to original position, but don't right click
                }
                else if (CanMove(CatHackGUIOrb.getExtraWindup()))
                {
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
                System.Diagnostics.Debug.WriteLine("Ping: " + SaveUserPing.getUserPing() + " | " + "Extra Windup: " + CatHackGUIOrb.getExtraWindup() + " | " + "Windup Percent: " + CatHackGUIChampions.getWindupPercent() + " | " + "Attack Delay: " + GetAttackDelay());
            }
        }
    }
}