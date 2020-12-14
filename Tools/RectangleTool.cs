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
        private IFigure _figure;

        public RectangleTool(Pen pen) : base(pen)
        {

        }
        
        public RectangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }
        public override void Paint(Graphics graphics)
        {
            RectangleFigure rectangle = new RectangleFigure();
            _figure = rectangle;
            FigureParameter figureParameter = GenerateParametrs();
            graphics.DrawPolygon(Pen, ((CommonReturn)rectangle.Get(figureParameter)).Points);
        }

        protected override FigureParameter GenerateParametrs()
        {
            CommonParameter figureParameter = new CommonParameter
            {
                Points = this.Points.ToArray(),
                TemporaryPoint = this.TemporaryPoint
            };
            return figureParameter;
        }
    }
}
