using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Production;

namespace Game.InterfaceControllers.UtilityControls
{
    public partial class ProductionInfoControl : UserControl
    {
        private ProductionBuilding _productionBuilding = null;

        public ProductionInfoControl()
        {
            InitializeComponent();
        }

        public void update(double elapsedSeconds)
        {
            if (_productionBuilding == null) return;

            txtProductionRate.Text = _productionBuilding.ProductionRate.ToString();
            txtTotalProduction.Text = _productionBuilding.TotalProduction.ToString();
            txtTotalRunningTime.Text = _productionBuilding.TotalRunningTime.ToString();

            if (_productionBuilding.ProductionInProgress)
            {
                int progressValue = (int)((_productionBuilding.TotalRoundTime / _productionBuilding.ProductionRoundTime) * 100.0);
                prgProductinoProgress.Value = progressValue;
            }
            else
                prgProductinoProgress.Value = 0;
        }

        public ProductionBuilding ProductionBuilding { get { return _productionBuilding; } set { _productionBuilding = value; } }

        private void btnStartProduction_Click(object sender, EventArgs e)
        {
            if (_productionBuilding == null)
                return;
            _productionBuilding.startProduction();
        }

        private void btnStopProduction_Click(object sender, EventArgs e)
        {
            if (_productionBuilding == null)
                return;
            _productionBuilding.stopProduction();
        }
    }
}
