﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Tools.Ellipse;

namespace VectorDrawin.Tests.ToolsTests
{
    class EllipseToolTests
    {
        [Test, TestCaseSource(typeof(GetPointsMock))]
        public void EllipseToolTest(List<PointF> points)
        {
            Pen pen = new Pen(Color.BlueViolet);
            EllipseTool actual = new EllipseTool(pen);
            EllipseTool expected = new EllipseTool(points, pen);
            for (int i = 0; i < points.Count; i++)
            {
                actual.AddPoint(points[i]);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
