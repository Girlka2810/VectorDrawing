
using System.Drawing;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Lines;

namespace VectorDrawing.FactoriesTools
{
    class LineFactoryTool:IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new SingleLine(pen);
        }
    }
}
