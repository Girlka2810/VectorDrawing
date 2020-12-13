using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawin.Tests.ToolsTests.Mocks;
using VectorDrawing.Tools;

namespace VectorDrawin.Tests.ToolsTests
{
    public class IsoscelesTriangleToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void RectangleToolTest(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            IsoscelesTriangleTool actual = new IsoscelesTriangleTool(pen);
            IsoscelesTriangleTool expected = new IsoscelesTriangleTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}