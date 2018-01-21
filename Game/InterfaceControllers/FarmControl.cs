using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Production.Agriculture;
using Framework.Production.Agriculture.Crops;

namespace Game.InterfaceControllers
{
    public partial class FarmControl : UserControl
    {
        private Farm _farm = null;

        public FarmControl()
        {
            InitializeComponent();
        }

        public void update(double elapsedSeconds)
        {
            if (_farm == null) return;

            productionInfo.update(elapsedSeconds);
            if (_farm.CurrentCrop != null) txtCurrentCropName.Text = _farm.CurrentCrop.CropName;
            btnChangeCrop.Enabled = !_farm.ProductionInProgress;
        }

        public Farm Farm
        {
            get { return _farm; }
            set
            {
                _farm = value;
                if (_farm == null) return;
                txtName.Text = _farm.BuildingName;
                blkszFarmSize.BlockSize = _farm.BuildingSize;
                productionInfo.ProductionBuilding = value;
            }
        }

        private void btnChangeCrop_Click(object sender, EventArgs e)
        {
            if (cmbCrops.SelectedIndex == 0)
                _farm.CurrentCrop = new Wheat();
        }
    }
}
