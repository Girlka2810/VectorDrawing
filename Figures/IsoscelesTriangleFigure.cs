using System;
using System.Collections.Generic;
using System.Drawing;

namespace VectorDrawing.Figures
{
    public class IsoscelesTriangleFigure : IFigure
    {
        public PointF[] GetPoints(FigureParameter parameter)
        {
            if (parameter.Points.Length == 1 && parameter.Points.Length <= 3)
            {
                PointF[] tmp = new PointF[parameter.Points.Length + 2];
                Array.Copy(parameter.Points, tmp, parameter.Points.Length);
                tmp[tmp.Length - 1] = new PointF (parameter.TemporaryPoint.X, parameter.TemporaryPoint.Y);// последняя точка[2]
                
                    if (tmp[0].Y > tmp[1].Y)
                    {
                        //2,1quarter
                        tmp[1] = new PointF((int)(parameter.TemporaryPoint.X), tmp[0].Y);// последняя точка[2]
                        tmp[2] = new PointF((int)tmp[0].X - (tmp[0].X - tmp[1].X) / 2, tmp[2].Y  );//промежуточная[1]
                    }
                    else
                    {
                        //3,4quater
                        tmp[1] = new PointF((int)(parameter.TemporaryPoint.X), tmp[0].Y);// последняя точка[2]
                        tmp[2] = new PointF((int)tmp[2].X + (tmp[0].X - tmp[1].X) / 2, tmp[2].Y + (tmp[0].Y - tmp[1].Y) / 2);//промежуточная[1]
                    }
                return tmp;
            }
            return parameter.Points;
            



        }
    }
    }
