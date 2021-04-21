using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Data;

namespace Warehouse.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Producto>> GetAllProducts();
        Task<Producto> GetBySku(string sku);

    }
}
