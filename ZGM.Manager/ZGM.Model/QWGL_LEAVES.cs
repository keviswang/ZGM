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
    
    public partial class QWGL_LEAVES
    {
        public QWGL_LEAVES()
        {
            this.QWGL_LEAVEEXAMINES = new HashSet<QWGL_LEAVEEXAMINES>();
        }
    
        public decimal LEAVEID { get; set; }
        public Nullable<decimal> LTYPEID { get; set; }
        public Nullable<decimal> USERID { get; set; }
        public Nullable<System.DateTime> SDATE { get; set; }
        public Nullable<System.DateTime> EDATE { get; set; }
        public string LEAVEREASON { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string REMARKS { get; set; }
        public Nullable<decimal> LEAVEDAY { get; set; }
    
        public virtual ICollection<QWGL_LEAVEEXAMINES> QWGL_LEAVEEXAMINES { get; set; }
        public virtual QWGL_LEAVETYPES QWGL_LEAVETYPES { get; set; }
    }
}
