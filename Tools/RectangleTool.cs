using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    class RectangleTool : AbstractTool
    {
        public override int MaxCount => 2;

        public RectangleTool(Pen pen) : base(pen)
        {

        }
        public override void Paint(Graphics graphics)
        {
            Figures.RectangleFigure rectangle = new Figures.RectangleFigure();
            Figures.FigureParameter figureParameter = new Figures.FigureParameter
            {
                Points = this.Points.ToArray(),
                TemporaryPoint = this.TemporaryPoint
            };
            graphics.DrawPolygon(Pen, rectangle.GetPoints(figureParameter));
        }
    }
}
