using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BFImageScraping.utils.parent
{
    public class ModelBase : INotifyPropertyChanged
    {
        public ModelBase()
        {
            WindowEnabled = true;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void Raise([CallerMemberName]string name=null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }


        /// <summary>
        /// ウィンドウの表示をいじる場合
        /// </summary>
        public bool WindowEnabled
        {
            get
            {
                return _WindowEnabled;
            }
            set
            {
                _WindowEnabled = value;
                Raise("WindowEnabled");
            }
        }
        private bool _WindowEnabled;
    }
}
