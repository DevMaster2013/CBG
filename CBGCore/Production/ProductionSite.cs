using CBGCore.Government;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBGCore.Production
{
    public class ProductionSite : Building
    {
        public static long DefaultProductionSiteInternalStorehouseCapacity = 1000;

        private Storehouse.Storehouse _internalStorehouse;
        private List<ProductProduction> _productions;        

        public Storehouse.Storehouse InternalStorehouse
        {
            get
            {
                return _internalStorehouse;
            }
        }

        public List<ProductProduction> Productions
        {
            get
            {
                return _productions.ToList();
            }
        }

        public ProductionSite(string name)
            : base(name)
        {
            _internalStorehouse = new Storehouse.Storehouse(DefaultProductionSiteInternalStorehouseCapacity);
            _productions = new List<ProductProduction>();
        }
    }
}
