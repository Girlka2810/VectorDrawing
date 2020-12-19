using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public PointF Center { get; set; }
        public Pen Pen { get; private set; }
        public PointF[] EndShapePoints { get; set; }
        public GraphicsPath Path { get; set; }

        protected List<PointF> Points;
        protected IFigure Figure;
        protected Pen PenForSearching;


        public AbstractTool(List<PointF> points, Pen pen)
        {
            ID = Guid.NewGuid().ToString();
            Points = points;
            SetPen(pen);
            EndShapePoints = new PointF[] { };
            Path = new GraphicsPath();
        }

        protected AbstractTool(Pen pen)
        {
            ID = Guid.NewGuid().ToString();
            Points = new List<PointF>();
            SetPen(pen);
            EndShapePoints = new PointF[] { };
            Path = new GraphicsPath();
        }

        public virtual void Paint(Graphics graphics)
        {
            if (EndShapePoints.Length != 0)
            {
                graphics.DrawPath(Pen, Path);
            }
            else
            {
                graphics.DrawPolygon(Pen, ((CommonReturn) Figure.Get(GenerateParametrs())).Points);
            }
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


            if (Points.Count == MaxCount)
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
            if (EndShapePoints.Length == 0)
            {
                EndShapePoints = ((CommonReturn) Figure.Get(GenerateParametrs())).Points;
            }
            if (Path.PointCount == 0)
            {
                Path.AddPolygon(((CommonReturn)Figure.Get(GenerateParametrs())).Points);
            }

            Points = null;
            CalculateCenter();
            PenForSearching = new Pen(Pen.Color, Pen.Width + 10);
        }

        public override bool Equals(object obj)
        {
            if (obj is AbstractTool tool)
            {
                if (tool.Points.Count == Points.Count)
                {
                    if (!Points.Equals(tool.Points)
                        && TemporaryPoint != tool.TemporaryPoint
                        && !Pen.Equals(tool.Pen))
                    {
                        return false;
                    }

                    return true;
                }
            }

            return false;
        }


        public virtual void CalculateCenter()
        {
            PointF[] points = EndShapePoints;
            float middleX = 0;
            float middleY = 0;
            for (int i = 0; i < points.Length; i++)
            {
                middleX += points[i].X;
                middleY += points[i].Y;
            }

            middleX /= points.Length;
            middleY /= points.Length;
            Center = new PointF(middleX, middleY);
        }

        protected virtual FigureParameter GenerateParametrs()
        {
            return new CommonParameter
            {
                Points = Points != null ? Points.ToArray() : EndShapePoints,
                TemporaryPoint = TemporaryPoint
            };
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