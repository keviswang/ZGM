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
    
    public partial class XCJGUSERTASK
    {
        public decimal USERID { get; set; }
        public System.DateTime TASKDATE { get; set; }
        public Nullable<decimal> SSQJID { get; set; }
        public Nullable<decimal> SSZDID { get; set; }
        public Nullable<decimal> STARTHOUR { get; set; }
        public Nullable<decimal> STARTMINUTE { get; set; }
        public Nullable<decimal> ENDHOUR { get; set; }
        public Nullable<decimal> ENDMINUTE { get; set; }
        public Nullable<decimal> AREAID { get; set; }
        public Nullable<decimal> ROUTEID { get; set; }
        public string JOBCONTENT { get; set; }
        public Nullable<System.DateTime> CREATEDTIME { get; set; }
    
        public virtual USER USER { get; set; }
        public virtual XCJGAREA XCJGAREA { get; set; }
        public virtual XCJGROUTE XCJGROUTE { get; set; }
    }
}
