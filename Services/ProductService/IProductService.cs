using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API2.Dtos.Products;

namespace API2.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<GetProductDto>>> GetAllProduct();

        // Products GetProductById(int id);

        Task<ServiceResponse<List<GetProductDto>>> AddProduct(AddProductDto newProduct);
    }
}