namespace MShop.Repository.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Read
        List<TEntity> GetAll();
        List<TEntity> GetAllAsNoTracking();
        TEntity Get(int id);

        //
        bool Add(TEntity entity);
        bool AddRange(List<TEntity> entities);


        bool Remove(int id);
        bool RemoveRange(IEnumerable<TEntity> entities);

        bool Update(TEntity entity);

        bool Save();
    }


}
