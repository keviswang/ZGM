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
    
    public partial class ZFSJACTIVITYINSTANCE
    {
        public string AIID { get; set; }
        public string WIID { get; set; }
        public Nullable<decimal> ADID { get; set; }
        public Nullable<decimal> STATUSID { get; set; }
        public string PREVIONSAIID { get; set; }
        public string TOUSERID { get; set; }
        public string ADATA { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public Nullable<decimal> TIMELIMIT { get; set; }
        public Nullable<System.DateTime> SJTIMELIMIT { get; set; }
        public string IMEICODE { get; set; }
    
        public virtual ZFSJACTIVITYDEFINITION ZFSJACTIVITYDEFINITION { get; set; }
        public virtual ZFSJWORKFLOWINSTANCE ZFSJWORKFLOWINSTANCE { get; set; }
    }
}
