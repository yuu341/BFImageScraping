//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BFImageScraping.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TR_IMG
    {
        public TR_IMG()
        {
            this.TR_PATH = new HashSet<TR_PATH>();
            this.MST_TAG = new HashSet<MST_TAG>();
        }
    
        public int IMG_ID { get; set; }
        public string IMG_NM { get; set; }
        public Nullable<int> WIDTH { get; set; }
        public Nullable<int> HEIGHT { get; set; }
        public string HASH { get; set; }
        public int SIZE { get; set; }
    
        public virtual ICollection<TR_PATH> TR_PATH { get; set; }
        public virtual ICollection<MST_TAG> MST_TAG { get; set; }
    }
}
