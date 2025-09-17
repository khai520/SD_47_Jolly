using API.Models.ViewModels;
using JollyWeb.Service.IService;
using System.Net.Http.Headers;

namespace JollyWeb.Service
{
    public class ImgBBService : IImgBBService
    {
        private readonly HttpClient _http;

        public ImgBBService(HttpClient http)
        {
            _http = http;
        }
        public async Task<UploadResult?> UploadImageAsync(Stream fileStream, string fileName)
        {
            var apiKey = "90d7777f8a5a0a8f586a73e866118138";
            var url = $"https://api.imgbb.com/1/upload?key={apiKey}";

            using var form = new MultipartFormDataContent();
            form.Add(new StreamContent(fileStream), "image", fileName);

            var response = await _http.PostAsync(url, form);
            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) return null;

            using var doc = System.Text.Json.JsonDocument.Parse(json);
            var data = doc.RootElement.GetProperty("data");

            return new UploadResult
            {
                FileName = fileName,
                Url = data.GetProperty("url").GetString() ?? "",
                DeleteUrl = data.TryGetProperty("delete_url", out var del) ? del.GetString() ?? "" : ""
            };
        }

    }
}
