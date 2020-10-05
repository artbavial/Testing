using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore.Internal;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;

namespace Testing
{


    class Program
    {
        static void Main(string[] args)
        {
            var parser = ParserTheSite("//h1[@class='index-main-news__article-title']").Distinct();
            

           foreach (string el in parser)
            {
                
                Console.WriteLine(el);
            }

            Console.ReadKey();
            
        }
        public static string DownloadSite(string url_site)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;

            string str_html = wc.DownloadString(url_site);

            return str_html;
        }

        public static IEnumerable<string> ParserTheSite(string xpath)
        {
            var htmlDoc = new HtmlDocument();

            htmlDoc.LoadHtml(DownloadSite("http://inosmi.ru"));

            foreach(HtmlNode html in htmlDoc.DocumentNode.SelectNodes(xpath))
            {
                yield return html.InnerText;
            }

        }

    }
}
