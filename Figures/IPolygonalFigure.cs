using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Figures
{
    interface IPolygonalFigure
    {
        PointF[] GetPoints(RegularPolygonParameter parameter);

    }
}
