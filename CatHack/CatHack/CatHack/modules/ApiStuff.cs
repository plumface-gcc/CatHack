using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace CatHack
{
    class ApiStuff
    {
        public static JObject GetGameStatsData()
        {
            if (IsLiveGameRunning())
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://127.0.0.1:2999/liveclientdata/gamestats");

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    try { return JObject.Parse(reader.ReadToEnd()); }
                    catch (Exception)
                    {
                        Console.WriteLine("GameDataParseFailedException");
                        throw new Exception("GameDataParseFailedException");
                    }
                }
            }
            else
            {
                Console.WriteLine("GameDataParseFailedException");
                throw new Exception("GameDataParseFailedException");
            }
        }

        public static JObject GetActivePlayerData()
        {
            if (IsLiveGameRunning())
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://127.0.0.1:2999/liveclientdata/activeplayer");

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    try { return JObject.Parse(reader.ReadToEnd()); }
                    catch (Exception Ex)
                    {
                        throw new Exception("PlayerDataParseFailedException");
                    }
                }
            }
            else
            {
                throw new Exception("PlayerDataParseFailedException");
            }
        }

        public static bool IsLiveGameRunning()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://127.0.0.1:2999/liveclientdata/allgamedata");
            System.Net.ServicePointManager.ServerCertificateValidationCallback += delegate (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                        System.Security.Cryptography.X509Certificates.X509Chain chain,
                        System.Net.Security.SslPolicyErrors sslPolicyErrors)
            {
                return true; // **** Always accept
            };

            request.Method = "GET";

            bool flag = false;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK) flag = true;
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }

            return flag;
        }
    }
}
