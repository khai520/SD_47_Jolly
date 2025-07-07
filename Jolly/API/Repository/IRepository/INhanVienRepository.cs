using API.Models;

namespace API.Repository.IRepository
{
    public interface INhanVienRepository : IRepository<NhanVien , string>
    {
        public Task<NhanVien> GetChucVu(Guid id);
    }
}
