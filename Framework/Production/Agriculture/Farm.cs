using Framework.Core;
using Framework.Production.Agriculture.Crops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Production.Agriculture
{
    public class Farm : ProductionBuilding
    {
        protected BaseCrop _farmCurrentCrop;

        public Farm() : base("Farm", new BlocksSize() { WidthBlocks = 4.0, LengthBlocks = 8.0, HeightBlocks = 2.0 })
        {
            _farmCurrentCrop = null;
        }
        
        protected override void onProductionRoundFinished()
        {
            if (_farmCurrentCrop == null)
                return;
            _totalProduction += _farmCurrentCrop.ProductsPerBlock * _buildingSize.Area;
        }

        protected override void onProductionStarted()
        {
            if (_farmCurrentCrop == null)
            {
                _productionStarted = false;
                return;
            }
            _productionRoundTime = _farmCurrentCrop.GrowthTime;
        }        

        public BaseCrop CurrentCrop { get { return _farmCurrentCrop; } set { _farmCurrentCrop = value; } }       
    }
}
