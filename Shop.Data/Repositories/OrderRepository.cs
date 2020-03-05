using Shop.Data.Infrastructure;
using System.Collections.Generic;
using System.Data.SqlClient;
using Shop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        
    }
}