using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class TriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 3;

        public TriangleTool(Pen pen) : base(pen)
        {
            Figure = new TriangleFigure(); 
        }

        public TriangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            Figure = new TriangleFigure(); 
            if (points.Count > 3)
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        public override void AddPoint(PointF point)
        {
            if (Points.Count > 2)
            {
                Points.RemoveAt(2);
            }

            Points.Add(point);
        }

        
    }
}