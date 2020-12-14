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
    public class PolygonTool : AbstractTool
    {
        public override int MaxCount => 0;
        public PolygonTool(Pen pen):base(pen) 
        { 

        }  
        public PolygonTool(List<PointF> points, Pen pen):base(points, pen) 
        {
        }
        public override void Paint(Graphics graphics)
        {
            Figures.PolygonFigure polygon = new Figures.PolygonFigure();
            CommonParameter figureParameter = new CommonParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint
            };
            graphics.DrawPolygon(Pen, ((CommonReturn)polygon.Get(figureParameter)).Points);
        }
        public override void AddPoint(PointF point)
        {
            Points.Add(point);
        }

        protected override FigureParameter GenerateParametrs()
        {
            throw new NotImplementedException();
        }
    }
}
