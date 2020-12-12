using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
   public class LineFigure : IFigure
    {
        public FigureReturn Get(FigureParameter parameter)
        {
            if (parameter is CommonParameter figureParameter)
            {
                if (parameter.TemporaryPoint != null && figureParameter.Points.Length == 1)
                {
                    return new CommonReturn()
                    {
                        Points = new [] { figureParameter.Points[0], figureParameter.TemporaryPoint }
                    };
                }
                else if (figureParameter.Points.Length == 2)
                {
                    
                    return new CommonReturn()
                    {
                        Points = new [] { figureParameter.Points[0], figureParameter.Points[1] }
                    };
                }
                
                return new CommonReturn()
                {
                    Points = new PointF[0]
                };
            }

            return new FigureReturn();
        }
    }
}
