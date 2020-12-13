using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

using VectorDrawing.Tools.Polygons;

namespace VectorDrawin.Tests.ToolsTests
{
    class RegularPolygonToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void RegularPolygonToolTestWhithThreePoints(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            RegularPolygonTool actual = new RegularPolygonTool(pen);
            RegularPolygonTool expected = new RegularPolygonTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void RegularPolygonToolTestWhithFourPoints(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            RegularPolygonTool actual = new RegularPolygonTool(pen);
            RegularPolygonTool expected = new RegularPolygonTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
