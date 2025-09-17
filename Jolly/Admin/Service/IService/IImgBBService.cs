using API.Models.ViewModels;

namespace JollyWeb.Service.IService
{
    public interface IImgBBService
    {
        Task<UploadResult?> UploadImageAsync(Stream fileStream, string fileName);
    }
}
