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
    
    public partial class BD_JCSXHDJCXXGX
    {
        public decimal JCSX_ID { get; set; }
        public decimal JCHD_ID { get; set; }
        public string BZ { get; set; }
    
        public virtual BD_JCHDXX BD_JCHDXX { get; set; }
        public virtual BD_JCSXXX BD_JCSXXX { get; set; }
    }
}
