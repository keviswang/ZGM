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
    
    public partial class QWGL_CARS
    {
        public QWGL_CARS()
        {
            this.QWGL_CARALARMMEMORYDATA = new HashSet<QWGL_CARALARMMEMORYDATA>();
            this.QWGL_CARHISTORYPOSITIONS = new HashSet<QWGL_CARHISTORYPOSITIONS>();
            this.QWGL_CARLATESTPOSITIONS = new HashSet<QWGL_CARLATESTPOSITIONS>();
        }
    
        public decimal CARID { get; set; }
        public Nullable<decimal> CARTYPEID { get; set; }
        public string CARNUMBER { get; set; }
        public string CARTEL { get; set; }
        public Nullable<decimal> ISONLINE { get; set; }
        public string REMARK { get; set; }
        public Nullable<decimal> CREATEUSERID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public Nullable<decimal> UNITID { get; set; }
        public Nullable<decimal> ISPOLICE { get; set; }
        public Nullable<decimal> STATE { get; set; }
    
        public virtual ICollection<QWGL_CARALARMMEMORYDATA> QWGL_CARALARMMEMORYDATA { get; set; }
        public virtual ICollection<QWGL_CARHISTORYPOSITIONS> QWGL_CARHISTORYPOSITIONS { get; set; }
        public virtual ICollection<QWGL_CARLATESTPOSITIONS> QWGL_CARLATESTPOSITIONS { get; set; }
        public virtual QWGL_CARTYPE QWGL_CARTYPE { get; set; }
        public virtual SYS_UNITS SYS_UNITS { get; set; }
    }
}