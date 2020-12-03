using System.Drawing;

namespace VectorDrawing.Tools
{
    public class RectangularTriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 2;
        
        public RectangularTriangleTool(Pen pen) : base(pen)
        {
        }
        
        public override void Paint(Graphics graphics)
        {
            throw new System.NotImplementedException();
        }
    }
}