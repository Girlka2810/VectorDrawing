using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    class NLineTool : AbstractTool
    {
        public override int MaxCount => 0;

        public NLineTool(Pen pen) : base(pen)
        {
        }
        public override void Paint(Graphics graphics)
        {
            Figures.NLineFigure NLine = new Figures.NLineFigure();
            Figures.FigureParameter figureParameter = new Figures.FigureParameter
            {
                Points = this.Points.ToArray(),
                TemporaryPoint = this.TemporaryPoint
            };

            graphics.DrawLines(Pen, NLine.GetPoints(figureParameter));

        }
        public override void AddPoint(Point point)
        {
            Points.Add(point);
        }
    }
}
