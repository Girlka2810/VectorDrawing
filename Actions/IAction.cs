using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.Actions
{
    public interface IAction
    {
        void UpdateToolPoints(AbstractTool tool, PointF startPoint, PointF endPoint);
    }
}
