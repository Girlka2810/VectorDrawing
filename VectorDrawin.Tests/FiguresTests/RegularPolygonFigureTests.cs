using NUnit.Framework;
using System.Drawing;
using System.Collections;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;
using System;

namespace VectorDrawin.Tests.FiguresTests
{
    class RegularPolygonFigureTests
    {
        [Test, TestCaseSource(typeof(GetPointOfRegularPolygonMock))]
        public void RegularPolygonFigureTest(int numOfCorners, PointF center, PointF current, PointF[] points)
        {
            RegularPolygonFigure regularPolygonFigure = new RegularPolygonFigure();
            RegularPolygonParameter regularPolygonParameter = new RegularPolygonParameter
            {
                QuantityOfCorners = numOfCorners,
                Center = center,
                TemporaryPoint = current
            };
            PointF[] actual = ((CommonReturn)regularPolygonFigure.Get(regularPolygonParameter)).Points;
            for (int i = 0; i< actual.Length; i++)
            {
                actual[i].X = (float)Math.Round(actual[i].X);
                actual[i].Y = (float)Math.Round(actual[i].Y);
            }
            PointF[] expected = points;
            Assert.AreEqual(expected, actual);
        }
    }
    class GetPointOfRegularPolygonMock : IEnumerable
    {
         public IEnumerator GetEnumerator()
        {
            yield return new object[] {3, new PointF(10, 10), new PointF(20, 20), new [] { new PointF(10, -4),
            new PointF(-2, 17), new PointF(22, 17)} };
            yield return new object[] {4, new PointF(10, 10), new PointF(20, 20), new [] { new PointF(10, -4), 
                new PointF(-4, 10), new PointF(10,24), new PointF(24, 10)} };
            //yield return new object[] {5, new PointF(10, 10), new PointF(20, 20), new PointF[] { new PointF(10, 0), new PointF((float)0.4894348, (float)6.90983),
            //new PointF(15, 18), new PointF(4, 18), new PointF(0, 6) } };
        }
    }
}
