using System;
using System.ComponentModel.Composition;
using WS.Common.DataKIT;
using WS.Core.Entity.File;

namespace WS.Core.Data.Repository.File.Impl
{
    [Export(typeof(IAccessUnitRepository))]
    public partial class AccessUnitRepository : EFRepositoryBase<AccessUnit, Int32>, IAccessUnitRepository
    {
    }

    [Export(typeof(IAccessUnitDetailRepository))]
    public partial class AccessUnitDetailRepository : EFRepositoryBase<AccessUnitDetail, Guid>, IAccessUnitDetailRepository
    {
    }

    [Export(typeof(IFireContorlLevelRepository))]
    public partial class FireContorlLevelRepository : EFRepositoryBase<FireContorlLevel, int>, IFireContorlLevelRepository
    {
    }

    [Export(typeof(IPurposeRepository))]
    public partial class PurposeLevelRepository : EFRepositoryBase<Purpose, int>, IPurposeRepository
    {
    }

    [Export(typeof(IStructurecsRepository))]
    public partial class StructurecsRepository : EFRepositoryBase<Structurecs, int>, IStructurecsRepository
    {
    }

    [Export(typeof(IContactLevelRepository))]
    public partial class ContactLevelRepository : EFRepositoryBase<ContactLevel, int>, IContactLevelRepository
    {
    }

    [Export(typeof(IContactRepository))]
    public partial class ContactRepository : EFRepositoryBase<Contact, Guid>, IContactRepository
    {
    }
}
