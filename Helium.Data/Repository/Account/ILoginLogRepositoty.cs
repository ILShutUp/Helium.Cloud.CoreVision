using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Common.DataKIT;
using WS.Core.Entity.Hr;

namespace WS.Core.Data.Repository.Account
{
    public partial interface ILoginLogRepositoty : IRepository<LoginLog, Guid>
    {
    }
}
