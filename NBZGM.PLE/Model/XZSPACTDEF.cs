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
    
    public partial class XZSPACTDEF
    {
        public XZSPACTDEF()
        {
            this.XZSPACTISTS = new HashSet<XZSPACTIST>();
        }
    
        public decimal ADID { get; set; }
        public Nullable<decimal> WDID { get; set; }
        public string ADCODE { get; set; }
        public string ADNAME { get; set; }
        public Nullable<decimal> NEXTADID { get; set; }
        public Nullable<decimal> TIMELIMIT { get; set; }
        public string DEFAULTPOSITIONID { get; set; }
        public string ADDESCRIPTION { get; set; }
        public Nullable<decimal> SEQNO { get; set; }
    
        public virtual XZSPWFDEF XZSPWFDEF { get; set; }
        public virtual ICollection<XZSPACTIST> XZSPACTISTS { get; set; }
    }
}
