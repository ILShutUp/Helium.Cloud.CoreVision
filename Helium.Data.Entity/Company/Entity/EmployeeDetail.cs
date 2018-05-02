using Helium.Tools;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Helium.Data.Entity.Company.Entity
{
    /// <summary>
    /// 用户扩展信息
    /// </summary>
    [Description("用户详细信息")]
    public class EmployeeDetail : EntityBaseClass<Guid>
    {
        public EmployeeDetail()
        {
            ID = CombHelper.NewComb();
        }

        [StringLength(2)]
        string Sex { get; set; }

        [StringLength(11)]
        string Tel { get; set; }

        [StringLength(60)]
        string Address { get; set; }

        [StringLength(18)]
        string IdCard { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
