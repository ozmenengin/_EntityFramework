using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
        
    {
        IProductDal _iProductDal;
        public ProductManager(IProductDal productDal)
        {
            _iProductDal = productDal;
        }
        public List<Product> GetAll()
        {
            //iş kodu
            //şartlar vs
            //InMemoryProductDal ınMemoryProductDal = new InMemoryProductDal();//yanlışşşşşş iş sınıfı iş sınıfını cagırmaz 
            return _iProductDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _iProductDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _iProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _iProductDal.GetProductDetails();
        }
    }
}
