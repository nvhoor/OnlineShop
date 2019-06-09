using BookShop.Data.Infrastructure;
using BookShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Responsitories
{
    public interface IPublisherRepository:IRepository<Publisher>
    {

    }
    public class PublisherRepository : RepositoryBase<Publisher>, IPublisherRepository
    {
        public PublisherRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
