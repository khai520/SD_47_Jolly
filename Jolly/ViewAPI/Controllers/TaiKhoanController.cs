using API.Controllers;
using API.Data;
using API.HeThong;
using API.Models;
using API.Models.DTO;
using API.Models.ViewModels;
using API.Repository;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ViewAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaiKhoanController : BaseController<TaiKhoan, TaiKhoanDTO, Guid>
    {
        private readonly ITaiKhoanRepository _taikhoanrepository;
        public TaiKhoanController(ITaiKhoanRepository repository, DBAppContext context, IMapper mapper, XulyId xulyId) : base(repository, context, mapper, xulyId)
        {
            _taikhoanrepository = repository;
        }
        [HttpPost("login")]
        public IActionResult Login(LoginViewModel model)
        {
            var user = _context.taiKhoans
                .Include(t => t.NguoiDung).ThenInclude(n => n.NhanVien).ThenInclude(cv => cv.ChucVu)
                .FirstOrDefault(t => t.UserName == model.TaiKhoan && t.Password == model.MatKhau);

            if (user == null)
                return BadRequest("Sai tài khoản hoặc mật khẩu.");

            var dto = _mapper.Map<TaiKhoanDTO>(user);
            return Ok(dto); 
        }

    }
}
