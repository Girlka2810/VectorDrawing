using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Figures;

namespace VectorDrawing.Tools
{
    class EllipseTool : AbsractEllipse
    {
        public override int MaxCount => 2;

        public EllipseTool(Pen pen) : base(pen)
        {

        }

        public override void Paint(Graphics graphics)
        {
            EllipseFigure ellipse = new EllipseFigure();
            EllipseFigureParameter figureParameter = new EllipseFigureParameter
            {
                Center = this.Center,
                TemporaryPoint = this.TemporaryPoint,
                HorizontalRadius = this.HorizontalRadius,
                VerticalRadius = this.VerticalRadius

            };
            graphics.DrawEllipse(Pen, ellipse.GetRectangle(figureParameter));
        }
    }
}
