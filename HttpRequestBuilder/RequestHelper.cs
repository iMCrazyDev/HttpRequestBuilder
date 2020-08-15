using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;

namespace HttpRequestBuilder
{
    public static class RequestHelper
    {
        public struct RequestData
        {
            public string Uri;
            public string Data;
            public string[] Headers;
            public HttpMethod Method;
            public bool AllowRedirect;
            public ProxyType ProxyType;
            public string ProxyAddr;
        }

        public static string Send(RequestData requestData)
        {
            using (var httpRequest = new HttpRequest())
            {
                httpRequest.AllowAutoRedirect = requestData.AllowRedirect;
                DataHelper.AddHeaders(httpRequest, requestData.Headers);
                
                if(requestData.ProxyAddr != "")
                {
                    httpRequest.Proxy = ProxyClient.Parse(requestData.ProxyType, requestData.ProxyAddr);
                }

                var resp = httpRequest.Raw(requestData.Method, requestData.Uri, new StringContent(requestData.Data, Encoding.UTF8));
                return ResponseToText(resp);
            }
                
        }

        public static string ResponseToText(HttpResponse httpResponse)
        {
            string headers = "";
            var en = httpResponse.EnumerateHeaders();
            do
            {
                headers += en.Current.Key + " " + en.Current.Value + "\r\n";
            } while (en.MoveNext());

            return httpResponse.Method + " " + httpResponse.Address + "\r\n" + headers + "\r\n\r\n" + httpResponse.ToString();
        }

    }
}
