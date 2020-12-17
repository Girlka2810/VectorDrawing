using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class AbstractLine : AbstractTool
    {
        
        public override int MaxCount { get; }
        public AbstractLine(List<PointF> points, Pen pen) : base(points, pen)
        {
        }

        public AbstractLine(Pen pen) : base(pen)
        {
        }

        public override void Paint(Graphics graphics)
        {
            if (EndShapePoints.Length != 0)
            {
                graphics.DrawLines(Pen, EndShapePoints);
            }
            else
            {
                graphics.DrawLines(Pen, ((CommonReturn)Figure.Get(GenerateParametrs())).Points);
            }
        }
    }
}