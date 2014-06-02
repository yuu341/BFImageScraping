using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BFImageScraping.utils.parent;
using System.Net;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace BFImageScraping.utils.rss
{
    class RssFeedReader : ModelBase
    {
        public static RssFeed CreateRssFeed(string url)
        {
            return new RssFeedReader(url).RssFeed;
        }

        //public static void CreateRssInfo(string url, MST_WEBSITE Site)
        //{
        //    var feed = RssFeedReader.CreateRssFeed(url);
        //    foreach (var ch in feed.Channels)
        //    {
        //        foreach (var item in ch.Items)
        //        {
        //            foreach (var link in item.Links)
        //            {
        //                if (Site.TR_RSSINFO.Count(p => p.PAGE_URL == link.Url) == 0)
        //                    Site.TR_RSSINFO.Add(new db.TR_RSSINFO(item.Title, link.Url));
        //                //if (Site.RssInfo.Count(p => p.PAGE_URL == link.Url) == 0)
        //                //    Site.RssInfo.Add(new db.TR_RSSINFO(item.Title, link.Url));
        //            }
        //        }
        //    }
        //}
        private RssFeedReader(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                var response = request.GetResponse();

                //Stream rssStream = response.GetResponseStream();
                //XPathNavigator nav = 
                //xmlDoc.Load(rssStream);

                //RssFeed = new RssFeed();
                //tags = new Stack<string>();
                //tags.Push("top level");
                //RParseXML(xmlDoc.ChildNodes);
            }
            catch
            {

            }
        }

        private Stack<string> tags;
        private void RParseXML(XmlNodeList nodes)
        {
            foreach (XmlNode node in nodes)
            {
                bool book = true;
                switch (node.Name)
                {
                    case "channel":
                        RssFeed.Channels.Add(new RssChannel());
                        break;
                    case "items":
                    case "item":
                        RssFeed.Channels.Last().Items.Add(new RssItem());
                        break;
                    case "title":
                        if (tags.Peek() == "channel")
                        {
                            RssFeed.Channels.Last().Title = node.InnerText;
                        }
                        else
                        {
                            RssFeed.Channels.Last().Items.Last().Title = node.InnerText;
                        }
                        break;
                    case "link":
                        if (tags.Peek() == "channel")
                        {
                            RssFeed.Channels.Last().Link = new RssLink()
                            {
                                Url = node.InnerText
                            };
                        }
                        else
                        {
                            RssFeed.Channels.Last().Items.Last().Links.Add(
                                new RssLink() { Url = node.InnerText }
                                );
                        }
                        break;
                    default:
                        book = false;
                        break;
                }

                if(book)
                    tags.Push(node.Name);
                RParseXML(node.ChildNodes);
                if (book)
                    tags.Pop();
            }
        }

        public RssFeed RssFeed
        {
            get
            {
                return _RssFeed;
            }
            set
            {
                _RssFeed = value;
                Raise();
            }
        }
        public RssFeed _RssFeed;
    }
}
