using API.Models;

namespace Admin.Service.IService
{
    public interface IApiService 
    {
        Task<T?> GetAsync<T>(string url);
        Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest data);
        Task<bool> PutAsync<TRequest>(string url, TRequest data);
        Task<bool> DeleteAsync(string url);
    }
}
