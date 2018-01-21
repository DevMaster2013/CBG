using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
using Framework.Core.Enums;

namespace Framework.Production.Agriculture.Crops
{
    public class Wheat : BaseCrop
    {
        public Wheat() : base("Wheat", Season.Winter, 10.0, 2.0)
        {
        }
    }
}
