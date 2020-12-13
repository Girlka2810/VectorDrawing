using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.FactoriesTools
{
    public interface IFactoryTool
    {
        AbstractTool Create(Pen pen);
    }
}