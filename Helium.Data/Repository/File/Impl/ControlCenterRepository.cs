using System;
using System.ComponentModel.Composition;
using WS.Common.DataKIT;
using WS.Core.Entity.File;

namespace WS.Core.Data.Repository.File.Impl
{
    [Export(typeof(IControlCenterRepository))]
    public partial class ControlCenterRepository : EFRepositoryBase<ControlCenter, int>, IControlCenterRepository
    {
    }

    [Export(typeof(ICenterLevelRepository))]
    public partial class CenterLevelRepository : EFRepositoryBase<CenterLevel, int>, ICenterLevelRepository
    {
    }

    [Export(typeof(ICenterManageRepository))]
    public partial class CenterManageRepository : EFRepositoryBase<CenterManage, Guid>, ICenterManageRepository
    {
    }
}
