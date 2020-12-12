using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Drawing;
using VectorDrawing.Figures;
using System.Collections;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawin.Tests.FiguresTests
{
    class IsoscelesTriangleFigureTests
        {
       

        [Test,TestCaseSource(typeof (GetPointOfIsoscelesTriangleFigureMock))]
        public void IsoscelesTriangleFigureTest(PointF StartPoint, PointF EndPoint, PointF[] Triangle )
        {
            IsoscelesTriangleFigure isoscelesTriangleFigure = new IsoscelesTriangleFigure();
            CommonParameter parameter = new CommonParameter()
            {
              Points = new PointF[] { StartPoint, EndPoint},
              TemporaryPoint = EndPoint
            };
            PointF[] actual = ((CommonReturn)isoscelesTriangleFigure.Get(parameter)).Points;
            PointF[] expected = Triangle;
            Assert.AreEqual(actual, expected);
        }
    }
    class GetPointOfIsoscelesTriangleFigureMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new PointF(10, 10), new PointF(20, 20), new PointF[] { new PointF(10, 10), new PointF(20, 10), new PointF(15, 20) } };
            yield return new object[] { new PointF(20, 20), new PointF(10, 10), new PointF[] { new PointF(20, 20), new PointF(10, 20), new PointF(15, 10) } };
            yield return new object[] { new PointF(10, 20), new PointF(20, 10), new PointF[] { new PointF(10, 20), new PointF(20, 20), new PointF(15, 10) } };
            yield return new object[] { new PointF(20, 10), new PointF(10, 20), new PointF[] { new PointF(20, 10), new PointF(10, 10), new PointF(15, 20) } };
        }
    }
}
