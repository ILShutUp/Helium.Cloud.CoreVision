using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Common.DataKIT;
using WS.Core.Entity.Hr;

namespace WS.Core.Data.Repository.Account.Impl
{
    [Export(typeof(ILoginLogRepositoty))]
    public partial class LoginLogRepository : EFRepositoryBase<LoginLog,Guid>, ILoginLogRepositoty
    {
    }
}
