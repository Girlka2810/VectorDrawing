using System;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    public class NLineFigure : IFigure
    {
        public FigureReturn Get(FigureParameter parameter)
        {
            if (parameter is CommonParameter figureParameter)
            {
                PointF[] tmp = new PointF[figureParameter.Points.Length+1];
                Array.Copy(figureParameter.Points, tmp, figureParameter.Points.Length);
                tmp[tmp.Length - 1] = parameter.TemporaryPoint;
                return new CommonReturn() {Points = tmp};

            }

            return new FigureReturn();
        }
    }
}
