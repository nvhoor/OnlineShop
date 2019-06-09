using BookShop.Data.Infrastructure;
using BookShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Responsitories
{
    public interface IAuthorRepository:IRepository<Author>
    {

    }
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
