using System.Drawing;
using System.Drawing.Drawing2D;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;

namespace VectorDrawing.Actions.ContainCalculater
{
    public class OnInside : IContaneCalculator
    {
        public bool IsContain(AbstractTool tool, PointF point)
        {
            GraphicsPath path = tool.Path;
            if (tool is BasicBrush || tool is AbstractLine)
            {
                Pen pen = new Pen(tool.Pen.Color, tool.Pen.Width);
                pen.Width += 10;
                return path.IsOutlineVisible(point, pen);
            }
            else
            {
                return path.IsVisible(point);
            }
        }
    }
}
