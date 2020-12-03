using System.Drawing;
using VectorDrawing.Figures;

namespace VectorDrawing.Tools
{
    public class IsoscelesTriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 2; 
        public IsoscelesTriangleTool(Pen pen) : base(pen)
        {
        }

        
        public override void Paint(Graphics graphics)
        {
            IsoscelesTriangleFigure isoscelesTriangleFigure = new IsoscelesTriangleFigure();
            FigureParameter figureParameter = new FigureParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint,
            };
            graphics.DrawPolygon(Pen, isoscelesTriangleFigure.GetPoints(figureParameter));
        }
    }
}