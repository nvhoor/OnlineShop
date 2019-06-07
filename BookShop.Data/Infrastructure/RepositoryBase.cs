using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Infrastructure
{
  public abstract class RepositoryBase<T> where T :class
    {
        #region Properties
        private BookShopDbContext dbContext;
        private readonly IDbSet<T> dbSet;
    }
}
