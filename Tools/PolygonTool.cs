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
            Figure = new Figures.PolygonFigure();
        }  
        public PolygonTool(List<PointF> points, Pen pen):base(points, pen) 
        {
            Figure = new Figures.PolygonFigure();
        }
        public override void Paint(Graphics graphics)
        {
            graphics.DrawPolygon(Pen, ((CommonReturn)Figure.Get(GenerateParametrs())).Points);
        }
        public override void AddPoint(PointF point)
        {
            Points.Add(point);
        }

        public override void SavePoints()
        {
            PointF[] tempPoints = ((CommonReturn)Figure.Get(GenerateParametrs())).Points;
            EndShapePoints = new PointF[tempPoints.Length - 3];
            for (int i = 0; i < EndShapePoints.Length; i++)
            {
                EndShapePoints[i] = tempPoints[i];
            }
            Points = null;
            CalculateCenter();
        }
    }
}
