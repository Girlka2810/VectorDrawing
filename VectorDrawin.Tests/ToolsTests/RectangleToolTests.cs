using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VectorDrawing.Tools;

namespace VectorDrawin.Tests.ToolsTests
{
    class RectangleToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void RectangleToolTest(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            RectangleTool actual = new RectangleTool(pen);
            RectangleTool expected = new RectangleTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
