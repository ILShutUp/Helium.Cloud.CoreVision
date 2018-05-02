using Helium.Data.Entity.Company.Entity;
using Helium.Tools;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Helium.Data.Entity.Account.Entity
{
    public class LoginLog : EntityBaseClass<Guid>
    {
        [Description("登录信息")]
        public LoginLog()
        {
            ID = CombHelper.NewComb();
        }

        [Required]
        [StringLength(15)]
        public string IpAddress { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
