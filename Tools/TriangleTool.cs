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
        private IFigure _figure;

        public TriangleTool(Pen pen) : base(pen)
        {
        }

        public TriangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            if (points.Count > 3)
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        public override void Paint(Graphics graphics)
        {
            TriangleFigure triangleFigure = new TriangleFigure();
            _figure = triangleFigure;
            FigureParameter figureParameter = GenerateParametrs();
            graphics.DrawPolygon(Pen, ((CommonReturn)triangleFigure.Get(figureParameter)).Points);
        }
        
        
        
        public override void AddPoint(PointF point)
        {
            if (Points.Count > 2)
            {
                Points.RemoveAt(2);
            }

            Points.Add(point);
        }

        protected override FigureParameter GenerateParametrs()
        {
            CommonParameter figureParameter = new CommonParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint,
            };
            return figureParameter;
        }
    }
}