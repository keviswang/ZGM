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
    
    public partial class ONDUTy
    {
        public ONDUTy()
        {
            this.USERONDUTIES = new HashSet<USERONDUTy>();
        }
    
        public decimal ID { get; set; }
        public string ONDUTYNAME { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public Nullable<decimal> CREATEUSERID { get; set; }
        public Nullable<System.DateTime> ONDUTYTIME { get; set; }
        public string CONTENT { get; set; }
        public Nullable<decimal> STATUID { get; set; }
        public Nullable<System.DateTime> OVERTIME { get; set; }
        public string ONROUTEID { get; set; }
    
        public virtual USER USER { get; set; }
        public virtual ICollection<USERONDUTy> USERONDUTIES { get; set; }
    }
}
