
using System.Drawing;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;

namespace VectorDrawing.FactoriesTools
{
    class BrushFactoryTool: IFactoryTool
    {
        
        public AbstractTool Create(Pen pen)
        {
            return new BasicBrush(pen);
        }
    }
}
