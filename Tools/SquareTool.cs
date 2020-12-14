
using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class SquareTool : AbstractTool
    {

        public override int MaxCount => 4;
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

        }

        
        public SquareTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public override void Paint(Graphics graphics)
        {
            Figures.SquareFigure square = new Figures.SquareFigure();
            CommonParameter figureParameter = new CommonParameter
            {
                Points = this.Points.ToArray(),
                TemporaryPoint = this.TemporaryPoint
            };
            PointF[] pointsArr = ((CommonReturn)square.Get(figureParameter)).Points;
            graphics.DrawPolygon(Pen, pointsArr);
            Points = new List<PointF>();
            for (int i = 0; i < pointsArr.Length; i++)
            {
                AddPoint(pointsArr[i]);
            }
        }

        public void Update(Graphics graphics)
        {
            graphics.DrawPolygon(Pen, Points.ToArray());
        }

        public override FigureParameter GenerateParametrs()
        {
            throw new NotImplementedException();
        }
    }
}