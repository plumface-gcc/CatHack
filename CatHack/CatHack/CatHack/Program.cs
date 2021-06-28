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
                    Application.Run(new CatHackGUI());
                },

                () =>
                {
                    bool loop = true;

                    while (loop)
                    {
                        OrbWalk.OrbWalkEnemy();
                        //OrbTest1.OrbWalk();
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
