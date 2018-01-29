using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBGCore.Product
{
    public class ProductQuantity
    {
        private Product _product;
        private long _quantity;

        public Product Product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
            }
        }

        public long Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                if (_quantity < 0)
                    _quantity = 0;
            }
        }

        public ProductQuantity(Product product, long quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
