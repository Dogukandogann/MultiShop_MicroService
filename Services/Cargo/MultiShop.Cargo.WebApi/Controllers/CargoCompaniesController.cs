using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoCompanyDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCompaniesController : ControllerBase
    {
        private readonly ICargoCompanyService _cargoCompanyService;
        private readonly IMapper _mapper;

        public CargoCompaniesController(ICargoCompanyService cargoCompanyService, IMapper mapper)
        {
            _cargoCompanyService = cargoCompanyService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CargoCompanyList()
        {
            var values = _cargoCompanyService.TgetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto)
        {
            _cargoCompanyService.Tinsert(_mapper.Map<CargoCompany>(createCargoCompanyDto));
            return Ok("Kargo şirketi başarıyla oluşturuldu");
        }
        [HttpDelete]
        public IActionResult RemoveCargoCompany(int id)
        {
            _cargoCompanyService.Tdelete(id);
            return Ok("Kargo şirketi başarıyla silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoCompanyById(int id)
        {
            var values = _cargoCompanyService.TgetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto)
        {
            _cargoCompanyService.Tupdate(_mapper.Map<CargoCompany>(updateCargoCompanyDto));
            return Ok("Kargo şirketi başarıyla güncellendi");
        }

    }
}
