using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    public class RegularPolygonFigure : IFigure
    {
        public FigureReturn Get(FigureParameter parameter)
        {
            if (parameter is RegularPolygonParameter figureParameter)
            {
                PointF center = figureParameter.Center;
                PointF point = figureParameter.TemporaryPoint;
                int vertexes = figureParameter.QuantityOfCorners;
                PointF[] points = new PointF[vertexes];
                double angle = Math.PI * 2 / vertexes;
                float deltaX = Math.Abs(center.X - point.X);
                float deltaY = Math.Abs(center.Y - point.Y);
                double z = 0;
                Equalization(ref deltaX, ref deltaY);

                for (int i = 0; i < vertexes; i++)
                {
                    points[i].X = (float)(center.X - deltaX*Math.Sin(z));
                    points[i].Y = (float)(center.Y - deltaY*Math.Cos(z));
                    z = z + angle;
                }
                return new CommonReturn() {Points = points};
            }
            
            return new FigureReturn();
        }
        
        private void Equalization(ref float a, ref float b)
        {
            if (a >= b)
            {
                a = b;
            }
            else
                b = a;
        }

    }
}
