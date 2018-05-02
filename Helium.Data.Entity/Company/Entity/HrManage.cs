using Helium.Tools;
using System;

namespace Helium.Data.Entity.Company.Entity
{
    public class HrManage : EntityBaseClass<Guid>
    {
        public virtual Department Department { get; set; }
        public virtual HrPost HrPost { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
