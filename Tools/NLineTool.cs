using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class NLineTool : AbstractTool
    {
        public override int MaxCount => 0;

        public NLineTool(Pen pen) : base(pen)
        {
        }
        
        public NLineTool(List<PointF> points, Pen pen) : base(points, pen)
        {
        
        }
        
        public override void Paint(Graphics graphics)
        {
            Figures.NLineFigure nLine = new Figures.NLineFigure();
            CommonParameter figureParameter = new CommonParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint
            };

            graphics.DrawLines(Pen, ((CommonReturn)nLine.Get(figureParameter)).Points);

        }
        public override void AddPoint(PointF point)
        {
            Points.Add(point);
        }
    }
}
