using System.Drawing;


namespace VectorDrawing.Tools
{
    class BrushTool : AbstractTool
    {
        public BrushTool(Pen pen) : base(pen)
        {

        }

        public override void Paint(Graphics graphics)
        {
            graphics.DrawCurve(Pen, Points.ToArray());
        }

        public override void AddPoint(Point point)
        {
            Points.Add(point);
        }
    }
}
