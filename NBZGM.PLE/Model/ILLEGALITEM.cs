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
    
    public partial class ILLEGALITEM
    {
        public decimal ILLEGALITEMID { get; set; }
        public Nullable<decimal> ILLEGALCLASSID { get; set; }
        public string ILLEGALITEMNAME { get; set; }
        public string ILLEGALCODE { get; set; }
        public string WEIZE { get; set; }
        public string FZZE { get; set; }
        public string PENALTYCONTENT { get; set; }
    
        public virtual ILLEGALCLASS ILLEGALCLASS { get; set; }
    }
}