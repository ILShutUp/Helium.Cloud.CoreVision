using Microsoft.EntityFrameworkCore;

namespace Helium.Service
{
    internal class RepositoryContext : UnitOfWorkBaseClass
    {
        protected override DbContext Context
        {
            get { return HContext; }
        }

        private HContext HContext { get; set; }
    }
}
