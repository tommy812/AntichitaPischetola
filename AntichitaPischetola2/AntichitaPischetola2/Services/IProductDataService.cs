using AntichitaPischetola2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AntichitaPischetola2.Services
{
    interface IProductDataService
    {
        List<ProductsModel> GetAllProducts();
        List<ProductsModel> SearchProducts(string searchTerm);
        ProductsModel GetProductByID(int Id);
        int Insert(ProductsModel product);
        int Delete(ProductsModel product);
        int Update(ProductsModel product);


    }
}
