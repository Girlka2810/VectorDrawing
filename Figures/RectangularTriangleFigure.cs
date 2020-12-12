using System;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    public class RectangularTriangleFigure : IFigure
    {
       

        public FigureReturn Get(FigureParameter parameter)
        {
            if (parameter is CommonParameter figureParameter)
            {
                if(figureParameter.Points.Length==0) throw new NullReferenceException("Points count can't be null");
            
                if (figureParameter.Points.Length == 1)
                {
                    return new CommonReturn()
                    {
                        Points = new[]
                        {
                            figureParameter.Points[0],
                            new PointF(figureParameter.Points[0].X, figureParameter.TemporaryPoint.Y),
                            figureParameter.TemporaryPoint
                        }
                    };
                }


                return new CommonReturn()
                {
                    Points = new[]
                    {
                        figureParameter.Points[0],
                        new PointF(figureParameter.Points[0].X, figureParameter.Points[1].Y),
                        figureParameter.Points[1],
                    }

                };
            }

            return new FigureReturn();
        }
    }
}