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
    
    public partial class SMS_MESSAGES
    {
        public decimal SMSID { get; set; }
        public Nullable<decimal> SMSTYPE { get; set; }
        public string RECEIVEUSERS { get; set; }
        public Nullable<decimal> SENDUSERID { get; set; }
        public string CONTENT { get; set; }
        public Nullable<System.DateTime> SENDTIME { get; set; }
        public string RECEIVEUSERSNAME { get; set; }
        public string REMARK { get; set; }
        public string PHONES { get; set; }
        public Nullable<decimal> ISAUDIT { get; set; }
        public string SENDIDENTITY { get; set; }
        public Nullable<decimal> AUDITUSER { get; set; }
        public Nullable<System.DateTime> AUDITTIME { get; set; }
        public string SOURCE { get; set; }
        public string MESSAGEID { get; set; }
    }
}
