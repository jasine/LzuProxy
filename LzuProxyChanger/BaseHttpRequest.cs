using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Net;
using System.IO;

namespace LzuProxyChanger
{
    public class BaseHttpRequest
    {
      
        public string ResponseContent { get; private set; }
        public WebHeaderCollection ResponseHeaders { get; private set; }
        public HttpStatusCode ResponseStatusCode { get; private set; }
        private static readonly string DefaultUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
        private HttpWebResponse myHttpWebResponse;

        private void GetHttpResponseContent()
        {
            string html = null;
            Stream receiveStream = myHttpWebResponse.GetResponseStream();
            StreamReader sr = new StreamReader(receiveStream, Encoding.ASCII);      
            char[] readbuffer = new char[1024];
            int n = sr.Read(readbuffer, 0, 1024);
            while (n > 0)
            {
                string str = new string(readbuffer, 0, n);
                html += str;
                n = sr.Read(readbuffer, 0, 1024);
            }
            ResponseContent = html;
        }     


        /// <summary>
        /// 创建GET方式的HTTP请求
        /// </summary>
        /// <param name="url">请求的URL</param>
        /// <param name="timeout">请求的超时时间</param>
        /// <param name="userAgent">请求的客户端浏览器信息，可以为空</param>
        /// <param name="cookies">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>
        /// <returns></returns>
        public void  CreateGetHttpResponse(Uri url, int? timeout, string userAgent,WebProxy proxy, CookieCollection cookies,string method)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = method;
            request.UserAgent = DefaultUserAgent;
            if (!String.IsNullOrEmpty(userAgent))
            {
                request.UserAgent = userAgent;//else?
            }
            else
            {
                request.UserAgent = DefaultUserAgent;
            }
            if (timeout.HasValue)
            {
                request.Timeout = timeout.Value;
            }
            if (cookies != null)
            {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(url, cookies);          
            }
            if (proxy != null)
            {
                request.Proxy= proxy;
            }
            try
            {
                myHttpWebResponse = request.GetResponse() as HttpWebResponse;               
            }
            catch (Exception)
            {         
                throw;
            }
            ResponseHeaders = myHttpWebResponse.Headers;
            ResponseStatusCode = myHttpWebResponse.StatusCode;
            GetHttpResponseContent();
        }

        
    }



   




}
