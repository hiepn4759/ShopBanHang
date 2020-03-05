using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Infrastructure
{
    /// <summary>
    /// khoi tao doi tuong
    /// </summary>
    public interface IDbFactory : IDisposable
    {
        /// <summary>
        /// khoi tao DbContext
        /// </summary>
        /// <returns></returns>
        ShopBanHangDbContext Init();
    }
}
