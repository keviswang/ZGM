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
    
    public partial class OA_TASKS
    {
        public string TASKID { get; set; }
        public string TASKTITLE { get; set; }
        public Nullable<System.DateTime> FINISHTIME { get; set; }
        public string TASKCONTENT { get; set; }
        public Nullable<decimal> IMPORTANT { get; set; }
        public string WFID { get; set; }
        public string REMARK1 { get; set; }
        public string REMARK2 { get; set; }
        public string REMARK3 { get; set; }
        public Nullable<decimal> CREATEUSERID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public Nullable<decimal> STATUS { get; set; }
    }
}