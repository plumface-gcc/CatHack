namespace CatHack.modules
{
    class GameStats
    {
        internal static float GetGameTime()
        {
            return ApiStuff.GetGameStatsData()["gameTime"].ToObject<float>();
        }

    }
}
