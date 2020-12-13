using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawin.Tests.ToolsTests.Mocks;
using VectorDrawing.Tools;

namespace VectorDrawin.Tests.ToolsTests
{
    class SquareToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void SquareToolTest(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            SquareTool actual = new SquareTool(pen);
            SquareTool expected = new SquareTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
