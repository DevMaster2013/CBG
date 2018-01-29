using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBGCore.Storehouse;

namespace CBGCore.Government
{
    public class City
    {
        private string _cityName;
        private double _cityBudget;
        private List<Storehouse.Storehouse> _globalStorehouses;

        public string CityName
        {
            get
            {
                return _cityName;
            }
            set
            {
                _cityName = value;
            }
        }

        public double CityBudget
        {
            get
            {
                return _cityBudget;
            }
            set
            {
                _cityBudget = value;
            }
        }

        public List<Storehouse.Storehouse> GlobalStorehouses
        {
            get
            {
                return _globalStorehouses.ToList();
            }
        }

        public Product.ProductQuantity getProductQuantity(Product.Product product)
        {
            Product.ProductQuantity productQuanity = new Product.ProductQuantity(product, 0);
            productQuanity.Quantity = ( from store in _globalStorehouses
                                        from pr in store.StoredProducts
                                        where pr.Product == product
                                        select pr.Quantity).Sum();
            return productQuanity;
        }

        public City(string cityName, double cityBudget)
        {
            CityName = cityName;
            CityBudget = CityBudget;
            _globalStorehouses = new List<Storehouse.Storehouse>();
        }

        public void addGlobalStorehouse(Storehouse.Storehouse storeHouse)
        {
            if (!_globalStorehouses.Contains(storeHouse))
                _globalStorehouses.Add(storeHouse);
        }

        public void removeGlobalStorehouse(Storehouse.Storehouse storeHouse)
        {
            if (_globalStorehouses.Contains(storeHouse))
                _globalStorehouses.Remove(storeHouse);
        }
    }
}
