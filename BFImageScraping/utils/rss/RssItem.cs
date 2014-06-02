using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BFImageScraping.utils.parent;
using System.Collections.ObjectModel;

namespace BFImageScraping.utils.rss
{
    class RssItem : ModelBase
    {
        public RssItem()
        {
            Title = string.Empty;
            Links = new ObservableCollection<RssLink>();
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

        public ObservableCollection<RssLink> Links
        {
            get
            {
                return _Links;
            }
            set
            {
                _Links = value;
                Raise();
            }
        }
        private ObservableCollection<RssLink> _Links;
    }
}
