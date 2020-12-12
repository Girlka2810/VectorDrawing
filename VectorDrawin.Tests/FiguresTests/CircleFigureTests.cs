﻿using NUnit.Framework;
using System.Drawing;
using System;
using VectorDrawing.Figures;
using VectorDrawing;


namespace VectorDrawin.Tests.FiguresTests
{
    public class CircleFigureTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(5, 5)]
        public void GetCircumscribedRectangleTest(int case_of_params, int case_of_exp_rect)
        {
            CircleFigure circle = new CircleFigure();
            EllipseFigureParameter figureParameter = new EllipseFigureParameter
            {
                Center = StartPointCircumscribedRectangleMock(case_of_params)[0],
                TemporaryPoint = CrntPointCircumscribedRectangleMock(case_of_params)
            };
            RectangleF actual = circle.GetRectangle(figureParameter);
            RectangleF expected = ExpectedRectangleCircumscribedRectangleMock(case_of_exp_rect);
            Assert.AreEqual(expected, actual);
        }

        public PointF CrntPointCircumscribedRectangleMock(int a)
        {
            PointF point;
            switch (a)
            {
                case 1:
                    point = new PointF(20, 10);
                    return point;
                case 2:
                    point = new PointF(0, 10);
                    return point;
                case 3:
                    point = new PointF(0, 0);
                    return point;
                case 4:
                    point = new PointF(10, 0);
                    return point;
                case 5:
                    point = new PointF(10, 20);
                    return point;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public PointF[] StartPointCircumscribedRectangleMock(int a)
        {
            PointF[] points;
            switch (a)
            {
                case 1:
                    points = new PointF[] { new PointF(10, 10) };
                    return points;
                case 2:
                    points = new PointF[] { new PointF(0, 0) };
                    return points;
                case 3:
                    points = new PointF[] { new PointF(0, 10) };
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
        public RectangleF ExpectedRectangleCircumscribedRectangleMock(int a)
        {
            RectangleF rectangle;
            switch (a)
            {
                case 1:
                    rectangle = new RectangleF(new PointF(0, 0), new SizeF(20, 20));
                    return rectangle;
                case 2:
                    rectangle = new RectangleF(new PointF(-10, -10), new SizeF(20, 20));
                    return rectangle;
                case 3:
                    rectangle = new RectangleF(new PointF(-10, 0), new SizeF(20, 20));
                    return rectangle;
                case 4:
                    rectangle = new RectangleF(new PointF(0, 0), new SizeF(20, 20));
                    return rectangle;
                case 5:
                    rectangle = new RectangleF(new PointF(0, 0), new SizeF(20, 20));
                    return rectangle;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}