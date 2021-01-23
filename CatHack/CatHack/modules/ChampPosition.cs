using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CatHack.modules
{
    class ChampPosition
    {
        private static Color RGB_ENEMY_HP_BAR_COLOR = Color.FromArgb(0x94, 0x24, 0x18);
        private static Color RGB_ENEMY_LEVEL_COLOR = Color.FromArgb(0x35, 0x03, 0x00);

        public static Point GetEnemyPosition()
        {
            Rectangle FOV = new Rectangle(450, 100, 1000, 750);
            Point[] Searched = PixelSearch.Search(FOV, RGB_ENEMY_LEVEL_COLOR, 1);

            Point result = new Point();

            if (Searched.Length != 0)
            {
                Point[] OrderedY = Searched.OrderBy(t => t.Y).ToArray<Point>();

                List<Tuple<SharpDX.Vector2, double>> list = new List<Tuple<SharpDX.Vector2, double>>();
                Point[] array3 = OrderedY;

                for (int i = 0; i < array3.Length; i++)
                {
                    Point point = array3[i];
                    SharpDX.Vector2 current = new SharpDX.Vector2((float)point.X, (float)point.Y);
                    if ((from t in list where (t.Item1 - current).Length() < 25f || Math.Abs(t.Item1.X - current.X) < 25f select t).Count<Tuple<SharpDX.Vector2, double>>() < 1)
                    {
                        list.Add(new Tuple<SharpDX.Vector2, double>(current, (double)(current - new SharpDX.Vector2((float)FOV.X, (float)FOV.Y)).Length()));
                        if (list.Count > 2)
                        {
                            break;
                        }
                    }
                }

                Tuple<SharpDX.Vector2, double> tuple = (from t in list orderby t.Item2 select t).ElementAt(0);
                Point point2 = new Point((int)tuple.Item1.X, (int)tuple.Item1.Y);

                result.X = point2.X + 50;
                result.Y = point2.Y + 100;
            }

            return result;
        }
    }
}
