using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.FactoriesTools
{
    class SquareFactoryTool : IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new SquareTool(pen);
        }
    }
}
