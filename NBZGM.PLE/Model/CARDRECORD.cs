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
    
    public partial class CARDRECORD
    {
        public decimal CARID { get; set; }
        public Nullable<decimal> CARDTYPEID { get; set; }
        public Nullable<decimal> CONSTRSITEID { get; set; }
        public Nullable<decimal> DUMPINGSITEID { get; set; }
        public System.DateTime CARDTIME { get; set; }
        public Nullable<decimal> TRANSLICENSEID { get; set; }
        public Nullable<decimal> ISADDITIONAL { get; set; }
        public string PICTURE { get; set; }
    
        public virtual CARDTYPE CARDTYPE { get; set; }
        public virtual CAR CAR { get; set; }
        public virtual CONSTRSITE CONSTRSITE { get; set; }
        public virtual DUMPINGSITE DUMPINGSITE { get; set; }
    }
}
