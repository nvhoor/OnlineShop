using BookShop.Data.Infrastructure;
using BookShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Responsitories
{
    public interface IProductAuthorRepository:IRepository<ProductAuthor>
    {

    }
    public class ProductAuthorRepository : RepositoryBase<ProductAuthor>, IProductAuthorRepository
    {
        public ProductAuthorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
