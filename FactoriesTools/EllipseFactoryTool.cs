using System.Drawing;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Ellipse;

namespace VectorDrawing.FactoriesTools
{
    class EllipseFactoryTool: IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new EllipseTool(pen);
        }
    }
}
