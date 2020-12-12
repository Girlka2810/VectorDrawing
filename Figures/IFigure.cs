using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    /// <summary>
    /// ЗДЕСЬ МАТЕМАТИКА!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    /// </summary>
    interface IFigure
    {
        FigureReturn Get(FigureParameter parameter);

    }

}
