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
    
    public partial class BD_JCLKLDCXDXX
    {
        public BD_JCLKLDCXDXX()
        {
            this.BD_JCLDXX = new HashSet<BD_JCLDXX>();
            this.BD_JCLKLDCXDSSJDGX = new HashSet<BD_JCLKLDCXDSSJDGX>();
            this.BD_JCQLXX = new HashSet<BD_JCQLXX>();
            this.BP_DLLDJCLKLDCXDGX = new HashSet<BP_DLLDJCLKLDCXDGX>();
            this.BP_JGLDJCLKLDCXDGX = new HashSet<BP_JGLDJCLKLDCXDGX>();
            this.BP_LDLDJCLKLDCXDGX = new HashSet<BP_LDLDJCLKLDCXDGX>();
        }
    
        public decimal JCLKLDCXD_ID { get; set; }
        public string JCLKLDCXDMS { get; set; }
        public Nullable<decimal> CXDCD { get; set; }
        public Nullable<decimal> CXDKD { get; set; }
        public Nullable<decimal> CXDMJ { get; set; }
        public Nullable<decimal> SWMX_ID { get; set; }
        public string DLTX { get; set; }
        public Nullable<decimal> ZXDXZB { get; set; }
        public Nullable<decimal> ZXDYZB { get; set; }
        public Nullable<decimal> GD { get; set; }
        public string SFLK { get; set; }
        public string SFYX { get; set; }
        public Nullable<System.DateTime> CJSJ { get; set; }
    
        public virtual BD_JCLDCXDXX BD_JCLDCXDXX { get; set; }
        public virtual ICollection<BD_JCLDXX> BD_JCLDXX { get; set; }
        public virtual BD_JCLKCXDXX BD_JCLKCXDXX { get; set; }
        public virtual ICollection<BD_JCLKLDCXDSSJDGX> BD_JCLKLDCXDSSJDGX { get; set; }
        public virtual ICollection<BD_JCQLXX> BD_JCQLXX { get; set; }
        public virtual ICollection<BP_DLLDJCLKLDCXDGX> BP_DLLDJCLKLDCXDGX { get; set; }
        public virtual ICollection<BP_JGLDJCLKLDCXDGX> BP_JGLDJCLKLDCXDGX { get; set; }
        public virtual ICollection<BP_LDLDJCLKLDCXDGX> BP_LDLDJCLKLDCXDGX { get; set; }
    }
}
