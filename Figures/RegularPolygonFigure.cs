using System;
using System.Drawing;
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
                float radius = Equalization(deltaX, deltaY);

                for (int i = 0; i < vertexes; i++)
                {
                    points[i].X = (float)(center.X - radius*Math.Sin(z));
                    points[i].Y = (float)(center.Y - radius*Math.Cos(z));
                    z = z + angle;
                }
                return new CommonReturn() {Points = points};
            }
            
            return new FigureReturn();
        }
        
        private float Equalization(float dx, float dy)
        {
            //if (dx >= dy)
            //{
            //    return dx;
            //}
            //else
            //{
            //    return dy;
            //}
            float radius = (float)Math.Sqrt(dx * dx + dy * dy);
            return radius;
        }

    }
}
