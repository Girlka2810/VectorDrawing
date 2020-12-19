using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Tools;

namespace VectorDrawing.Actions.ContainCalculater
{
    public interface IContaneCalculator
    {
        bool IsContain(AbstractTool tool, PointF point);
    }
}
