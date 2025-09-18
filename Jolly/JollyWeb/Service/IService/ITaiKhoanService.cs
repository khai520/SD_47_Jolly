using API.Models.DTO;
using API.Models.ViewModels;

namespace JollyWeb.Service.IService
{
    public interface ITaiKhoanService : IApiService
    {
        public Task<TaiKhoanDTO> Login(LoginViewModel username);
        public Task<string?> CheckTk(string username, string sdt);
    }
}
