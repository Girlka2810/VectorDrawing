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

namespace VectorDrawin.Tests.FiguresTests
{
    class IsoscelesTriangleFigureTests
        {
       

        [Test,TestCaseSource(typeof (GetPointMock))]
        public void IsoscelesTriangleFigureTest(PointF StartPoint, PointF EndPoint, PointF[] Triangle )
        {
            IsoscelesTriangleFigure isoscelesTriangleFigure = new IsoscelesTriangleFigure();
            FigureParameter parameter = new FigureParameter()
            {
              Points = new PointF[] { StartPoint},
              TemporaryPoint = EndPoint
            };
            PointF[] actual = isoscelesTriangleFigure.GetPoints(parameter);
            PointF[] expected = Triangle;
            Assert.AreEqual(actual, expected);
        }
        
    }
    class GetPointMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {new PointF(10,10),new PointF(20,20), new PointF[] { new PointF(10,10),new PointF(20,20),new PointF (15,10)} };
        }
    }
}
