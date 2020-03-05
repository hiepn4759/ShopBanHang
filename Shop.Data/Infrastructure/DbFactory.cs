using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopBanHangDbContext dbContext;

        /// <summary>
        /// null thi khoi tao new
        /// </summary>
        /// <returns></returns>
        public ShopBanHangDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopBanHangDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
