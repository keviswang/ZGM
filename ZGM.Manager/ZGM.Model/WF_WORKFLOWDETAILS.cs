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
    
    public partial class WF_WORKFLOWDETAILS
    {
        public WF_WORKFLOWDETAILS()
        {
            this.WF_WORKFLOWSPECIFICACTIVITYS = new HashSet<WF_WORKFLOWSPECIFICACTIVITYS>();
        }
    
        public string WFDID { get; set; }
        public string WFID { get; set; }
        public string WFDNAME { get; set; }
        public string NEXTID { get; set; }
        public Nullable<decimal> STATUS { get; set; }
        public Nullable<decimal> ISCURENTUSERDEPT { get; set; }
        public Nullable<decimal> ISUSER { get; set; }
        public string USERVALUE { get; set; }
        public Nullable<decimal> ISDEPT { get; set; }
        public string DEPTVALUE { get; set; }
        public Nullable<decimal> ISROLE { get; set; }
        public string ROLEVALUE { get; set; }
        public Nullable<decimal> SEQNUM { get; set; }
        public string NEXTIDDEFAULT { get; set; }
        public string NEXTIDDEFAULTUSER { get; set; }
        public string NEXTIDDEFAULTDEPT { get; set; }
        public string NEXTIDDEFAULTROLE { get; set; }
    
        public virtual WF_WORKFLOWS WF_WORKFLOWS { get; set; }
        public virtual ICollection<WF_WORKFLOWSPECIFICACTIVITYS> WF_WORKFLOWSPECIFICACTIVITYS { get; set; }
    }
}
