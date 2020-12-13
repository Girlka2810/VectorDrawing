using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Polygons;

namespace VectorDrawing.FactoriesTools
{
    class RegularPolygonFactoryTool: IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new RegularPolygonTool(pen);
        }
    }
}
