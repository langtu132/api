using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Models
{
    public class Products
    {
        public int Id {get; set; }

        public string Name {get; set;} = "Ten San Pham";

        public int Cost {get; set;} = 100;

        public int Pay {get; set;} = 150;

         public TypeProduct Class { get; set ;} = TypeProduct.Milk;
    }
}