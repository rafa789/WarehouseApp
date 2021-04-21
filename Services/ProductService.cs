using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Warehouse.Data;

namespace Warehouse.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public ProductService(HttpClient httpClient)
        {
            _client = httpClient;
        }

        public async Task<IEnumerable<Producto>> GetAllProducts()
        {
           return await JsonSerializer.DeserializeAsync<IEnumerable<Producto>>
            (await _client.GetStreamAsync($"api/Products"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Producto> GetBySku(string sku)
        {
            try
            {
                return await JsonSerializer.DeserializeAsync<Producto>
          (await _client.GetStreamAsync($"api/Products/{sku}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
            catch (Exception)
            {

                return new Producto();
            }
           
        }
    }
}
