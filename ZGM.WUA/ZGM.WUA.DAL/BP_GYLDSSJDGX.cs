//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZGM.WUA.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BP_GYLDSSJDGX
    {
        public decimal GYLD_ID { get; set; }
        public decimal JCJD_ID { get; set; }
        public string BZ { get; set; }
    
        public virtual BD_JCJDXX BD_JCJDXX { get; set; }
        public virtual BP_GYLDJCXX BP_GYLDJCXX { get; set; }
    }
}