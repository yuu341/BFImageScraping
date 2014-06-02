using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BFImageScraping.utils.parent;

namespace BFImageScraping.utils.rss
{
    class RssLink : ModelBase
    {
        public string Url
        {
            get
            {
                return _Url;
            }
            set
            {
                _Url = value;
                Raise();
            }
        }
        private string _Url;
    }
}
