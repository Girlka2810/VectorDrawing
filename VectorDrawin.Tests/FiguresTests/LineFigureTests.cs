using NUnit.Framework;
using System;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawin.Tests.FiguresTests
{
    class LineFigureTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void GetPointsTests(int parametersNumber, int expectedNumber)
        {
            PointF[] expected = ExpectedPointsOfLineMock(expectedNumber);
            PointF[] actual = ((CommonReturn)
                new LineFigure().Get(ActualParametrsOfLineMock(parametersNumber))).Points;
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5)]
        public void GetPointsNegativeTests(int parametersNumber)
        {

            Assert.Throws<NullReferenceException>(() =>
            {
                new LineFigure().Get(ActualParametrsOfLineMock(parametersNumber));
            });
        }


        PointF[] ExpectedPointsOfLineMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new [] { new PointF(1, 2), new PointF(3, 4) };
                case 2:
                    return new [] { new PointF(3, 4), new PointF(5, 3) };
                case 3:
                    return new [] { new PointF(0, 2), new PointF(3, 4) };
                case 4:
                    return new [] { new PointF(-10, 21), new PointF(30, 40) };
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }

        CommonParameter ActualParametrsOfLineMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new CommonParameter
                    {
                        Points = new []
                    {
                        new PointF(1, 2),
                        new PointF(3, 4)
                    }
                    };
                case 2:
                    return new CommonParameter
                    {
                        Points = new []
                        {
                            new PointF(3, 4),
                            new PointF(5,3)
                        },
                    };
                case 3:
                    return new CommonParameter
                    {
                        Points = new []
                        {
                            new PointF(0, 2),
                            new PointF(3,4),
                           
                        }
                    };
                case 4:
                    return new CommonParameter
                    {
                        Points = new []
                        {
                            new PointF(-10, 21),
                            new PointF(30, 40)
                        },
                        
                    };
                case 5:
                    return new CommonParameter();
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
    }
}

