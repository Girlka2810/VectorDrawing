
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    interface IFigure
    {
        FigureReturn Get(FigureParameter parameter);

    }

}
