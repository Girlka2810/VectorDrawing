using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures.Parameters;

namespace VectorDrawing.Tools.Brushes
{
    public class BasicBrush : AbstractTool, IBrush
    {
        public BasicBrush(Pen pen) : base(pen)
        {
        }
        
        public BasicBrush(List<PointF> points, Pen pen) : base(points, pen)
        {

        }

        public override int MaxCount { get; } = 0;
        public override void Paint(Graphics graphics)
        {
            if (Points.Count != 1)
            {
                graphics.DrawLines(Pen, Points.ToArray());
            }
        }

        public override void AddPoint(PointF point)
        {
            Points.Add(point);
        }

        protected override FigureParameter GenerateParametrs()
        {
            throw new System.NotImplementedException();
        }
    }
}