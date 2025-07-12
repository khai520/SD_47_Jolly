using API.Models;

namespace Admin.Service.IService
{
    public interface IChiTietMonAnService : IApiService
    {
        Task<List<ChiTietMonAn>> GetChiTiet(string Id);
        Task<List<ChiTietMonAn>> GetAll();

    }
}
