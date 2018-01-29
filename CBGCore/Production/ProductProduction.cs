using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBGCore.Production
{
    public class ProductProduction
    {
        private Product.Product _product;
        private List<Product.ProductQuantity> _ingredients;
        private double _productionTime;
        private long _priority;

        public Product.Product Product
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

        public List<Product.ProductQuantity> Ingredients
        {
            get
            {
                return _ingredients.ToList();
            }
        }

        public double ProductionTime
        {
            get
            {
                return _productionTime;
            }
            set
            {
                _productionTime = value;
                if (_productionTime < 0.0)
                    _productionTime = 0.0;
            }
        }

        public long Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
                if (_priority < 0)
                    _priority = 0;
            }
        }

        public ProductProduction(Product.Product product, double productionTime, List<Product.ProductQuantity> ingredients, long priority)
        {
            Product = product;
            ProductionTime = productionTime;
            Priority = priority;
            _ingredients = new List<CBGCore.Product.ProductQuantity>(ingredients);
        }
    }
}
