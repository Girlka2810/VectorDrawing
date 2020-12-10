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
        


        protected AbstractTool(Pen pen)
        {
            ID = Guid.NewGuid().ToString(); 
            Points = new List<PointF> { };
            SetPen(pen);
        }

        public abstract void Paint(Graphics graphics);

        public void ClearPoints()
        {
            Points = new List<PointF> { };
        }

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