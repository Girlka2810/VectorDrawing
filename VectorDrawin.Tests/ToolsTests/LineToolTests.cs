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
        [Test, TestCaseSource(typeof(GetLineToolMock))]
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

    public class GetLineToolMock: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List<PointF>
                {
                    new PointF(10, 10),
                    new PointF(20, 20)
                }
            };
            yield return new object[]
            {
                new List<PointF>
                {
                    new PointF(1, 1),
                    new PointF(20, 20)
                }
            };
            yield return new object[]
            {
                new List<PointF>
                {
                    new PointF(10, 10),
                    new PointF(1, 1)
                }
            };
        }
    }
}
