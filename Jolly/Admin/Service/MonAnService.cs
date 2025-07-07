using Admin.Service.IService;
using System.Net.Http;

namespace Admin.Service
{
    public class MonAnService : ApiService, IMonAnService
    {
        HttpClient _httpClient;
        public MonAnService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetIdMonAn()
        {

            var response = await _httpClient.GetAsync("MonAn/GenerateMonAnId");
            if (response.IsSuccessStatusCode)
            {
                var rawString = await response.Content.ReadAsStringAsync();
                return rawString;
            }
            else
            {
                return default;
            }
        }
    }
}
