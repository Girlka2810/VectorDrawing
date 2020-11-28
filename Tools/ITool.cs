using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorDrawing.Tools
{
    interface ITool
    {
        void Paint(Point prev, Point crnt);
        
    }
}
