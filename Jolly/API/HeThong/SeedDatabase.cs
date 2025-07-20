using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.HeThong
{
    public static class SeedDatabase
    {
        public static async Task SeedAsync(DBAppContext context)
        {
            var adminNguoiDungId = Guid.Parse("99999999-9999-9999-9999-999999999999");

            if (!await context.nguoiDungs.AnyAsync(nd => nd.Id == adminNguoiDungId))
            {
                var nguoiDung = new NguoiDung
                {
                    Id = adminNguoiDungId,
                    Ho = "Nguyễn Văn",
                    Ten = "Quản Trị",
                    Sdt = "0987654321",
                    Gmail = "admin@shop.com",
                    GioiTinh = "Nam",
                    NgaySinh = new DateTime(1995, 1, 1),
                };
                await context.nguoiDungs.AddAsync(nguoiDung);
            }

            if (!await context.taiKhoans.AnyAsync(tk => tk.NguoiDungId == adminNguoiDungId))
            {
                await context.taiKhoans.AddAsync(new TaiKhoan
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin",
                    Password = "admin123",
                    NguoiDungId = adminNguoiDungId,
                    NgayTaoTk = DateTime.Now
                });
            }

            if (!await context.nhanViens.AnyAsync(nv => nv.NguoiDungId == adminNguoiDungId))
            {
                await context.nhanViens.AddAsync(new NhanVien
                {
                    Id = "NV001",
                    NgayVaoLam = DateTime.Now,
                    NguoiDungId = adminNguoiDungId,
                    TrangThai = true,
                    ChucVuId = Guid.Parse("11111111-1111-1111-1111-111111111111")
                });
            }

            await context.SaveChangesAsync();
        }
    }

}
