using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Actions.ContainCalculater;
using VectorDrawing.Canvases;
using VectorDrawing.Tools.Brushes;

namespace VectorDrawing.Tools
{
    public class FillTool : AbstractTool
    {
        public override int MaxCount { get; }
        public FillTool(Pen pen) : base(pen)
        {

        }

        public FillTool(List<PointF> points, Pen pen) : base(points, pen)
        {

        }
        //public void FillFigure(Graphics graphics, EventArgs e)
        //{
        //    IContaneCalculator contaneCalculator = new OnInside();
        //    if (contaneCalculator.IsContain()
        //    GraphicsPath path = new GraphicsPath();
        //    SolidBrush solidBrush = new SolidBrush(Color.FromArgb(25, 155, 10, 10));
        //    graphics.FillPath(solidBrush, path);
        //}
    }
}
