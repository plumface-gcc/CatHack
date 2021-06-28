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
        private static readonly Random random = new Random();
        private static Point LastMovePoint;
        private static List<float> attackDelayList = new List<float>();
        private static List<float> pingList = new List<float>();

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        private static int GetAttackWindup()
        {
            float champWindupPercent = CatHackGUIChampions.getWindupPercent();

            int calc = (int)((1 / LocalPlayer.GetAttackSpeed() * 1000) * champWindupPercent);

            return calc;
        }

        private static int GetAttackDelay()
        {
            int attackDelay = (int)(1000.0f / LocalPlayer.GetAttackSpeed());
            attackDelayList.Add(attackDelay);

            try
            {
                if (attackDelayList[attackDelayList.Count - 1] < attackDelayList[attackDelayList.Count - 2] || attackDelayList[attackDelayList.Count - 1] > attackDelayList[attackDelayList.Count - 2])
                {
                    System.Diagnostics.Debug.WriteLine("Attack speed changed, cancelling auto");
                    KeyMouseHandler.IssueOrder(OrderEnum.Stop);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
            return attackDelay;
        }

        private static bool CanAttack()
        {   
            float lastPing = SaveUserPing.getUserPing();
            pingList.Add(lastPing);

            try
            {
                if (pingList[pingList.Count - 1] < pingList[pingList.Count - 2])
                {
                    System.Diagnostics.Debug.WriteLine("Ping changed, cancelling auto");
                    KeyMouseHandler.IssueOrder(OrderEnum.Stop);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            return LastAATick + GetAttackDelay() + SaveUserPing.getUserPing() / 2 - CatHackGUIOrb.getExtraWindup() < Environment.TickCount;
        }

        private static bool CanMove(float extraWindup)
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

            if (keyIsPressed && CatHackGUIOrb.getOrbCheck())
            {
                Point enemyPos = modules.ChampPosition.GetEnemyPosition();

                if (CanAttack() && enemyPos != Point.Empty)
                {
                    LastMovePoint = Cursor.Position; // save original position of cursor before attacking an enemy
                    KeyMouseHandler.IssueOrder(OrderEnum.AttackUnit, enemyPos); // attack le enemy

                    LastAATick = Environment.TickCount;
                    LastMoveCommandT = Environment.TickCount + GetAttackWindup();

                    KeyMouseHandler.IssueOrder(OrderEnum.MoveMouse, LastMovePoint); // move back cursor to original position, but don't right click
                }
                else if (CanMove(CatHackMain.getExtraWindup()))
                {
                    KeyMouseHandler.IssueOrder(OrderEnum.RightClick);

                    LastMovePoint = Cursor.Position;
                    LastMoveCommandT = Environment.TickCount + random.Next(50, 80);
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