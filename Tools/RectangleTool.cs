using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            if (points.Count > 4)
            {
                throw new IndexOutOfRangeException();
            }
            EndShapePoints = points.ToArray();
        }

    }
}
