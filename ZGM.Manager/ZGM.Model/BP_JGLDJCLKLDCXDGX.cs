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
    
    public partial class BP_JGLDJCLKLDCXDGX
    {
        public decimal JGLD_ID { get; set; }
        public string JGXZ_TYPE { get; set; }
        public decimal JCLKLDCXD_ID { get; set; }
        public string BZ { get; set; }
    
        public virtual BD_JCLKLDCXDXX BD_JCLKLDCXDXX { get; set; }
        public virtual BP_JGLDJCXX BP_JGLDJCXX { get; set; }
    }
}
