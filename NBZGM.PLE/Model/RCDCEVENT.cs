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
    
    public partial class RCDCEVENT
    {
        public RCDCEVENT()
        {
            this.RCDCTOZFZDS = new HashSet<RCDCTOZFZD>();
        }
    
        public decimal EVENTID { get; set; }
        public string EVENTTITLE { get; set; }
        public string EVENTSOURCE { get; set; }
        public string EVENTADDRESS { get; set; }
        public string EVENTCONTENT { get; set; }
        public Nullable<decimal> GRADE { get; set; }
        public string GEOMETRY { get; set; }
        public string PICTURES { get; set; }
        public Nullable<decimal> USERID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public Nullable<decimal> CLASSBID { get; set; }
        public Nullable<decimal> CLASSSID { get; set; }
        public Nullable<System.DateTime> FXSJ { get; set; }
        public string GUIDONLY { get; set; }
    
        public virtual ICollection<RCDCTOZFZD> RCDCTOZFZDS { get; set; }
    }
}