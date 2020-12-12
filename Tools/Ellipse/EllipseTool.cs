using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools.Ellipse
{
   public  class EllipseTool : AbsractEllipse
    {
        public override int MaxCount => 2;

        public EllipseTool(Pen pen) : base(pen)
        {

        }
        
        public EllipseTool(List<PointF> points, Pen pen) : base(points,pen)
        {

        }

        public override void Paint(Graphics graphics)
        {
            EllipseFigure ellipse = new EllipseFigure();
            EllipseParameter figureParameter = new EllipseParameter
            {
                Center = Center,
                TemporaryPoint = TemporaryPoint,
                HorizontalRadius = Width,
                VerticalRadius = Height

            };
            graphics.DrawEllipse(Pen, ((EllipseReturn)ellipse.Get(figureParameter)).Rectangle);
        }
    }
}
