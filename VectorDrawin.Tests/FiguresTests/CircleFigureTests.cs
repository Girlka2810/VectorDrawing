using NUnit.Framework;
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
                Center = StartPointMock(case_of_params)[0],
                TemporaryPoint = CrntPointMock(case_of_params)
            };
            Rectangle actual = circle.GetRectangle(figureParameter);
            Rectangle expected = ExpectedRectangleMock(case_of_exp_rect);
            Assert.AreEqual(expected, actual);
        }

        public Point CrntPointMock(int a)
        {
            Point point;
            switch (a)
            {
                case 1:
                    point = new Point(20, 10);
                    return point;
                case 2:
                    point = new Point(0, 10);
                    return point;
                case 3:
                    point = new Point(0, 0);
                    return point;
                case 4:
                    point = new Point(10, 0);
                    return point;
                case 5:
                    point = new Point(10, 20);
                    return point;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public Point[] StartPointMock(int a)
        {
            Point[] points;
            switch (a)
            {
                case 1:
                    points = new Point[] { new Point(10, 10) };
                    return points;
                case 2:
                    points = new Point[] { new Point(0, 0) };
                    return points;
                case 3:
                    points = new Point[] { new Point(0, 10) };
                    return points;
                case 4:
                    points = new Point[] { new Point(10, 10) };
                    return points;
                case 5:
                    points = new Point[] { new Point(10, 10) };
                    return points;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public Rectangle ExpectedRectangleMock(int a)
        {
            Rectangle rectangle;
            switch (a)
            {
                case 1:
                    rectangle = new Rectangle(new Point(0, 0), new Size(20, 20));
                    return rectangle;
                case 2:
                    rectangle = new Rectangle(new Point(-10, -10), new Size(20, 20));
                    return rectangle;
                case 3:
                    rectangle = new Rectangle(new Point(-10, 0), new Size(20, 20));
                    return rectangle;
                case 4:
                    rectangle = new Rectangle(new Point(0, 0), new Size(20, 20));
                    return rectangle;
                case 5:
                    rectangle = new Rectangle(new Point(0, 0), new Size(20, 20));
                    return rectangle;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}