using NUnit.Framework;
using System;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawin.Tests.FiguresTests
{
    class RectangleTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void GetPointsTests(int parametersNumber, int expectedNumber)
        {
            PointF[] expected = ExpectedPointsOfRectangleMock(expectedNumber);
            PointF[] actual = ((CommonReturn)
                new RectangleFigure().Get(ActualParametrsOfRectangleMock(parametersNumber))).Points;
            Assert.AreEqual(expected, actual);
        }


        [TestCase(4)]
        public void GetPointsNegativeTests(int parametersNumber)
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                new RectangleFigure().Get(ActualParametrsOfRectangleMock(parametersNumber));
            });
        }


        PointF[] ExpectedPointsOfRectangleMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new[] {new PointF(1, 2), new PointF(1, 6), new PointF(5, 6), new PointF(5, 2)};
                case 2:
                    return new[] {new PointF(3, 4), new PointF(3, 8), new PointF(6, 8), new PointF(6, 4)};
                case 3:
                    return new[] {new PointF(3, 4), new PointF(3, 4), new PointF(3, 4), new PointF(3, 4)};
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }

        CommonParameter ActualParametrsOfRectangleMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new CommonParameter
                    {
                        Points = new[]
                        {
                            new PointF(1, 2), new PointF(5, 6)
                        }
                    };
                case 2:
                    return new CommonParameter
                    {
                        Points = new[]
                        {
                            new PointF(3, 4)
                        },
                        TemporaryPoint = new PointF(6, 8)
                    };
                case 3:
                    return new CommonParameter
                    {
                        Points = new[]
                        {
                            new PointF(3, 4),
                            new PointF(3, 4),
                        }
                    };
                case 4:
                    return new CommonParameter();
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
    }
}