using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using BFImageScraping.utils.parent;

namespace BFImageScraping.utils.rss
{
    class RssChannel : ModelBase
    {
        public RssChannel()
        {
            Title = string.Empty;
            Link = new RssLink();
            Items = new ObservableCollection<RssItem>();
        }

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
                Raise();
            }
        }
        private string _Title;

        public RssLink Link
        {
            get
            {
                return _Link;
            }
            set
            {
                _Link = value;
                Raise();
            }
        }
        private RssLink _Link;

        public ObservableCollection<RssItem> Items
        {
            get
            {
                return _Items;
            }
            set
            {
                _Items = value;
                Raise();
            }
        }
        private ObservableCollection<RssItem> _Items;
    }
}
