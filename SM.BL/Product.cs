using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public decimal? CurrrentPrice { get; set;  }
        public string ProductDecription { get; set; }
        public int ProductLength { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        //retrieve product
        public Product Retrieve(int productId)
        {
            return new Product();
        }
        //save product
        public bool Save()
        {
            return true;
        }
        //Validate product
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrrentPrice == null) isValid = false;

            return isValid;
        }
    }
}

