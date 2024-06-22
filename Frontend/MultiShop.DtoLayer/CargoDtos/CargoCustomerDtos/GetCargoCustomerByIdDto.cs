using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.DtoLayer.CargoDtos.CargoCustomerDtos
{
    public class GetCargoCustomerByIdDto
    {
        public int CargoCustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerDistrict { get; set; }
        public string? UserCustomerId { get; set; }
    }
}
