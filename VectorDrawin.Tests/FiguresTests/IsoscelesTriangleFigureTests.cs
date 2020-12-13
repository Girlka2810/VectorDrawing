using System.Collections;
using NUnit.Framework;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawin.Tests.FiguresTests
{
    class IsoscelesTriangleFigureTests
        {
       

        [Test,TestCaseSource(typeof (GetPointOfIsoscelesTriangleFigureMock))]
        public void IsoscelesTriangleFigureTest(PointF startPoint, PointF endPoint, PointF[] triangle )
        {
            IsoscelesTriangleFigure isoscelesTriangleFigure = new IsoscelesTriangleFigure();
            CommonParameter parameter = new CommonParameter()
            {
              Points = new [] { startPoint, endPoint},
              TemporaryPoint = endPoint
            };
            PointF[] actual = ((CommonReturn)isoscelesTriangleFigure.Get(parameter)).Points;
            PointF[] expected = triangle;
            Assert.AreEqual(actual, expected);
        }
    }
    class GetPointOfIsoscelesTriangleFigureMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new PointF(10, 10), new PointF(20, 20), new [] { new PointF(10, 10), new PointF(20, 10), new PointF(15, 20) } };
            yield return new object[] { new PointF(20, 20), new PointF(10, 10), new [] { new PointF(20, 20), new PointF(10, 20), new PointF(15, 10) } };
            yield return new object[] { new PointF(10, 20), new PointF(20, 10), new [] { new PointF(10, 20), new PointF(20, 20), new PointF(15, 10) } };
            yield return new object[] { new PointF(20, 10), new PointF(10, 20), new [] { new PointF(20, 10), new PointF(10, 10), new PointF(15, 20) } };
        }
    }
}
