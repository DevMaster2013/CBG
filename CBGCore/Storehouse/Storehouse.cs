using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBGCore.Product;

namespace CBGCore.Storehouse
{
    public class Storehouse
    {
        private List<ProductQuantity> _storedProducts;
        private long _storeCapacity;

        public List<ProductQuantity> StoredProducts
        {
            get
            {
                return _storedProducts.ToList();
            }
        }

        public long StoreCapacity
        {
            get
            {
                return _storeCapacity;
            }
            set
            {
                _storeCapacity = value;
                if (_storeCapacity < 0)
                    _storeCapacity = 0;
            }
        }

        public long StoreAvailable
        {
            get
            {
                return StoreCapacity - StoreConsumned;
            }
        }

        public long StoreConsumned
        {
            get
            {
                long amount = 0;
                foreach (var storeProduct in _storedProducts)
                    amount += storeProduct.Quantity;
                return amount;
            }
        }        

        public Storehouse(long storeCapacity)
        {
            StoreCapacity = storeCapacity;
            _storedProducts = new List<ProductQuantity>();
        }

        public Product.ProductQuantity getProductQuantity(Product.Product product)
        {
            return (from pr in _storedProducts
                    where pr.Product == product
                    select pr).FirstOrDefault();
        }

        public void addToStore(Product.ProductQuantity productQuanity)
        {
            var product = getProductQuantity(productQuanity.Product);

            if (product != null)
                product.Quantity += productQuanity.Quantity;
            else
                _storedProducts.Add(productQuanity);
        }

        public void removeFromStore(Product.ProductQuantity productQuanity)
        {
            var product = getProductQuantity(productQuanity.Product);
            if (product != null)
                product.Quantity -= productQuanity.Quantity;
        }
    }
}
