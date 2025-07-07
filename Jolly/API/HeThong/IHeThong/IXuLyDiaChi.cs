using API.Models.DTO.BanHang;

namespace API.HeThong.IHeThong
{
    public interface IXuLyDiaChi
    {
        Task<List<DiaChiNhap>> ParseDiaChiAsync(string filePath);
    }
}
