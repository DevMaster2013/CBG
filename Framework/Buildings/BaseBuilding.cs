using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Buildings
{
    public abstract class BaseBuilding
    {
        protected string _buildingName;
        protected BlocksSize _buildingSize;

        public BaseBuilding(string buildingName, BlocksSize size)
        {
            _buildingName = buildingName;
            _buildingSize = size;
        }

        public void update(double elapsedSeconds)
        {
            onUpdate(elapsedSeconds);
        }

        protected virtual void onUpdate(double elapsedSeconds) { }

        public string BuildingName { get { return _buildingName; } }
        public BlocksSize BuildingSize { get { return _buildingSize; } }
    }
}
