using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoOperationDetos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoOperationsController : ControllerBase
    {
        private readonly ICargoOperationService _CargoOperationService;
        private readonly IMapper _mapper;

        public CargoOperationsController(ICargoOperationService CargoOperationService, IMapper mapper)
        {
            _CargoOperationService = CargoOperationService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CargoOperationList()
        {
            var values = _CargoOperationService.TgetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoOperationById(int id)
        {
            var values = _CargoOperationService.TgetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCargoOperation(CreateCargoOperationDto createCargoOperationDto)
        {
            _CargoOperationService.Tinsert(_mapper.Map<CargoOperation>(createCargoOperationDto));
            return Ok("Kargo işlemi ekleme işlemi başarılı");
        }
        [HttpDelete]
        public IActionResult RemoveCargoOperation(int id)
        {
            _CargoOperationService.Tdelete(id);
            return Ok("Kargo işlemi silme işlemi başarılı");
        }
        [HttpPut]
        public IActionResult UpdateCargoOperation(UpdateCargoOperationDto updateCargoOperationDto)
        {
            _CargoOperationService.Tupdate(_mapper.Map<CargoOperation>(updateCargoOperationDto));
            return Ok("Kargo işlemi güncelleme işlemi başarılı");
        }
    }
}
