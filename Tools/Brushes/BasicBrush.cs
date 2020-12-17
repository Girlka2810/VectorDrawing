using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures.Parameters;

namespace VectorDrawing.Tools.Brushes
{
    public class BasicBrush : AbstractTool, IBrush
    {
        public override int MaxCount { get; } = 0;
        
        public BasicBrush(Pen pen) : base(pen)
        {
            
        }
        
        public BasicBrush(List<PointF> points, Pen pen) : base(points, pen)
        {

        }

       
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

        public override void SavePoints()
        {
            EndShapePoints = Points.ToArray();
            Points = null;
            CalculateCenter();
        }
    }
}