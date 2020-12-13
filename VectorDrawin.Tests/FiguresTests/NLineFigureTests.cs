using NUnit.Framework;
using System;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawin.Tests.FiguresTests
{
    class NLineFigureTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void GetPointsTests(int parametersNumber, int expectedNumber)
        {
            PointF[] expected = ExpectedPointsOfNLineMock(expectedNumber);
            PointF[] actual = ((CommonReturn)
                new NLineFigure().Get(ActualParametrsOfNLineMock(parametersNumber))).Points;
            Assert.AreEqual(expected, actual);
        }

        PointF[] ExpectedPointsOfNLineMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new [] { new PointF(1, 2), new PointF(3, 4) };
                case 2:
                    return new [] { new PointF(3, 4), new PointF(5, 3), new PointF(-23, 0), new PointF(-3, 5), new PointF(0, 0) };
                case 3:
                    return new [] { new PointF(0, 2), new PointF(3, 4), new PointF(-3, -4), new PointF(13, 24), new PointF(31, 40), new PointF(-30, -47) };
                case 4:
                    return new [] { new PointF(10, -52), new PointF(23, 44), new PointF(-31, -48), new PointF(13, 24), new PointF(31, 40), new PointF(-30, -47), new PointF(-3, 7) };
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
        CommonParameter ActualParametrsOfNLineMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new CommonParameter
                    {
                        Points = new []
                    {
                        new PointF(1, 2),
                    },
                    TemporaryPoint = new PointF(3, 4)
                    };
                case 2:
                    return new CommonParameter
                    {
                        Points = new []
                        {
                            new PointF(3, 4),
                            new PointF(5,3),
                            new PointF(-23, 0), 
                            new PointF(-3, 5),
                        },
                        TemporaryPoint = new PointF(0, 0)
                    };
                case 3:
                    return new CommonParameter
                    {
                        Points = new []
                        {
                            new PointF(0, 2),
                            new PointF(3, 4), 
                            new PointF(-3, -4), 
                            new PointF(13, 24), 
                            new PointF(31, 40), 
                        },
                        TemporaryPoint = new PointF(-30, -47)
                    };
                case 4:
                    return new CommonParameter
                    {
                        Points = new []
                        {
                            new PointF(10, -52),
                            new PointF(23, 44),
                            new PointF(-31, -48), 
                            new PointF(13, 24),
                            new PointF(31, 40), 
                            new PointF(-30, -47),
                        },
                        TemporaryPoint = new PointF(-3, 7)
                    };
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
    }
}
