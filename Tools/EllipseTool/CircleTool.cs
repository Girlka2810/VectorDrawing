using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Tools;


namespace VectorDrawing.Tools
{
    public class CircleTool : AbsractEllipse
    {
        public override int MaxCount => 2;

        public CircleTool(Pen pen) : base(pen)
        {

        }

        public override void Paint(Graphics graphics)
        {
            CircleFigure circle = new CircleFigure();
            EllipseFigureParameter figureParameter = new EllipseFigureParameter
            {
                Center = this.Center,
                TemporaryPoint = this.TemporaryPoint
            };
            graphics.DrawEllipse(Pen, circle.GetRectangle(figureParameter));
        }

    }
}




