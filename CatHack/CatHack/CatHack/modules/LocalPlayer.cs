using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatHack.modules
{
    class LocalPlayer
    {
        public static float GetAttackSpeed()
        {
            return ActivePlayerData.ChampionStats.GetAttackSpeed();
        }
    }
}
