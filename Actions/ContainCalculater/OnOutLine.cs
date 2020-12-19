using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Tools;

namespace VectorDrawing.Actions.ContainCalculater
{
    public class OnOutLine : IContaneCalculator
    {
        private Pen _pen;
        public OnOutLine()
        {
            _pen = new Pen(Color.Black, 10);
        }
        public bool IsContain(AbstractTool tool, PointF point)
        {
            GraphicsPath path = tool.Path;
            _pen.Width = tool.Pen.Width + 10;
            return path.IsOutlineVisible(point, _pen);
        }
    }
}
