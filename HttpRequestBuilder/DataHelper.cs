using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;

namespace HttpRequestBuilder
{
    public class DataHelper
    {
        public static void AddHeaders(HttpRequest httpRequest,string[] lines)
        {
            foreach (var t in lines)
            {
                try
                {
                    string nameHeader = t.Split(':')[0];
                    string headerValue = t.Substring(t.IndexOf(':') + 2);

                    switch (nameHeader.ToLower())
                    {
                        case "connection":
                            httpRequest.KeepAlive = headerValue.Contains("keep");
                            break;
                        case "referer":
                            httpRequest.Referer = headerValue;
                            break;
                        default:
                            httpRequest.AddHeader(nameHeader, headerValue);
                            break;
                    }
                }
                catch { }
            }
        }

        public static string UrlEncode(string data)
        {
            var spl = data.Split('&');
            var res = "";

            foreach(var t in spl)
            {
                var name = t.Split('=')[0];
                var val = t.Substring(t.IndexOf("=") + 1);
                res += Uri.EscapeUriString(name) + "=" + Uri.EscapeUriString(val) + "&";
            }

            return res.Substring(0, res.Length - 1);
        }
    }
}
