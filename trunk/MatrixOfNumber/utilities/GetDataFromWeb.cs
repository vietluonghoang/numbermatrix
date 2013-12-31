using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using HtmlAgilityPack;
using MatrixOfNumber.entities;

namespace MatrixOfNumber.utilities
{
    class GetDataFromWeb
    {
        private string baseUrl = "http://xskt.com.vn/ket-qua-xo-so-theo-ngay/mien-bac-xsmb/";
        private string rssUrl = "http://xskt.com.vn/rss-feed/mien-bac-xsmb.rss";

        private HtmlNode getSource(string date)
        {
            try
            {
                HtmlDocument document = new HtmlDocument();
                WebClient client = new WebClient();
                string url = this.baseUrl + date + ".html";
                string rssSource = client.DownloadString(rssUrl);
                document.LoadHtml(rssSource);
                HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//item");
                HtmlNode node = null;
                foreach (HtmlNode n in nodes)
                {
                    HtmlNodeCollection sbnode = n.ChildNodes;
                    foreach (HtmlNode sn in sbnode)
                    {
                        if (sn.NextSibling != null)
                        {
                            if (url.Equals(sn.NextSibling.InnerHtml) && "link".Equals(sn.OriginalName))
                            {
                                return n;
                            }
                        }
                    }
                }
                return node;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public Result getResult(string date)
        {
            try
            {
                HtmlNode node = getSource(date);
                if (node == null)
                {
                    return null;
                }
                Result result;
                string header = node.Element("title").InnerText;
                List<Prize> prz = new List<Prize>();
                HtmlNode description = node.Element("description");
                string[] rs = (description.InnerText).Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string level in rs)
                {
                    string[] tn = level.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    int i = 0;
                    try
                    {
                        i = Int16.Parse(tn[0]);
                    }
                    catch (Exception e)
                    {
                        i = 0;
                    }
                    string[] title = { "Giải đặc biệt", "Giải nhất", "Giải nhì", "Giải ba", "Giải tư", "Giải năm", "Giải sáu", "Giải bảy" };
                    Prize p = new Prize(title[i], tn[1]);
                    prz.Add(p);
                }
                result = new Result(date, header, prz);
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
