using Helium.Data.Entity.Company.Entity;
using Helium.Tools;
using System;
using System.ComponentModel;

namespace Helium.Data.Entity.Order.Entity
{
    //工作派单
    [Description("派单信息")]
    public class WorkSheet : EntityBaseClass<Guid>
    {
        public WorkSheet()
        {
            ID = CombHelper.NewComb();
        }

        public DateTime DoTime { get; set; }

        public string Ps { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual OrderList OrderList { get; set; }

    }
}
