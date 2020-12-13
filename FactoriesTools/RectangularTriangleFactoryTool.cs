using VectorDrawing.Tools;
using VectorDrawing.Tools.Polygons;
using System.Drawing;


namespace VectorDrawing.FactoriesTools
{
    class RectangularTriangleFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new RectangularTriangleTool(pen);
        }
    }
}
