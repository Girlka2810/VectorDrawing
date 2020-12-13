using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.FactoriesTools
{
    class NLineFactoryTool : IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new NLineTool(pen);
        }
    }
}
