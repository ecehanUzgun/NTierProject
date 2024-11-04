using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.FakeData
{
    public class ProductFakeData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product{ID=1, ProductName="Chai", UnitPrice=10, UnitsInStock=39, CategoryId=1},
            new Product{ID=2, ProductName="Chang", UnitPrice=19, UnitsInStock=17, CategoryId = 1}
        };
    }
}
