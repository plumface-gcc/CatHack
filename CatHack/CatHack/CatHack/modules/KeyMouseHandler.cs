using System.Drawing;
using System.Windows.Forms;

namespace CatHack.modules
{
    class KeyMouseHandler
    {
        public static void IssueOrder(OrderEnum Order, Point Vector2D = new Point())
        {
            switch (Order)
            {
                case OrderEnum.MoveMouse:
                    Mouse.SetCursorPosition(Vector2D.X, Vector2D.Y);
                    break;

                case OrderEnum.RightClick:
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                    break;

                case OrderEnum.MoveTo:
                    if (Vector2D.X == 0 && Vector2D.Y == 0)
                    {
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                        break;
                    }
                    if (Vector2D == new Point(Cursor.Position.X, Cursor.Position.Y))
                    {
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                        break;
                    }
                    Mouse.SetCursorPosition(Vector2D.X, Vector2D.Y);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                    break;

                case OrderEnum.AttackUnit:
                    if (Vector2D.X == 0 && Vector2D.Y == 0)
                    {
                        Mouse.SetCursorPosition(Cursor.Position.X, Cursor.Position.Y);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                        break;
                    }
                    Mouse.SetCursorPosition(Vector2D.X, Vector2D.Y);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                    break;

                case OrderEnum.AutoAttack:
                    KeyboardOut.SendKeyDown(KeyboardOut.ScanCodeShort.KEY_A);
                    KeyboardOut.SendKeyUp(KeyboardOut.ScanCodeShort.KEY_A);
                    break;

                case OrderEnum.Stop:
                    KeyboardOut.SendKeyDown(KeyboardOut.ScanCodeShort.KEY_S);
                    KeyboardOut.SendKeyUp(KeyboardOut.ScanCodeShort.KEY_S);
                    break;
            }
        }
    }
}
