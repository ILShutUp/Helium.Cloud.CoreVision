using System;
using System.ComponentModel.Composition;
using WS.Common.DataKIT;
using WS.Core.Entity.File;

namespace WS.Core.Data.Repository.File.Impl
{
    [Export(typeof(IMaintenanceUnitRepository))]
    public partial class MaintenanceUnitRepository : EFRepositoryBase<MaintenanceUnit, Int32>, IMaintenanceUnitRepository
    {
    }
}
