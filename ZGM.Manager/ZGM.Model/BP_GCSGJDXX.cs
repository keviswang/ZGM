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
    
    public partial class BP_GCSGJDXX
    {
        public decimal GCSGJD_ID { get; set; }
        public Nullable<decimal> GC_ID { get; set; }
        public Nullable<System.DateTime> HBRQ { get; set; }
        public Nullable<decimal> GCJD { get; set; }
        public string GCJDSM { get; set; }
        public Nullable<System.DateTime> TBSJ { get; set; }
    
        public virtual BP_GCGKXX BP_GCGKXX { get; set; }
    }
}
