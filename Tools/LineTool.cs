using System.Drawing;


namespace VectorDrawing.Tools
{
    class LineTool : AbstractTool
    {

        public override int MaxCount => 2;

        public LineTool(Pen pen) : base(pen)
        {

        }

        

        public override void Paint(Graphics graphics)
        {
            if(TemparyPoint!=null && Points.Count==1)
            {
                graphics.DrawLine(Pen, Points[0], TemparyPoint);
            }
            else if (Points.Count == 2)
            {
                graphics.DrawLine(Pen, Points[0], Points[1]);
            }
        }
    }
}
