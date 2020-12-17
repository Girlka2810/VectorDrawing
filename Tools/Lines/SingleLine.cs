using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools.Lines
{
    public class SingleLine : AbstractLine
    {
        public override int MaxCount => 2;

        public SingleLine(List<PointF> points, Pen pen) : base(points, pen)
        {
            Figure = new LineFigure();
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        public SingleLine(Pen pen) : base(pen)
        {
            Figure = new LineFigure();
        }

        public override void Paint(Graphics graphics)
        {
            graphics.DrawLines(Pen, ((CommonReturn)Figure.Get(GenerateParametrs())).Points);
        }

        
    }
}
