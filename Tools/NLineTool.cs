using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class NLineTool : AbstractTool
    {
        public override int MaxCount => 0;
        private IFigure _figure;

        public NLineTool(Pen pen) : base(pen)
        {
        }
        
        public NLineTool(List<PointF> points, Pen pen) : base(points, pen)
        {
        
        }
        
        public override void Paint(Graphics graphics)
        {
            NLineFigure nLine = new NLineFigure();
            _figure = nLine;
            FigureParameter figureParameter = GenerateParametrs();
            graphics.DrawLines(Pen, ((CommonReturn)nLine.Get(figureParameter)).Points);

        }
        public override void AddPoint(PointF point)
        {
            Points.Add(point);
        }

        protected override FigureParameter GenerateParametrs()
        {
            CommonParameter figureParameter = new CommonParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint
            };
            return figureParameter;
        }
    }
}
