﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawin.Tests.ToolsTests.Mocks;
using VectorDrawing.Tools;

namespace VectorDrawin.Tests.ToolsTests
{
    class RectangularTriangleToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void RectangularTriangleToolTest(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            RectangularTriangleTool actual = new RectangularTriangleTool(pen);
            RectangularTriangleTool expected = new RectangularTriangleTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
