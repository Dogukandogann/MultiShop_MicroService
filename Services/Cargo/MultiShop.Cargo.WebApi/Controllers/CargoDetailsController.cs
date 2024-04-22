using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoDetailsDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _CargoDetailService;
        private readonly IMapper _mapper;

        public CargoDetailsController(ICargoDetailService CargoDetailService, IMapper mapper)
        {
            _CargoDetailService = CargoDetailService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CargoDetailList()
        {
            var values = _CargoDetailService.TgetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoDetailById(int id)
        {
            var values = _CargoDetailService.TgetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
        {
            _CargoDetailService.Tinsert(_mapper.Map<CargoDetail>(createCargoDetailDto));
            return Ok("Kargo detay ekleme işlemi başarılı");
        }
        [HttpDelete]
        public IActionResult RemoveCargoDetail(int id)
        {
            _CargoDetailService.Tdelete(id);
            return Ok("Kargo detay silme işlemi başarılı");
        }
        [HttpPut]
        public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
        {
            _CargoDetailService.Tupdate(_mapper.Map<CargoDetail>(updateCargoDetailDto));
            return Ok("Kargo detay güncelleme işlemi başarılı");
        }
    }
}
