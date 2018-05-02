using Helium.Data.Entity.Account.Entity;
using Helium.Data.Entity.Order;
using Helium.Data.Entity.Order.Entity;
using Helium.Tools;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Helium.Data.Entity.Company.Entity
{
    /// <summary>
    /// 员工信息类
    /// </summary>
    [Description("用户信息")]
    public class Employee : EntityBaseClass<int>
    {
        [Required]
        [StringLength(16, MinimumLength = 4)]
        public string EmpName { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 6)]
        public string EmpPass { get; set; }

        [Required]
        public string EmpCode { get; set; }

        public virtual EmployeeDetail EmployeeDetail { get; set; }

        public virtual ICollection<LoginLog> LoginLogs { get; set; }

        public virtual ICollection<WorkSheet> WorkSheets { get; set; }

        public virtual ICollection<HrManage> HrManages { get; set; }
    }
}
