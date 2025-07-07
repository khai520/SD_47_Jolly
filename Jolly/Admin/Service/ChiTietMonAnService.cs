using Admin.Service.IService;
using API.Models;
using Azure;

namespace Admin.Service
{
    public class ChiTietMonAnService : ApiService, IChiTietMonAnService
    {
        private readonly HttpClient _httpclient;
        public ChiTietMonAnService(HttpClient httpClient) : base(httpClient)
        {
            _httpclient = httpClient;
        }

        public async Task<List<ChiTietMonAn>> GetChiTiet(string id)
        {
            try
            {
                var response = await _httpclient.GetAsync($"ChiTietMonAn/monan/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<List<ChiTietMonAn>>();
                    return data ?? new List<ChiTietMonAn>();
                }
                return new List<ChiTietMonAn>();
            }
            catch (Exception)
            {
                return new List<ChiTietMonAn>();
            }
        }

    }
}
