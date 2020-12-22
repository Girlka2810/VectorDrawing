using System.Collections.Generic;
using System.Drawing;


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
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            if (EndShapePoints.Length != 0)
            {
                graphics.DrawPath(Pen, Path);
            }
            else
            {
                if (Points.Count != 1)
                {
                    graphics.DrawLines(Pen, Points.ToArray());
                }
            }
        }

        public override void AddPoint(PointF point)
        {
            Points.Add(point);
        }

        public override void SavePoints()
        {
            if (EndShapePoints.Length == 0)
            {
                EndShapePoints = Points.ToArray();
            }
            Path.Reset();

            Path.AddLines(EndShapePoints);
            CalculateCenter();
            PenForSearching = new Pen(Pen.Color, Pen.Width + 10);
        }

    }
}