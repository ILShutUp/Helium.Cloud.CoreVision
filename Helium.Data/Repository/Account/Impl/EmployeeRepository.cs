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
    [Export(typeof(IEmployeeRepository))]
    public partial class EmployeeRepository : EFRepositoryBase<Employee, Int32>,IEmployeeRepository
    { }
}
