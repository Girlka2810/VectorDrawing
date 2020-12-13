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
<<<<<<< Updated upstream
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
=======
        public PolygonTool(Pen pen) : base(pen) { }
        public PolygonTool(List<PointF> points, Pen pen):base(points, pen) { }
        public override int MaxCount => 0;

        public override void Paint(Graphics graphics)
        {
            Figures.NLineFigure Polygon = new Figures.NLineFigure();
>>>>>>> Stashed changes
            CommonParameter figureParameter = new CommonParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint
            };
<<<<<<< Updated upstream
            graphics.DrawPolygon(Pen, ((CommonReturn)polygon.Get(figureParameter)).Points);
=======

            graphics.DrawPolygon(Pen, ((CommonReturn)Polygon.Get(figureParameter)).Points);

>>>>>>> Stashed changes
        }
        public override void AddPoint(PointF point)
        {
            Points.Add(point);
        }
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
    }
}
