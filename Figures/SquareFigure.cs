using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                PointF[] points;

                float width = Module(prev.X - crnt.X);
                float height = Module(prev.Y - crnt.Y);
                if (width >= height)
                {
                    crnt.X = crnt.X >= prev.X ? prev.X + height : prev.X - height;
                }
                else
                    crnt.Y = crnt.Y >= prev.Y ? prev.Y + width : prev.Y - width;

                points = new PointF[]
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