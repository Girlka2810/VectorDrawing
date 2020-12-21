using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;

namespace VectorDrawing.Tools
{
    public class SquareTool : AbstractTool
    {
        public override int MaxCount => 2;
        public override void AddPoint(PointF point)
        {
            if (Points.Count > 3)
            {
                Points.RemoveAt(3);
            }

            Points.Add(point);
        }

        public SquareTool(Pen pen) : base(pen)
        {
            Figure = new SquareFigure();
        }

        
        public SquareTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            Figure = new SquareFigure();
            if (points.Count > 4)
            {
                throw new IndexOutOfRangeException();
            }
            EndShapePoints = points.ToArray();
            if (EndShapePoints.Length > 2)
            {
                Path.AddPolygon(EndShapePoints);
            }
        }

    }
}