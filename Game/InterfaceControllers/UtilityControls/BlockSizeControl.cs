using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Core;

namespace Game.InterfaceControllers.UtilityControls
{
    public partial class BlockSizeControl : UserControl
    {
        private BlocksSize _blockSize = new BlocksSize() { HeightBlocks = 0, LengthBlocks = 0, WidthBlocks = 0 };

        public BlockSizeControl()
        {
            InitializeComponent();
        }

        public BlocksSize BlockSize
        {
            get
            {
                double.TryParse(txtWidth.Text, out _blockSize.WidthBlocks);
                double.TryParse(txtLength.Text, out _blockSize.LengthBlocks);
                double.TryParse(txtHeight.Text, out _blockSize.HeightBlocks);
                return _blockSize;
            }
            set
            {
                _blockSize = value;
                txtWidth.Text = _blockSize.WidthBlocks.ToString();
                txtLength.Text = _blockSize.LengthBlocks.ToString();
                txtHeight.Text = _blockSize.HeightBlocks.ToString();
            }
        }
        
        public bool ReadOnly
        {
            get
            {
                return txtWidth.ReadOnly;
            }
            set
            {
                txtWidth.ReadOnly = txtHeight.ReadOnly = txtLength.ReadOnly = value;
            }
        }
    }
}
