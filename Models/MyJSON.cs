using System;

using System.Net;

namespace jsonpg01.Models
{
    public class MyJSON{

        public static string ReceiveJSON(string url)
        {
            using(WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(url);
                return json;
            }
        }
    }
}