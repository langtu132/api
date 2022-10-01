using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API2.Dtos.Products;

namespace API2.Services.ProductService
{
   public class ProductService : IProductService
   {
        private static List<Products> products = new List<Products>{
            new Products(),
            new Products {Id = 1, Name = "Charlie Hau Nguuyen"}
        };

      public async Task<ServiceResponse<List<GetProductDto>>> AddProduct(AddProductDto newProduct)
      {
            var servicesResponse = new ServiceResponse<List<GetProductDto>>();
            products.Add(newProduct);
            servicesResponse.Data = products;
            return servicesResponse;
      }

      public async Task<ServiceResponse<List<GetProductDto>>> GetAllProduct()
      {
         return new ServiceResponse<List<GetProductDto>> {Data = products};
      }

    //   public Products GetProductById(int id)
    //   {
    //     return products.FirstOrDefault(c => c.Id == id);
    //   }
   }
}