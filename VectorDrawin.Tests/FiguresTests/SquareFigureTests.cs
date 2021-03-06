﻿using System;
using System.Drawing;
using NUnit.Framework;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawin.Tests.FiguresTests
{
    class SquareFigureTests
    {
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(3,3)]
        [TestCase(4,4)]
        [TestCase(5,5)]
        public void GetPointsTest(int caseOfArray, int caseOfExpectedArr)
        {
            SquareFigure square = new SquareFigure();
            PointF[] actual = ((CommonReturn)
                square.Get(ActualParameterMock(caseOfArray))).Points;
            PointF[] expected = ExpectedPointsOfSquareFigureMock(caseOfExpectedArr);
            Assert.AreEqual(expected, actual);
        }
        public CommonParameter ActualParameterMock(int a)
        {
            CommonParameter figureParameter;
            figureParameter = new CommonParameter
            {
                Points = StartPointOfSquareFigureMock(a), 
                TemporaryPoint = CrntPointOfSquareFigureMock(a)
            };
            return figureParameter;
        }
        public PointF[] ExpectedPointsOfSquareFigureMock(int a)
        {
            PointF[] points;
            switch (a)
            {
                case 1:
                    points = new [] { new PointF(0, 0), new PointF(10,0), new PointF(10,10), new PointF(0,10) };
                    return points;
                case 2:
                    points = new [] { new PointF(10, 10), new PointF(20, 10), new PointF(20, 0), new PointF(10, 0) };
                    return points;
                case 3:
                    points = new [] { new PointF(10, 10), new PointF(0, 10), new PointF(0 ,0), new PointF(10, 0) };
                    return points;
                case 4:
                    points = new [] { new PointF(10, 10), new PointF(20, 10), new PointF(20 ,20), new PointF(10, 20) };
                    return points;
                case 5:
                    points = new [] { new PointF(10, 10), new PointF(20, 10), new PointF(20, 20), new PointF(10, 20) };
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
                    points = new [] { new PointF(0, 0) };
                    return points;
                case 2:
                    points = new [] { new PointF(10,10) };
                    return points;
                case 3:
                    points = new [] { new PointF(10, 10) };
                    return points;
                case 4:
                    points = new [] { new PointF(10, 10) };
                    return points;
                case 5:
                    points = new [] { new PointF(10, 10) };
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
