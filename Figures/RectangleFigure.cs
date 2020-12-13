using System;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    public class RectangleFigure : IFigure
    {


        public FigureReturn Get(FigureParameter parameter)
        {
            if (parameter is CommonParameter figureParameter)
            {
                if (figureParameter.Points.Length == 1)
                {
                    return new CommonReturn()
                    {
                        Points = new []
                        {
                            figureParameter.Points[0],
                            new PointF(figureParameter.Points[0].X,
                                figureParameter.TemporaryPoint.Y),
                            figureParameter.TemporaryPoint,
                            new PointF(parameter.TemporaryPoint.X,
                                figureParameter.Points[0].Y)
                        }
                    };
                }
                else if (figureParameter.Points.Length == 2)
                {
                    return new CommonReturn()
                    {
                        Points = new []
                        {
                            figureParameter.Points[0],
                            new PointF(figureParameter.Points[0].X,
                                figureParameter.Points[1].Y),
                            figureParameter.Points[1],
                            new PointF(figureParameter.Points[1].X,
                                figureParameter.Points[0].Y)
                        }
                    };
                }
            }
            throw new NullReferenceException("Points can't be null!");
        }
    }
}