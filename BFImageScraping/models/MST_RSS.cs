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
    
    public partial class MST_RSS
    {
        public int RSS_ID { get; set; }
        public Nullable<int> WEBSITE_ID { get; set; }
        public string RSS_URL { get; set; }
    
        public virtual MST_WEBSITE MST_WEBSITE { get; set; }
    }
}
