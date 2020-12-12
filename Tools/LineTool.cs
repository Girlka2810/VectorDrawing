using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;


namespace VectorDrawing.Tools
{
    public class LineTool : AbstractTool
    {

        public override int MaxCount => 2;

        public LineTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        public LineTool(Pen pen) : base(pen)
        {

        }

        

        public override void Paint(Graphics graphics)
        {
            Figures.LineFigure line = new Figures.LineFigure();
            CommonParameter figureParameter = new CommonParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint
            };
            graphics.DrawLines(Pen, ((CommonReturn)line.Get(figureParameter)).Points);
        }
    }
}
