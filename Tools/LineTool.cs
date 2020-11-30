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
            if (Points.Count == 2)
            {
                graphics.DrawLine(Pen, Points[0], Points[1]);
            }
        }
    }
}
