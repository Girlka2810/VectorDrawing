using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawin.Tests.ToolsTests.Mocks;
using VectorDrawing.Tools;

namespace VectorDrawin.Tests.ToolsTests
{
    class PolygonToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void PolygonToolTest(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            PolygonTool actual = new PolygonTool(pen);
            PolygonTool expected = new PolygonTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }

    }
}
