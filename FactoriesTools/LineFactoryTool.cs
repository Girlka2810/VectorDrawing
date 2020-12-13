
using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.FactoriesTools
{
    class LineFactoryTool:IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new LineTool(pen);
        }
    }
}
