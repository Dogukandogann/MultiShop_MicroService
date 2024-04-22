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
    public class CargoOperationManager : ICargoOperationService
    {
        private readonly ICargoOperationDal _cargoOperationDal;

        public CargoOperationManager(ICargoOperationDal cargoOperationDal)
        {
            _cargoOperationDal = cargoOperationDal;
        }

        public void Tdelete(int id)
        {
            _cargoOperationDal.Delete(id);
        }

        public List<CargoOperation> TgetAll()
        {
            return _cargoOperationDal.GetAll();
        }

        public CargoOperation TgetById(int id)
        {
            return _cargoOperationDal.GetById(id);
        }

        public void Tinsert(CargoOperation entity)
        {
            _cargoOperationDal.Insert(entity);
        }

        public void Tupdate(CargoOperation entity)
        {
            _cargoOperationDal.Update(entity);
        }
    }
}
