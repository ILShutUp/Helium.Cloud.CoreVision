namespace Helium.Service
{
    /// <summary>
    ///     业务操作单元
    /// </summary>
    public interface IUnitOfWork
    {
        bool isCommited { get; }
        int Commit();
        void RollBack();
    }
}
