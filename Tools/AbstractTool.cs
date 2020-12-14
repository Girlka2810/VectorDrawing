using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.FactoriesTools;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;


namespace VectorDrawing.Tools
{

    public abstract class AbstractTool
    {
        public string ID { get; protected set; }
        public abstract int MaxCount { get; }
        public PointF TemporaryPoint { get; set; }
        protected List<PointF> Points;
        protected PointF[] EndShapePoints;
        public Pen Pen { get; set; }
        

        public AbstractTool(List<PointF> points, Pen pen)
        {
            ID = Guid.NewGuid().ToString(); 
            Points = points;
            SetPen(pen);
        }
        
        protected AbstractTool(Pen pen)
        {
            ID = Guid.NewGuid().ToString(); 
            Points = new List<PointF>( );
            SetPen(pen);
        }

        public abstract void Paint(Graphics graphics);
        public abstract FigureParameter GenerateParametrs();
        

        public virtual void AddPoint(PointF point)
        {
            if (Points.Count > 1)
            {
                Points.RemoveAt(1);
            }

            Points.Add(point);
        }

        public bool CheckMaxQuantityPoints()
        {
            if (MaxCount == 0)
            {
                return false;
            }
            

            if (Points.Count==MaxCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool CheckPointsExist()
        {
            if (Points.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public virtual void SavePoints()
        {
            EndShapePoints = ((CommonReturn)Figure.Get(GenerateParametrs())).Points;
        }

        public override bool Equals(object obj)
        {
            if (obj is AbstractTool tool)
            {
                if (tool.Points.Count == Points.Count)
                {
                    if (!Points.Equals(tool.Points) 
                        && TemporaryPoint!=tool.TemporaryPoint
                        && !Pen.Equals(tool.Pen))
                    {
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }
        public bool IsItYou(PointF point)
        {
            PointF prevP = EndShapePoints[3];
            foreach (PointF p in EndShapePoints)
            {
                if (Contain(prevP, p, point, Pen.Width))
                {
                    return true;
                }
                prevP = p;
            }
            return false;
        }


        protected void SetPen(Pen pen)
        {
            if (pen.Width >= 1 && pen.Width <= 100)
            {
                Pen = pen;
            }
            else
            {
                throw new ArgumentException("Pen cannot have width less than 1 and greater than 100");
            }
        }
        protected bool Contain(PointF start, PointF end, PointF checkPoint, double accuracy)
        {
            double x1 = start.X;
            double y1 = start.Y;
            double x2 = end.X;
            double y2 = end.Y;
            double x = checkPoint.X;
            double y = checkPoint.Y;

            if (CheckInside(x, x1, x2, accuracy) && CheckInside(y, y1, y2, accuracy))
                return Math.Abs((x - x1) * (y2 - y1) - (y - y1) * (x2 - x1)) < accuracy / 2 * Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            else return false;
        }

        protected bool CheckInside(double x, double a, double b, double accuracy)
        {
            if ((x > a - accuracy && x < b + accuracy) || (x > b - accuracy && x < a + accuracy))
                return true;
            else return false;
        }
    }
}