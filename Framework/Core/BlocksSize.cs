using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
    public struct BlocksSize
    {
        public double WidthBlocks;
        public double LengthBlocks;
        public double HeightBlocks;

        public double Area { get { return WidthBlocks * LengthBlocks; } }
        public double Volume { get { return WidthBlocks * LengthBlocks * HeightBlocks; } }
    }
}
