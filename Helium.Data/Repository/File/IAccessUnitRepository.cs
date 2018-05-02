using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Common.DataKIT;
using WS.Core.Entity.File;

namespace WS.Core.Data.Repository.File
{
    public partial interface IAccessUnitRepository : IRepository<AccessUnit, int>
    {
    }

    public partial interface IAccessUnitDetailRepository: IRepository<AccessUnitDetail,Guid>
    {
    }

    public partial interface IFireContorlLevelRepository : IRepository<FireContorlLevel,int>
    {
    }

    public partial interface IPurposeRepository : IRepository<Purpose, int>
    {
    }

    public partial interface IStructurecsRepository : IRepository<Structurecs, int>
    {
    }

    public partial interface IContactLevelRepository : IRepository<ContactLevel, int>
    {
    }

    public partial interface IContactRepository : IRepository<Contact, Guid>
    {
    }
}
