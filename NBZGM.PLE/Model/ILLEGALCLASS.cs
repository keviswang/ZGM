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
    
    public partial class ILLEGALCLASS
    {
        public ILLEGALCLASS()
        {
            this.ILLEGALITEMS = new HashSet<ILLEGALITEM>();
        }
    
        public decimal ILLEGALCLASSID { get; set; }
        public Nullable<decimal> ILLEGALCLASSTYPEID { get; set; }
        public Nullable<decimal> PARENTID { get; set; }
        public string ILLEGALCLASSNAME { get; set; }
        public Nullable<decimal> ILLEGALCODE { get; set; }
        public string PATH { get; set; }
    
        public virtual ICollection<ILLEGALITEM> ILLEGALITEMS { get; set; }
    }
}
