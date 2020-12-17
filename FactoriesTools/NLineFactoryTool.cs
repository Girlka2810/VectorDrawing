using System.Drawing;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Lines;

namespace VectorDrawing.FactoriesTools
{
    class NLineFactoryTool : IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new NLine(pen);
        }
    }
}
