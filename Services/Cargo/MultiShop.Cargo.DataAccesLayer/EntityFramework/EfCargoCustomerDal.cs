using MultiShop.Cargo.DataAccesLayer.Abstract;
using MultiShop.Cargo.DataAccesLayer.Concrete;
using MultiShop.Cargo.DataAccesLayer.Repositories;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccesLayer.EntityFramework
{
    public class EfCargoCustomerDal :GenericRepository<CargoCustomer>,ICargoCustomerDal
    {
        private readonly CargoContext _context;

        public EfCargoCustomerDal(CargoContext context) : base(context)
        {
            _context = context;
        }

        public CargoCustomer GetCargoCustomerById(string id)
        {
            var values = _context.CargoCustomers.Where(x=>x.UserCustomerId.Equals(id)).FirstOrDefault();
            return values;
        }
    }
}
