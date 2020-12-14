
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    public interface IFigure
    {
        FigureReturn Get(FigureParameter parameter);

    }

}
