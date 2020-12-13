using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.FactoriesTools
{
    public class IsoscelesTriangleFactoryTool : IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new IsoscelesTriangleTool(pen);
        }
    }
}