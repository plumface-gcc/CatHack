using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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
                    Application.Run(new CatHack());
                },

                () =>
                {
                    bool loop = true;

                    while (loop)
                    {
                        SaveImage.OrbWalkTest(null, null);
                    }
                },

                () =>
                {
                    Application.Run(new CatHackMain());
                }

            );
        }
    }
}
