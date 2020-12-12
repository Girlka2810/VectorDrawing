using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using NUnit.Framework;
using VectorDrawing.Figures;

namespace VectorDrawin.Tests.FiguresTests
{
    class SquareFigureTests
    {
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(3,3)]
        [TestCase(4,4)]
        [TestCase(5,5)]
        public void GetPointsTest(int case_of_array, int case_of_expected_arr)
        {
            SquareFigure square = new SquareFigure();
            PointF[] actual = square.GetPoints(ActualParameterMock(case_of_array));
            PointF[] expected = ExpectedPointsOfSquareFigureMock(case_of_expected_arr);
            Assert.AreEqual(expected, actual);
        }
        public FigureParameter ActualParameterMock(int a)
        {
            FigureParameter figureParameter;
            figureParameter = new FigureParameter { Points = StartPointOfSquareFigureMock(a), TemporaryPoint = CrntPointOfSquareFigureMock(a)};
            return figureParameter;
        }
        public PointF[] ExpectedPointsOfSquareFigureMock(int a)
        {
            PointF[] points;
            switch (a)
            {
                case 1:
                    points = new PointF[] { new PointF(0, 0), new PointF(10,0), new PointF(10,10), new PointF(0,10) };
                    return points;
                case 2:
                    points = new PointF[] { new PointF(10, 10), new PointF(20, 10), new PointF(20, 0), new PointF(10, 0) };
                    return points;
                case 3:
                    points = new PointF[] { new PointF(10, 10), new PointF(0, 10), new PointF(0 ,0), new PointF(10, 0) };
                    return points;
                case 4:
                    points = new PointF[] { new PointF(10, 10), new PointF(20, 10), new PointF(20 ,20), new PointF(10, 20) };
                    return points;
                case 5:
                    points = new PointF[] { new PointF(10, 10), new PointF(20, 10), new PointF(20, 20), new PointF(10, 20) };
                    return points;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public PointF[] StartPointOfSquareFigureMock(int a)
        {
            PointF[] points;
            switch(a)
            {
                case 1:
                    points = new PointF[] { new PointF(0, 0) };
                    return points;
                case 2:
                    points = new PointF[] { new PointF(10,10) };
                    return points;
                case 3:
                    points = new PointF[] { new PointF(10, 10) };
                    return points;
                case 4:
                    points = new PointF[] { new PointF(10, 10) };
                    return points;
                case 5:
                    points = new PointF[] { new PointF(10, 10) };
                    return points;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public PointF CrntPointOfSquareFigureMock(int a)
        {
            PointF point;
            switch(a)
            {
                case 1:
                    point = new PointF(10, 10);
                    return point;
                case 2:
                    point = new PointF(20, 0);
                    return point;
                case 3:
                    point = new PointF(0, 0);
                    return point;
                case 4:
                    point = new PointF(30, 20);
                    return point;
                case 5:
                    point = new PointF(20, 40);
                    return point;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
