using Helium.Tools;
using System.Collections.Generic;

namespace Helium.Data.Entity.Company.Entity
{
    public class Department : EntityBaseClass<int>
    {
        public string Name { get; set; }

        public virtual ICollection<HrManage> HrManages { get; set; }
    }
}
