using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class RectangleTool : AbstractTool
    {
        public override int MaxCount => 2;

        public RectangleTool(Pen pen) : base(pen)
        {

        }
        
        public RectangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {

        }
        public override void Paint(Graphics graphics)
        {
            Figures.RectangleFigure rectangle = new Figures.RectangleFigure();
            CommonParameter figureParameter = new CommonParameter
            {
                Points = this.Points.ToArray(),
                TemporaryPoint = this.TemporaryPoint
            };
            graphics.DrawPolygon(Pen, ((CommonReturn)rectangle.Get(figureParameter)).Points);
        }
    }
}
