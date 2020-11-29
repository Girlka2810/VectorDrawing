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
            graphics.DrawCurve(_pen, _points.ToArray());
        }

        public override void AddPoint(Point point)
        {
            _points.Add(point);
        }
    }
}
