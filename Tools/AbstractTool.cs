using System;
using System.Collections.Generic;
using System.Drawing;


namespace VectorDrawing.Tools
{

    /// <summary>
    /// ЗДЕСЬ ОТРИСОВКА!!!!!!!!!!!!!!!!!!!!!!!!!!
    /// </summary>
    public abstract class AbstractTool
    {
        public string ID { get; protected set; }
        public abstract int MaxCount { get; }
        public PointF TemporaryPoint { get; set; }
        protected List<PointF> Points;
        protected Pen Pen;
        

        public AbstractTool(List<PointF> points, Pen pen)
        {
            ID = Guid.NewGuid().ToString(); 
            Points = points;
            SetPen(pen);
        }
        
        protected AbstractTool(Pen pen)
        {
            ID = Guid.NewGuid().ToString(); 
            Points = new List<PointF> { };
            SetPen(pen);
        }

        public abstract void Paint(Graphics graphics);
        

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
                }
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
    }
}