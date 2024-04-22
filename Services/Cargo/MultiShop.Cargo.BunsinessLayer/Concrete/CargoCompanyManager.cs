using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccesLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoCompanyManager : ICargoCompanyService
    {
        private readonly ICargoCompanyDal _cargoCompanyDal;

        public CargoCompanyManager(ICargoCompanyDal cargoCompanyDal)
        {
            _cargoCompanyDal = cargoCompanyDal;
        }

        public void Tdelete(int id)
        {
            _cargoCompanyDal.Delete(id);
        }

        public List<CargoCompany> TgetAll()
        {
            return _cargoCompanyDal.GetAll();
        }

        public CargoCompany TgetById(int id)
        {
            return _cargoCompanyDal.GetById(id);
        }

        public void Tinsert(CargoCompany entity)
        {
            _cargoCompanyDal.Insert(entity);
        }

        public void Tupdate(CargoCompany entity)
        {
            _cargoCompanyDal.Update(entity);
        }
    }
}
