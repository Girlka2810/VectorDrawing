using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Figures;

namespace VectorDrawing.Tools
{
    class EllipseTool : AbstractTool
    {
        public override int MaxCount => 2;

        public override void Paint(Graphics graphics)
        {
            EllipseFigure ellipseFigure = new EllipseFigure();
            FigureParameter figureParameter = new FigureParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint,
            };
            graphics.DrawPolygon(Pen, ellipseFigure.GetPoints(figureParameter));
        }
        public EllipseTool(Pen pen) : base(pen)
        {
        }
    }
}
