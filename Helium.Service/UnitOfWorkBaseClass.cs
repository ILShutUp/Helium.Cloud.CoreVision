using Helium.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Helium.Service
{
    public abstract class UnitOfWorkBaseClass : IUnitOfWorkContext
    {
        /// <summary>
        /// 获取 当前使用的数据访问上下文对象
        /// </summary>
        protected abstract DbContext Context { get; }

        /// <summary>
        ///     获取 当前单元操作是否已被提交
        /// </summary>
        public bool isCommited { get; private set; }

        public DbContext DbContext { get { return Context; } }

        /// <summary>
        ///     提交当前单元操作的结果
        /// </summary>
        public int Commit()
        {
            if (isCommited == true)
            {
                return 0;
            }
            try
            {
                int result = Context.SaveChanges();
                isCommited = true;
                return result;
            }
            catch (DbUpdateException e)
            {
                if (e.InnerException != null && e.InnerException.InnerException is SqlException)
                {
                    SqlException sqlException = e.InnerException.InnerException as SqlException;
                    throw new Exception("数据库异常", sqlException);
                }
                throw;
            }
        }

        /// <summary>
        ///   为指定的类型返回 System.Data.Entity.DbSet，这将允许对上下文中的给定实体执行 CRUD 操作。
        /// </summary>
        /// <typeparam name="TEntity"> 应为其返回一个集的实体类型。 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <returns> 给定实体类型的 System.Data.Entity.DbSet 实例。 </returns>
        public DbSet<TEntity> Set<TEntity, TKey>() where TEntity : EntityBaseClass<TKey>
        {
            return Context.Set<TEntity>();
        }

        /// <summary>
        ///   注册一个删除的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"> 要注册的类型 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="entity"> 要注册的对象 </param>
        public void RegisterDel<TEntity, TKey>(TEntity entity) where TEntity : EntityBaseClass<TKey>
        {
            Context.Entry(entity).State = EntityState.Deleted;
            isCommited = false;
        }

        /// <summary>
        ///   批量注册多个删除的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"> 要注册的类型 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="entities"> 要注册的对象集合 </param>
        public void RegisterDel<TEntity, TKey>(IEnumerable<TEntity> entities) where TEntity : EntityBaseClass<TKey>
        {
            try
            {
                Context.ChangeTracker.AutoDetectChangesEnabled = false;
                foreach (TEntity entity in entities)
                {
                    RegisterDel<TEntity, TKey>(entity);
                }
            }
            finally
            {
                Context.ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }

        /// <summary>
        ///     注册一个更改的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"> 要注册的类型 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="entity"> 要注册的对象 </param>
        public void RegisterMod<TEntity, TKey>(TEntity entity) where TEntity : EntityBaseClass<TKey>
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                Context.Set<TEntity>().Attach(entity);
            }
            Context.Entry(entity).State = EntityState.Modified;
            isCommited = false;
        }

        /// <summary>
        ///     注册一个新的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"> 要注册的类型 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="entity"> 要注册的对象 </param>
        public void RegisterNew<TEntity, TKey>(TEntity entity) where TEntity : EntityBaseClass<TKey>
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                Context.Entry(entity).State = EntityState.Added;
            }
            isCommited = false;
        }

        /// <summary>
        ///     批量注册多个新的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"> 要注册的类型 </typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="entities"> 要注册的对象集合 </param>
        public void RegisterNew<TEntity, TKey>(IEnumerable<TEntity> entities) where TEntity : EntityBaseClass<TKey>
        {
            try
            {
                Context.ChangeTracker.AutoDetectChangesEnabled = false;
                foreach (TEntity entity in entities)
                {
                    RegisterNew<TEntity, TKey>(entity);
                }
            }
            finally
            {
                Context.ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }

        /// <summary>
        ///     把当前单元操作回滚成未提交状态
        /// </summary>
        public void RollBack()
        {
            isCommited = false;
        }

        public void Dispose()
        {
            if (!isCommited)
            {
                Commit();
            }
            Context.Dispose();
        }
    }
}
