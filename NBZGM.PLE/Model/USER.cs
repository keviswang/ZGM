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
    
    public partial class USER
    {
        public USER()
        {
            this.CARALARMS = new HashSet<CARALARM>();
            this.CARCOMPANIES = new HashSet<CARCOMPANy>();
            this.ONDUTIES = new HashSet<ONDUTy>();
            this.SINGNINS = new HashSet<SINGNIN>();
            this.SPECIALACTIVITICES = new HashSet<SPECIALACTIVITICE>();
            this.SPECIALTOZFSJS = new HashSet<SPECIALTOZFSJ>();
            this.SPECIALWORKFLOWINSTANCES = new HashSet<SPECIALWORKFLOWINSTANCE>();
            this.STREETUSERS = new HashSet<STREETUSER>();
            this.USERONDUTIES = new HashSet<USERONDUTy>();
            this.USERROLES = new HashSet<USERROLE>();
            this.ZFGKUSERHISTORYPOSITIONS = new HashSet<ZFGKUSERHISTORYPOSITION>();
            this.XCJGUSERTASKS = new HashSet<XCJGUSERTASK>();
        }
    
        public decimal USERID { get; set; }
        public string USERNAME { get; set; }
        public Nullable<decimal> UNITID { get; set; }
        public string ACCOUNT { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<decimal> USERPOSITIONID { get; set; }
        public Nullable<decimal> STATUSID { get; set; }
        public Nullable<decimal> SEQNO { get; set; }
        public string RTXACCOUNT { get; set; }
        public string SMSNUMBERS { get; set; }
        public Nullable<decimal> USERCATEGORYID { get; set; }
        public Nullable<decimal> CATEGORYID { get; set; }
        public Nullable<decimal> REGIONID { get; set; }
        public string ZFZBH { get; set; }
        public string WORKZZ { get; set; }
    
        public virtual ICollection<CARALARM> CARALARMS { get; set; }
        public virtual ICollection<CARCOMPANy> CARCOMPANIES { get; set; }
        public virtual ICollection<ONDUTy> ONDUTIES { get; set; }
        public virtual ICollection<SINGNIN> SINGNINS { get; set; }
        public virtual ICollection<SPECIALACTIVITICE> SPECIALACTIVITICES { get; set; }
        public virtual ICollection<SPECIALTOZFSJ> SPECIALTOZFSJS { get; set; }
        public virtual ICollection<SPECIALWORKFLOWINSTANCE> SPECIALWORKFLOWINSTANCES { get; set; }
        public virtual ICollection<STREETUSER> STREETUSERS { get; set; }
        public virtual UNIT UNIT { get; set; }
        public virtual USERARCHIVE USERARCHIVE { get; set; }
        public virtual USERCATEGORy USERCATEGORy { get; set; }
        public virtual ICollection<USERONDUTy> USERONDUTIES { get; set; }
        public virtual USERPOSITION USERPOSITION { get; set; }
        public virtual ICollection<USERROLE> USERROLES { get; set; }
        public virtual ICollection<ZFGKUSERHISTORYPOSITION> ZFGKUSERHISTORYPOSITIONS { get; set; }
        public virtual ZFGKUSERLATESTPOSITION ZFGKUSERLATESTPOSITION { get; set; }
        public virtual WTUSERRELATION WTUSERRELATION { get; set; }
        public virtual ICollection<XCJGUSERTASK> XCJGUSERTASKS { get; set; }
    }
}
