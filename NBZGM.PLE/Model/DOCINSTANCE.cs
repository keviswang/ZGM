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
    
    public partial class DOCINSTANCE
    {
        public string DOCINSTANCEID { get; set; }
        public Nullable<decimal> DOCTYPEID { get; set; }
        public Nullable<decimal> DDID { get; set; }
        public string WIID { get; set; }
        public string DOCNAME { get; set; }
        public string DOCPATH { get; set; }
        public string VALUE { get; set; }
        public string ASSEMBLYNAME { get; set; }
        public string TYPENAME { get; set; }
        public Nullable<System.DateTime> CREATEDTIME { get; set; }
        public string DOCBH { get; set; }
        public string AIID { get; set; }
        public Nullable<decimal> DPID { get; set; }
    
        public virtual ACTIVITYINSTANCE ACTIVITYINSTANCE { get; set; }
        public virtual DOCDEFINITION DOCDEFINITION { get; set; }
        public virtual WORKFLOWINSTANCE WORKFLOWINSTANCE { get; set; }
    }
}
