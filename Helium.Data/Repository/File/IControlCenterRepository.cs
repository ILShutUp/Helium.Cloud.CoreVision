using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Common.DataKIT;
using WS.Core.Entity.File;

namespace WS.Core.Data.Repository.File
{
    public interface IControlCenterRepository : IRepository<ControlCenter,int>
    {
    }
    public interface ICenterLevelRepository : IRepository<CenterLevel, int>
    {
    }
    public interface ICenterManageRepository : IRepository<CenterManage, Guid>
    {
    }
}
