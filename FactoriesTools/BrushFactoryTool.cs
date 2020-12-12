using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;

namespace VectorDrawing.FactoriesTools
{
    class BrushFactoryTool: IFactoryTool
    {
        
        public AbstractTool Create(Pen pen)
        {
            return new BasicBrush(pen);
        }
    }
}
