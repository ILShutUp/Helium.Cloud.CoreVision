using Helium.Tools;
using System;
using System.Collections.Generic;

namespace Helium.Service
{
    public interface IUnitOfWorkContext : IUnitOfWork, IDisposable
    {
        void RegisterNew<TEntity, TKey>(TEntity entity) where TEntity : EntityBaseClass<TKey>;
        void RegisterNew<TEntity, TKey>(IEnumerable<TEntity> entities) where TEntity : EntityBaseClass<TKey>;
        void RegisterDel<TEntity, TKey>(TEntity entity) where TEntity : EntityBaseClass<TKey>;
        void RegisterDel<TEntity, TKey>(IEnumerable<TEntity> entities) where TEntity : EntityBaseClass<TKey>;
        void RegisterMod<TEntity, TKey>(TEntity entity) where TEntity : EntityBaseClass<TKey>;
    }
}
