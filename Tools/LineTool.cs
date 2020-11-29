using System.Drawing;


namespace VectorDrawing.Tools
{
    class LineTool : AbstractTool
    {

        public LineTool(Pen pen) : base(pen)
        {

        }

        public override void Paint(Graphics graphics)
        {
            if (_points.Count == 2)
            {
                graphics.DrawLine(_pen, _points[0], _points[1]);
            }
        }
    }
}
