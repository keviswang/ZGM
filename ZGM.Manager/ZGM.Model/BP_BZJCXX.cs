//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZGM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BP_BZJCXX
    {
        public decimal JCBZ_ID { get; set; }
        public string BZLX_TYPE { get; set; }
        public string SBGL { get; set; }
        public string FDJGL { get; set; }
        public Nullable<decimal> SBSL { get; set; }
        public string CSKGJ { get; set; }
        public string CSKWZ { get; set; }
        public string DWSJLL { get; set; }
        public string DZXXXX { get; set; }
        public string CKJG { get; set; }
        public string BZ { get; set; }
        public Nullable<System.DateTime> JGRQ { get; set; }
        public Nullable<System.DateTime> YJRQ { get; set; }
        public Nullable<decimal> YHDW_ID { get; set; }
    
        public virtual BD_JCBZXX BD_JCBZXX { get; set; }
    }
}
