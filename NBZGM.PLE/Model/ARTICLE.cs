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
    
    public partial class ARTICLE
    {
        public decimal ARTICLEID { get; set; }
        public string TITLE { get; set; }
        public string CONTENT { get; set; }
        public string AUTHOR { get; set; }
        public Nullable<decimal> CREATEDUSERID { get; set; }
        public Nullable<System.DateTime> CREATEDTIME { get; set; }
        public Nullable<decimal> STATUSID { get; set; }
        public Nullable<decimal> APPROVALSTATUSID { get; set; }
        public Nullable<decimal> APPROVALUSERID { get; set; }
        public Nullable<System.DateTime> APPROVALTIME { get; set; }
        public Nullable<decimal> CATEGORYID { get; set; }
    
        public virtual PORTALCATEGORy PORTALCATEGORy { get; set; }
    }
}
