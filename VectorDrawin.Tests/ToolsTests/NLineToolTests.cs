﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawin.Tests.ToolsTests.Mocks;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Lines;

namespace VectorDrawin.Tests.ToolsTests
{
    class NLineToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void NLineToolTest(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            NLine actual = new NLine(pen);
            NLine expected = new NLine(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
