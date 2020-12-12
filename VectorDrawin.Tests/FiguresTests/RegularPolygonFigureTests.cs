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
        public void RegularPolygonFigureTest(int num_of_corners, PointF center, PointF crnt, PointF[] points)
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
            yield return new object[] { 3, new PointF(10, 10), new PointF(20, 20), new PointF[] { new PointF(10, 0),
            new Point(1, 15), new PointF(18, 14)} };
            yield return new object[] {4, new PointF(10, 10), new PointF(20, 20), new PointF[] { new PointF(10, 0), new PointF(20, 10),
            new PointF(10,20), new PointF(0, 10)} };
            yield return new object[] {5, new PointF(10, 10), new PointF(20, 20), new PointF[] { new PointF(10, 0), new PointF(19, 6),
            new PointF(15, 18), new PointF(4, 18), new PointF(0, 6) } };
        }
    }
}
