using Framework.Buildings;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Production
{
    public abstract class ProductionBuilding : BaseBuilding
    {
        protected double _totalRunningTime;
        protected double _productionRate;
        protected double _totalProduction;
        protected double _productionRoundTime;
        protected double _roundStartTime;
        protected double _totalRoundTime;
        protected bool _productionStarted;        

        public ProductionBuilding(string buildingName, BlocksSize size) : base(buildingName, size)
        {
            _totalRunningTime = 0.0;
            _productionRate = 0.0;
            _totalProduction = 0.0;
            _productionRoundTime = 0.0;
            _roundStartTime = 0.0;
            _totalRoundTime = 0.0;
            _productionStarted = false;
        }

        public void startProduction()
        {
            _productionStarted = true;
            _roundStartTime = GameTime.Seconds;
            _totalRoundTime = 0.0;

            onProductionStarted();            
        }

        public void stopProduction()
        {
            _productionStarted = false;
            onProductionStopped();
        }

        public void resumeProduction()
        {
            if (_productionStarted) return;
            _productionStarted = true;
            onProductionResumed();
        }

        protected override void onUpdate(double elapsedSeconds)
        {
            double elapsedGameTime = GameTime.Seconds;
            _totalRunningTime += elapsedGameTime;
            if (_productionStarted)
            {                
                _totalRoundTime += elapsedGameTime;
                onProductionIteration(elapsedGameTime);
                if (_totalRoundTime >= _productionRoundTime)
                {
                    _productionStarted = false;                    
                    onProductionRoundFinished();
                    _productionRate = (double)_totalProduction / _totalRunningTime;
                }
            }            
        }

        protected virtual void onProductionStarted() { }
        protected virtual void onProductionStopped() { }
        protected virtual void onProductionResumed() { }
        protected virtual void onProductionIteration(double elapsedTime) { }
        protected virtual void onProductionRoundFinished() { }

        public double TotalRunningTime { get { return _totalRunningTime; } }
        public double ProductionRate { get { return _productionRate; } }
        public double TotalProduction { get { return _totalProduction; } }
        public double ProductionRoundTime { get { return _productionRoundTime; } }
        public double RoundStartTime { get { return _roundStartTime; } }
        public double TotalRoundTime { get { return _totalRoundTime; } }
        public bool   ProductionInProgress { get { return _productionStarted; } }
    }
}
