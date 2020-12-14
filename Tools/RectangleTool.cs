using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class RectangleTool : AbstractTool
    {
        public override int MaxCount => 2;

        public RectangleTool(Pen pen) : base(pen)
        {
            Figure = new RectangleFigure();
        }
        
        public RectangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            Figure = new RectangleFigure();
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }
        public override void Paint(Graphics graphics)
        {

            graphics.DrawPolygon(Pen, ((CommonReturn)Figure.Get(GenerateParametrs())).Points);
        }

       
    }
}
