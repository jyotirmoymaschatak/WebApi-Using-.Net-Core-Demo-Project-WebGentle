using System.Collections.Generic;
using WebApi_Demo_From_WebGentle.Models;

namespace WebApi_Demo_From_WebGentle.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();
        string GetName();
    }
}