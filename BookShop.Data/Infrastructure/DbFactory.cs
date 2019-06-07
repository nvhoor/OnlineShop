using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Infrastructure
{
  public  class DbFactory:Disposable,IDbFactory
    {
        BookShopDbContext dbContext;
        public BookShopDbContext Init()
        {
            return dbContext ?? (dbContext = new BookShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
