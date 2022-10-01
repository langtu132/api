using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API2.Dtos.Products;
using API2.Services.ProductService;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
         _productService = productService;
            
        }     

        // Tra ve toan bo ds
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetProductDto>>>> Get()
        {
            return Ok(await _productService.GetAllProduct());
        }
        // Tra ve danh sach theo Id
        // [HttpGet("{id}")]

        // public ActionResult<Products> GetSingle(int id)
        // {
        //     return Ok(_productService.GetProductById(id));
        // }
        
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetProductDto>>>> AddProduct(AddProductDto newProduct)
        {
            
            return Ok(await _productService.AddProduct(newProduct));
        }

    }
}