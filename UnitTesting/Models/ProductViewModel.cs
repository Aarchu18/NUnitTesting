using System.Collections.Generic;

namespace UnitTesting.Models
{
    public class ProductViewModel
    {
        public IEnumerable<ProductList> ProductItems { get; set; }
        public int ProductTotal { get; set; }
        public int ProductDiscount { set; get; }
    }
}
