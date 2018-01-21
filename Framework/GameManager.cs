using Framework.Buildings;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class GameManager
    {
        private List<BaseBuilding> _gameBuildings = new List<BaseBuilding>();

        public void updateGame(double elapsedSeconds)
        {
            GameTime.updateTime(elapsedSeconds);
            foreach (BaseBuilding building in _gameBuildings)
                building.update(elapsedSeconds);
        }

        public List<BaseBuilding> Buildings { get { return _gameBuildings; } }
    }
}
