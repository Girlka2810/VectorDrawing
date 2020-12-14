using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;


namespace VectorDrawing.Tools
{
    public class LineTool : AbstractTool
    {
        public override int MaxCount => 2;

        public LineTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            Figure = new LineFigure();
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        public LineTool(Pen pen) : base(pen)
        {
            Figure = new LineFigure();
        }

        public override void Paint(Graphics graphics)
        {
            graphics.DrawLines(Pen, ((CommonReturn)Figure.Get(GenerateParametrs())).Points);
        }

        
    }
}
