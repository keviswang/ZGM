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
    
    public partial class BP_HDJCXX
    {
        public decimal JCHD_ID { get; set; }
        public Nullable<decimal> HDCD { get; set; }
        public Nullable<decimal> HDKD { get; set; }
        public Nullable<decimal> HDMJ { get; set; }
        public string HDLX_TYPE { get; set; }
        public string SZDJ_TYPE { get; set; }
        public string BJDJ_TYPE { get; set; }
        public string SZYHSM { get; set; }
        public string HDQD { get; set; }
        public string HDZD { get; set; }
        public string BHDZH { get; set; }
        public Nullable<decimal> BJDW_ID { get; set; }
        public string BZ { get; set; }
        public Nullable<System.DateTime> JGRQ { get; set; }
        public Nullable<System.DateTime> YJRQ { get; set; }
        public Nullable<decimal> YHDW_ID { get; set; }
        public string JCHD_NAME { get; set; }
        public string SFZH { get; set; }
        public Nullable<decimal> SSZHD_ID { get; set; }
        public string CKJG { get; set; }
    
        public virtual BD_JCHDXX BD_JCHDXX { get; set; }
    }
}
