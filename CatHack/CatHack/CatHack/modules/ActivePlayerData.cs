using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatHack.modules
{
    class ActivePlayerData
    {
        public class ChampionStats
        {
            public static float GetAttackSpeed()
            {
                return ApiStuff.GetActivePlayerData()["championStats"]["attackSpeed"].ToObject<float>();
            }
        }
    }
}
