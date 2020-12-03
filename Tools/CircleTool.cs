﻿using System.Drawing;


namespace VectorDrawing.Tools
{
    public class CircleTool : AbstractTool
    {
        public override int MaxCount => 2;

        public CircleTool(Pen pen) : base(pen)
        {

        }

        public override void Paint(Graphics graphics)
        {
            Figures.CircleFigure circle = new Figures.CircleFigure();
            Figures.FigureParameter figureParameter = new Figures.FigureParameter
            {
                Points = this.Points.ToArray(),
                TemporaryPoint = this.TemporaryPoint
            };
            graphics.DrawEllipse(Pen, circle.GetCircumscribedRectangle(figureParameter));
        }

    }
}
