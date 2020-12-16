
using System;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    public class SquareFigure : IFigure
    {
        private float Module(float n)
        {
            return n < 0 ? n * -1 : n;
        }

        public FigureReturn Get(FigureParameter parameter)
        {
            if (parameter is CommonParameter figureParameter)
            {
                PointF prev = figureParameter.Points[0];
                PointF crnt = figureParameter.TemporaryPoint;
                PointF[] points = new PointF[4];

                float width = Module(prev.X - crnt.X);
                float height = Module(prev.Y - crnt.Y);
                if (width >= height)
                {
                    crnt.Y = crnt.Y >= prev.Y ? prev.Y + width : prev.Y - width;
                }
                else
                    crnt.X = crnt.X >= prev.X ? prev.X + height : prev.X - height;

                points = new []
                {
                    prev,
                    new PointF(crnt.X, prev.Y),
                    crnt,
                    new PointF(prev.X, crnt.Y),
                };
                return new CommonReturn() {Points = points};
            }

            return new CommonReturn();
        }
    }
}