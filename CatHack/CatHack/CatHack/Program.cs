using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatHack
{
    static class Program
    {

        [STAThread]
        static void Main()
        {

            Parallel.Invoke(
                () =>
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new CatHackMain());
                },

                () =>
                {
                    bool loop = true;

                    while (loop)
                    {
                        OrbWalk.OrbWalkEnemy();
                    }
                },

                () =>
                {
                    Application.Run(new UserPingForm());
                }
            );
        }
    }
}
