//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taizhou.PLE.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MENU
    {
        public decimal MENUID { get; set; }
        public Nullable<decimal> APPID { get; set; }
        public Nullable<decimal> PARENTID { get; set; }
        public string NAME { get; set; }
        public string URL { get; set; }
        public Nullable<decimal> SEQNO { get; set; }
        public string MENUCODE { get; set; }
        public string ICON { get; set; }
    
        public virtual APP APP { get; set; }
    }
}
