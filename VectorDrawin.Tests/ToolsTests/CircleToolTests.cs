﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawin.Tests.ToolsTests.Mocks;
using VectorDrawing.Tools.Ellipse;

namespace VectorDrawin.Tests.ToolsTests
{
    class CircleToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void CircleToolTest(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            CircleTool actual = new CircleTool(pen);
            CircleTool expected = new CircleTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
