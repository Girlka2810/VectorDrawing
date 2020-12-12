using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Tools;

namespace VectorDrawin.Tests.ToolsTests
{
    class TriangleToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void SquareToolTest(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            TriangleTool actual = new TriangleTool(pen);
            TriangleTool expected = new TriangleTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
