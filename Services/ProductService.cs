
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarPartsAppWasm.Models;
using CarPartsAppWasm.Shared;


namespace CarPartsAppWasm.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;
        private readonly string _serverUrl;

        public ProductService(HttpClient httpClient, ServerSettings serverSettings)
        {
            _httpClient = httpClient;
            _serverUrl = serverSettings.ServerUrl;
        }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            var fullUrl = $"{_serverUrl}/server/product/products-list";
            return await _httpClient.GetFromJsonAsync<List<ProductDto>>(fullUrl);
        }

        public string GetServerUrl()
        {
            return _serverUrl;
        }
    }
}
