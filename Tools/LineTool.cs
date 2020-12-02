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
            Figures.LineFigure line = new Figures.LineFigure();
            Figures.FigureParameter figureParameter = new Figures.FigureParameter
            {
                Points = this.Points.ToArray(),
                TemporaryPoint = this.TemporaryPoint
            };
            graphics.DrawLines(Pen, line.GetPoints(figureParameter));
        }
    }
}
