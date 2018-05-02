using Helium.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helium.Service
{
    public abstract class RepositoryBaseClass<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : EntityBaseClass<TKey>
    {
        public RepositoryBaseClass()
        {
        }

        /// <summary>
        ///     获取仓储上下文实例
        /// </summary>
        public IUnitOfWork UnitOfWork { get; set; }

        /// <summary>
        ///     获取 EntityFramework的数据仓储上下文
        /// </summary>
        protected UnitOfWorkBaseClass HContext
        {
            get
            {
                if (UnitOfWork is UnitOfWorkBaseClass)
                {
                    return UnitOfWork as UnitOfWorkBaseClass;
                }
                throw new Exception(string.Format("数据仓储上下文对象类型不正确，应为UnitOfWorkContextBase，实际为 {0}", UnitOfWork.GetType().Name));
            }
        }

        /// <summary>
        ///     获取 当前实体的查询数据集
        /// </summary>
        public virtual IQueryable<TEntity> Entities
        {
            get
            {
                return HContext.Set<TEntity, TKey>();
            }
        }

        /// <summary>
        ///     插入实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        public void Insert(TEntity entity)
        {
            HContext.RegisterNew<TEntity, TKey>(entity);
            HContext.Commit();
        }

        /// <summary>
        ///     批量插入实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        public void Insert(IEnumerable<TEntity> entities)
        {
            HContext.RegisterNew<TEntity, TKey>(entities);
            HContext.Commit();
        }

        /// <summary>
        ///     删除指定编号的记录
        /// </summary>
        /// <param name="id"> 实体记录编号 </param>
        public void Delete(TKey key)
        {
            Delete(HContext.Set<TEntity, TKey>().Find(key));
        }

        /// <summary>
        ///     删除实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        public void Delete(TEntity entity)
        {
            HContext.RegisterDel<TEntity, TKey>(entity);
            HContext.Commit();
        }

        /// <summary>
        ///     删除实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        public void Delete(IEnumerable<TEntity> entities)
        {
            HContext.RegisterDel<TEntity, TKey>(entities);
            HContext.Commit();
        }

        /// <summary>
        ///     更新实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        public void Update(TEntity entity)
        {
            HContext.RegisterMod<TEntity, TKey>(entity);
            HContext.Commit();
        }

        /// <summary>
        ///     查找指定主键的实体记录
        /// </summary>
        /// <param name="key"> 指定主键 </param>
        public TEntity GetByKey(TKey key)
        {
            return HContext.Set<TEntity, TKey>().Find(key);
        }
    }
}
