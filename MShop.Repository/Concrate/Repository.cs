using Microsoft.EntityFrameworkCore;
using MShop.Data;
using MShop.Repository.Abstract;

namespace MShop.Repository.Concrate
{
    //Ortak operasyonların metod Gövdelerinin bulunduğu yer.
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //Products,Categories,Sliders
        //_context.Set<TEntity>() equals DbSet<Entity>

        protected readonly MShopContext _context;

        private readonly DbSet<TEntity> _dbSet;
        public Repository(MShopContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public List<TEntity> GetAllAsNoTracking()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);//select * from Product where Id =1
        }

        public bool Add(TEntity entity)
        {
            _dbSet.Add(entity);
            return Save();
        }

        public bool AddRange(List<TEntity> entities)
        {
            _dbSet.AddRange(entities);
            return Save();
        }

        public bool Remove(int id)
        {
            TEntity entity = Get(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                return Save();
            }
            return false;
        }

        public bool RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
            return Save();
        }


        public bool Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return Save();
        }

        public bool Save()
        {
            //Her Crud(Read) hariç bu metodun çağrılması gerekir 
            //Yapılan değişiklikleri database yansıtır.
            return _context.SaveChanges() > 0;
        }

    }
}
