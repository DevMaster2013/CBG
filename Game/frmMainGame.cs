using Framework;
using Framework.Core;
using Framework.Production.Agriculture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class frmMainGame : Form
    {
        private GameManager _gameManager = new GameManager();

        public frmMainGame()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            double elapsedSeconds = gameTimer.Interval / 1000.0;
            _gameManager.updateGame(elapsedSeconds);
            farmControl.update(elapsedSeconds);
            txtCurrentGameTime.Text = GameTime.CurrentTime.ToString();
        }

        private void cmdBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdBuildings.SelectedIndex == 0)
            {
                txtBuildingName.Text = "Farm";
                blkszBuildingSize.BlockSize = new Framework.Core.BlocksSize() { WidthBlocks = 4.0, LengthBlocks = 8.0, HeightBlocks = 2.0 };
            }
        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            if (cmdBuildings.SelectedIndex == 0)
            {
                Farm newFarm = new Farm();
                _gameManager.Buildings.Add(newFarm);
                lstBuildings.Items.Add(newFarm);
            }
        }

        private void lstBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBuildings.SelectedIndex >= 0)
            {
                farmControl.Farm = (Farm)lstBuildings.Items[lstBuildings.SelectedIndex];
            }
        }
    }
}
