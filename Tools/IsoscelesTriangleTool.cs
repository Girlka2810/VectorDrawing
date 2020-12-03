using System.Drawing;

namespace VectorDrawing.Tools
{
    public class IsoscelesTriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 2;
        public IsoscelesTriangleTool(Pen pen) : base(pen)
        {
        }

        
        public override void Paint(Graphics graphics)
        {
            throw new System.NotImplementedException();
        }
    }
}