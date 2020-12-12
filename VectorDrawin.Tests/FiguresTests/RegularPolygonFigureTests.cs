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
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawin.Tests.FiguresTests
{
    class RegularPolygonFigureTests
    {
        [Test, TestCaseSource(typeof(GetPointOfRegularPolygonMock))]
        public void RegularPolygonFigureTest(int numOfCorners, PointF center, PointF crnt, PointF[] points)
        {
            RegularPolygonFigure regularPolygonFigure = new RegularPolygonFigure();
            RegularPolygonParameter regularPolygonParameter = new RegularPolygonParameter
            {
                QuantityOfCorners = numOfCorners,
                Center = center,
                TemporaryPoint = crnt
            };
            PointF[] actual = ((CommonReturn)regularPolygonFigure.Get(regularPolygonParameter)).Points;
            PointF[] expected = points;
            Assert.AreEqual(expected, actual);
        }
    }
    class GetPointOfRegularPolygonMock : IEnumerable
    {
         public IEnumerator GetEnumerator()
        {
            yield return new object[] { 3, new PointF(10, 10), new PointF(20, 20), new PointF[] { new PointF(10, 0),
            new PointF((float)1.339746, 15), new PointF((float)18.6602535, 15)} };
            yield return new object[] {4, new PointF(10, 10), new PointF(20, 20), new PointF[] { new PointF(10, 0), new PointF(0, 10),
            new PointF(10,20), new PointF(20, 10)} };
            //yield return new object[] {5, new PointF(10, 10), new PointF(20, 20), new PointF[] { new PointF(10, 0), new PointF((float)0.4894348, (float)6.90983),
            //new PointF(15, 18), new PointF(4, 18), new PointF(0, 6) } };
        }
    }
}
