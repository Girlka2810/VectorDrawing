using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools.Lines
{
    public class NLine : AbstractLine
    {
        public override int MaxCount => 0;

        public NLine(Pen pen) : base(pen)
        {
            Figure = new NLineFigure();
        }
        
        public NLine(List<PointF> points, Pen pen) : base(points, pen)
        {
            Figure = new NLineFigure();
        }
        
        public override void Paint(Graphics graphics)
        {
            if (EndShapePoints.Length != 0)
            {
                graphics.DrawLines(Pen, EndShapePoints);
            }
            else
                graphics.DrawLines(Pen, ((CommonReturn)Figure.Get(GenerateParametrs())).Points);
        }
        public override void AddPoint(PointF point)
        {
            Points.Add(point);
        }

        
    }
}
