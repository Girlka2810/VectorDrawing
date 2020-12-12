using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools.Ellipse
{
    public class CircleTool : AbsractEllipse
    {
        public override int MaxCount => 2;

        public CircleTool(Pen pen) : base(pen)
        {

        }
        
        public CircleTool(List<PointF> points, Pen pen) : base(points,pen)
        {

        }
        
        
        public override void Paint(Graphics graphics)
        {
            CircleFigure circle = new CircleFigure();
            EllipseParameter figureParameter = new EllipseParameter
            {
                Center = Center,
                TemporaryPoint = TemporaryPoint
            };
            graphics.DrawEllipse(Pen, ((EllipseReturn)circle.Get(figureParameter)).Rectangle);
        }

    }
}




