﻿using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class RectangularTriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 2;
        private IFigure _figure;

        public RectangularTriangleTool(Pen pen) : base(pen)
        {
        }
        
        public RectangularTriangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        public override void Paint(Graphics graphics)
        {
            RectangularTriangleFigure rectangularTriangleFigure = new RectangularTriangleFigure();
            _figure = rectangularTriangleFigure;
            FigureParameter figureParameter = GenerateParametrs();
            graphics.DrawPolygon(Pen, ((CommonReturn)rectangularTriangleFigure.Get(figureParameter)).Points);
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