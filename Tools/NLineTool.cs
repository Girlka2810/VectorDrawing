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

        public NLineTool(Pen pen) : base(pen)
        {
            Figure = new NLineFigure();
        }
        
        public NLineTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            Figure = new NLineFigure();
        }
        
        public override void Paint(Graphics graphics)
        {
            if (EndShapePoints.Length == 0)
            {
            }
            graphics.DrawLines(Pen, ((CommonReturn)Figure.Get(GenerateParametrs())).Points);

        }
        public override void AddPoint(PointF point)
        {
            Points.Add(point);
        }

        
    }
}
