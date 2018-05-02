using Helium.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helium.Service
{
    /// <summary>
    ///     定义仓储模型中的数据标准操作
    /// </summary>
    /// <typeparam name="TEntity">动态实体类型</typeparam>
    /// <typeparam name="TKey">实体主键类型</typeparam>
    public interface IRepository<TEntity, in TKey> where TEntity : EntityBaseClass<TKey>
    {
        /// <summary>
        ///     获取 当前实体的查询数据集
        /// </summary>
        IQueryable<TEntity> Entities { get; }

        /// <summary>
        ///     插入单个新实体记录
        /// </summary>
        /// <param name="entity">实体记录</param>
        void Insert(TEntity entity);

        /// <summary>
        ///     插入新实体记录集合 
        /// </summary>
        /// <param name="entities">实体记录集合</param>
        void Insert(IEnumerable<TEntity> entities);

        /// <summary>
        ///     删除指定编号的实体记录
        /// </summary>
        /// <param name="key">实体编号</param>
        void Delete(TKey key);

        /// <summary>
        ///     删除单个实体记录
        /// </summary>
        /// <param name="entity">实体记录</param>
        void Delete(TEntity entity);

        /// <summary>
        /// 批量删除实体记录集合
        /// </summary>
        /// <param name="entities">实体记录集合</param>
        void Delete(IEnumerable<TEntity> entities);

        /// <summary>
        ///     更新实体记录
        /// </summary>
        /// <param name="entity">实体记录</param>
        void Update(TEntity entity);

        /// <summary>
        ///     根据编号获取记录信息
        /// </summary>
        /// <param name="key">实体编号</param>
        /// <returns></returns>
        TEntity GetByKey(TKey key);
    }
}
