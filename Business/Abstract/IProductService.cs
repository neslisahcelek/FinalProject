using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllBycategoryId(int id);
        List<Product> GetbyUnitprice(decimal min, decimal max);
    }
}
