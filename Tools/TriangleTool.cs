﻿using System.Drawing;
using VectorDrawing.Figures;

namespace VectorDrawing.Tools
{
    public class TriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 3;
        
        public TriangleTool(Pen pen) : base(pen)
        {
        }

        
        public override void Paint(Graphics graphics)
        {
            TriangleFigure triangleFigure = new TriangleFigure();
            FigureParameter figureParameter = new FigureParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint,
            };
            graphics.DrawPolygon(Pen, triangleFigure.GetPoints(figureParameter));
        }
        
        public override void AddPoint(Point point)
        {
            if (Points.Count > 2)
            {
                Points.RemoveAt(2);
            }

            Points.Add(point);
        }
    }
}