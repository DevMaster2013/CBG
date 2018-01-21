using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Production.Agriculture.Crops
{
    public abstract class BaseCrop
    {
        protected string _cropName;
        protected Season _validSeason;
        protected double _growthTime;
        protected double _productsPerBlock;

        public BaseCrop(string cropName, Season validSeason, double growthTime, double productsPerBlock)
        {
            _cropName = cropName;
            _validSeason = validSeason;
            _growthTime = growthTime;
            _productsPerBlock = productsPerBlock;
        }

        public string CropName { get { return _cropName; } }
        public Season ValidSeason { get { return _validSeason; } }
        public double GrowthTime { get { return _growthTime; } }
        public double ProductsPerBlock { get { return _productsPerBlock; } }
    }
}
