using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    public class IsoscelesTriangleFigure : IFigure
    {
        public FigureReturn Get(FigureParameter parameter)
        {
            if (parameter is CommonParameter figureParameter)
            {
                if (figureParameter.Points.Length == 1)
                {
                    PointF[] tmp = new PointF[figureParameter.Points.Length + 2];
                    Array.Copy(figureParameter.Points, tmp, figureParameter.Points.Length);
                    tmp[tmp.Length - 1] =
                        new PointF(figureParameter.TemporaryPoint.X,
                            figureParameter.TemporaryPoint.Y); // последняя точка[2]

                    if (tmp[0].Y > tmp[1].Y)
                    {
                        //2,1quarter
                        tmp[1] = new PointF((int) (figureParameter.TemporaryPoint.X), tmp[0].Y); // последняя точка[2]
                        tmp[2] = new PointF((int) tmp[0].X - (tmp[0].X - tmp[1].X) / 2, tmp[2].Y); //промежуточная[1]
                    }
                    else
                    {
                        //3,4quater
                        tmp[1] = new PointF((int) (figureParameter.TemporaryPoint.X), tmp[0].Y); // последняя точка[2]
                        tmp[2] = new PointF((int) tmp[2].X + (tmp[0].X - tmp[1].X) / 2,
                            tmp[2].Y + (tmp[0].Y - tmp[1].Y) / 2); //промежуточная[1]
                    }

                    return new CommonReturn() { Points  = tmp};
                }

                if (figureParameter.Points.Length == 2)
                {
                    PointF[] tmp = new PointF[figureParameter.Points.Length + 1];
                    Array.Copy(figureParameter.Points, tmp, figureParameter.Points.Length);
                    tmp[tmp.Length - 1] =
                        new PointF(figureParameter.Points[1].X, figureParameter.Points[1].Y); // последняя точка[2]

                    if (tmp[0].Y > tmp[1].Y)
                    {
                        //2,1quarter
                        tmp[1] = new PointF((int) (figureParameter.Points[1].X), tmp[0].Y); // последняя точка[2]
                        tmp[2] = new PointF((int) tmp[0].X - (tmp[0].X - tmp[1].X) / 2, tmp[2].Y); //промежуточная[1]
                    }
                    else
                    {
                        //3,4quater
                        tmp[1] = new PointF((int) (figureParameter.Points[1].X), tmp[0].Y); // последняя точка[2]
                        tmp[2] = new PointF((int) tmp[2].X + (tmp[0].X - tmp[1].X) / 2,
                            tmp[2].Y + (tmp[0].Y - tmp[1].Y) / 2); //промежуточная[1]
                    }

                    return new CommonReturn() { Points  = tmp};
                }
                return new CommonReturn() { Points  = figureParameter.Points};
            }
            
            return new FigureReturn();
        }
    }
}