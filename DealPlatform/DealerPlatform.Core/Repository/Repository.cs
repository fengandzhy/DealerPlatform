using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerPlatform.Core.EF;
using DealerPlatform.Demain.Domains;

namespace DealerPlatform.Core.Repository
{
    public class Repository<TEntity> : IRepository where TEntity : BaseEntity
    {
        private readonly DealerplatformContext _context;

        public Repository(DealerplatformContext context)
        {
            _context = context;
        }
        
        public List<TEntity> GetList()
        {
            return _context.Set<TEntity>().ToList();
        }
        
        public List<TEntity> GetList(Func<TEntity, bool> predicate)
        {
            var dbSet = _context.Set<TEntity>();
            return dbSet.Where(predicate).ToList();            
        }
    }
}