using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBGCore.Product
{
    public class ProductPrice
    {
        private Product _product;
        private double _unitPrice;

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

        public double UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
                if (_unitPrice < 0.0)
                    _unitPrice = 0.0;
            }
        }

        public ProductPrice(Product product, double unitPrice)
        {
            Product = product;
            UnitPrice = unitPrice;
        }
    }
}
