using System.Drawing;


namespace VectorDrawing.Tools
{
    class BrushTool : AbstractTool
    {
        public override int MaxCount => throw new System.NotImplementedException();

        public BrushTool(Pen pen) : base(pen)
        {

        }

        public override void Paint(Graphics graphics)
        {
            graphics.DrawLines(Pen, Points.ToArray());
        }

        public override void AddPoint(PointF point)
        {
            Points.Add(point);
        }
    }
}
