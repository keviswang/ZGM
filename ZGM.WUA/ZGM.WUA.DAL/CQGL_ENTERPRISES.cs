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
    
    public partial class CQGL_ENTERPRISES
    {
        public CQGL_ENTERPRISES()
        {
            this.CQGL_ENTERPRISEMONEYS = new HashSet<CQGL_ENTERPRISEMONEYS>();
        }
    
        public decimal ENTERPRISEID { get; set; }
        public Nullable<decimal> PROJECTID { get; set; }
        public string LEGALNAME { get; set; }
        public string LEGALPHONE { get; set; }
        public Nullable<decimal> LANDAREA { get; set; }
        public Nullable<decimal> WARRANTAREA { get; set; }
        public Nullable<decimal> MEASUREMENTAREA { get; set; }
        public Nullable<decimal> WITHOUTAREA { get; set; }
        public Nullable<System.DateTime> SIGNTIME { get; set; }
        public Nullable<System.DateTime> EMPTYTIME { get; set; }
        public Nullable<decimal> SUMMONEY { get; set; }
        public Nullable<decimal> TAX { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public string FILENAME { get; set; }
        public string FILEPATH { get; set; }
    
        public virtual ICollection<CQGL_ENTERPRISEMONEYS> CQGL_ENTERPRISEMONEYS { get; set; }
        public virtual CQGL_PROJECTS CQGL_PROJECTS { get; set; }
    }
}
