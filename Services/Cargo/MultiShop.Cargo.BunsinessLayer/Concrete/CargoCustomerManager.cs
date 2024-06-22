﻿using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccesLayer.Abstract;
using MultiShop.Cargo.DataAccesLayer.EntityFramework;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoCustomerManager : ICargoCustomerService
    {
        private readonly ICargoCustomerDal _cargoCustomerDal;

        public CargoCustomerManager(ICargoCustomerDal cargoCustomerDal)
        {
            _cargoCustomerDal = cargoCustomerDal;
        }

        public void Tdelete(int id)
        {
            _cargoCustomerDal.Delete(id);
        }

        public List<CargoCustomer> TgetAll()
        {
            return _cargoCustomerDal.GetAll();
        }

        public CargoCustomer TgetById(int id)
        {
            return _cargoCustomerDal.GetById(id);
        }

        public CargoCustomer TGetCargoCustomerById(string id)
        {
            return _cargoCustomerDal.GetCargoCustomerById(id);
        }

        public void Tinsert(CargoCustomer entity)
        {
            _cargoCustomerDal.Insert(entity);
        }

        public void Tupdate(CargoCustomer entity)
        {
            _cargoCustomerDal.Update(entity);
        }
    }
}
