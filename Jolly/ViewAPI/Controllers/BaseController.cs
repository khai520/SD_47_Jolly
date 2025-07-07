using API.Data;
using API.HeThong; 
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using System.Reflection; 

namespace API.Controllers
{
    public abstract class BaseController<TModel, TModelDTO , Tkey> : Controller
        where TModel : class
        where TModelDTO : class
    {
        protected readonly IRepository<TModel, Tkey> _repository; 
        protected readonly DBAppContext _context;
        protected readonly IMapper _mapper;
        protected readonly XulyId _xulyId; 

        
        protected bool _useXulyIdGeneration = false; 
        protected string _idPrefix = null;          
        protected string _idColumnName = null;      

        public BaseController(
            IRepository<TModel ,Tkey> repository, 
            DBAppContext context,
            IMapper mapper,
            XulyId xulyId 
        )
        {
            _repository = repository;
            _context = context;
            _mapper = mapper;
            _xulyId = xulyId;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TModelDTO>>> GetAll()
        {
            var result = await _repository.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<TModelDTO>>(result));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TModelDTO>> GetById([FromRoute] Tkey id)
        {
            if (id == null)
            {
                return BadRequest("ID không hợp lệ.");
            }

            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<TModelDTO>(entity));
        }

        [HttpPost]
        public async Task<ActionResult<TModel>> Create([FromBody] TModelDTO dto)
        {
            if (dto == null)
                return BadRequest("Dữ liệu không hợp lệ.");

            var model = _mapper.Map<TModel>(dto);

            
            if (_useXulyIdGeneration && !string.IsNullOrEmpty(_idPrefix) && !string.IsNullOrEmpty(_idColumnName))
            {
                var propertyInfo = typeof(TModel).GetProperty(_idColumnName, BindingFlags.Public | BindingFlags.Instance);

                if (propertyInfo == null || propertyInfo.PropertyType != typeof(string) || !propertyInfo.CanWrite)
                {
                    return StatusCode(500, $"Lỗi cấu hình: Thuộc tính '{_idColumnName}' không tồn tại, không phải kiểu string, hoặc không thể ghi.");
                }

                var newStringId = await _xulyId.GenerateIdAsync(
                    _idPrefix,
                    _context.Set<TModel>(),
                    _idColumnName
                );

                propertyInfo.SetValue(model, newStringId);
            }
            else if (_useXulyIdGeneration && (string.IsNullOrEmpty(_idPrefix) || string.IsNullOrEmpty(_idColumnName)))
            {
                return BadRequest("Cấu hình tạo ID chưa đầy đủ.");
            }

            await _repository.AddAsync(model);

            
            return Ok(model);
        }


        [HttpPut]
        public async Task<ActionResult<TModelDTO>> Update([FromBody] TModelDTO dto) 
        {
            await _repository.Update(_mapper.Map<TModel>(dto));
            return Ok(_mapper.Map<TModelDTO>(dto));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Tkey id) 
        {
            if (id == null)
            {
                return BadRequest("ID không hợp lệ.");
            }

            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            await _repository.Delete(id);
            return Ok();
        }
        [HttpGet("GenerateMonAnId")]
        public async Task<ActionResult<string>> GenerateMonAnId()
        {
            var id = await _xulyId.GenerateIdAsync("MA", _context.monAns, "Id");
            return Ok(id);
        }

    }
}