using NUnit.Framework;
using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing;
using VectorDrawing.Figures;

namespace VectorDrawin.Tests.FiguresTests
{
    class RegularPolygonFigureTests
    {
        [Test, TestCaseSource(typeof(GetPointMock))]
        public void RegularPolygonFigureTest(int num_of_corners, Point center, Point crnt, PointF[] points)
        {
            RegularPolygonFigure regularPolygonFigure = new RegularPolygonFigure();
            RegularPolygonParameter regularPolygonParameter = new RegularPolygonParameter
            {
                QuantityOfCorners = num_of_corners,
                Center = center,
                TemporaryPoint = crnt
            };
            PointF[] actual = regularPolygonFigure.GetPoints(regularPolygonParameter);
            PointF[] expected = points;
            Assert.AreEqual(expected, actual);
        }
    }
    class GetPointMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 3, new Point(10, 10), new Point(20, 20), new Point[] { new Point(10, 0),
            new Point(18, 14), new Point(1, 15) } };
            yield return new object[] {4, new Point(10, 10), new Point(20, 20), new Point[] { new Point(10, 0), new Point(20, 10),
            new Point(10,20), new Point(0, 10)} };
            yield return new object[] {5, new Point(10, 10), new Point(20, 20), new Point[] { new Point(10, 0), new Point(19, 6),
            new Point(15, 18), new Point(4, 18), new Point(0, 6) } };
        }
    }
}
