using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VectorDrawing.Tools;
using System.Drawing;

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
