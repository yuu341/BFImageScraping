using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using BFImageScraping.utils.parent;

namespace BFImageScraping.utils.rss
{
    class RssFeed : ModelBase
    {
        public RssFeed()
        {
            Channels = new ObservableCollection<RssChannel>();
        }

        public ObservableCollection<RssChannel> Channels
        {
            get
            {
                return _Channels;
            }
            set
            {
                _Channels = value;
                Raise();
            }
        }
        private ObservableCollection<RssChannel> _Channels;
    }
}
