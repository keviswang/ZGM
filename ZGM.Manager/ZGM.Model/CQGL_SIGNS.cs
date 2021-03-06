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
    
    public partial class CQGL_SIGNS
    {
        public CQGL_SIGNS()
        {
            this.CQGL_CHECKOUT = new HashSet<CQGL_CHECKOUT>();
        }
    
        public decimal SIGNID { get; set; }
        public Nullable<decimal> HOUSEID { get; set; }
        public Nullable<System.DateTime> SIGNTIME { get; set; }
        public Nullable<decimal> HOUSEAREA { get; set; }
        public Nullable<decimal> WAREHOUSEAREA { get; set; }
        public Nullable<decimal> WIPEIN { get; set; }
        public Nullable<decimal> WIPEOUT { get; set; }
        public Nullable<decimal> EXPANSIONAREA { get; set; }
        public Nullable<decimal> HOUSEHOLDEXPANSIONAREA { get; set; }
        public Nullable<decimal> REWARDAREA { get; set; }
        public Nullable<decimal> MARRIAGEAREA { get; set; }
        public Nullable<decimal> HOUSEMONEY { get; set; }
        public Nullable<decimal> REWARDMONEY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<System.DateTime> EMPTYTIME { get; set; }
    
        public virtual ICollection<CQGL_CHECKOUT> CQGL_CHECKOUT { get; set; }
        public virtual CQGL_HOUSES CQGL_HOUSES { get; set; }
    }
}
