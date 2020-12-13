using System.Collections.Generic;
using NUnit.Framework;
using VectorDrawing.Tools;
using System.Drawing;
using VectorDrawin.Tests.ToolsTests.Mocks;

namespace VectorDrawin.Tests.ToolsTests
{
    public class LineToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void LineToolTest(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            LineTool actual = new LineTool(pen);
            LineTool expected = new LineTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
    }

   
}
