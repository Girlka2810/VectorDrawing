using System.Drawing;
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
