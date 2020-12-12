using NUnit.Framework;
using System.Drawing;
using System;
using VectorDrawing.Figures;
using VectorDrawing;

namespace VectorDrawin.Tests.FiguresTests
{
    class EllipseFigureTests
    {

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(5, 5)]
        public void GetCircumscribedRectangleTest(int case_of_params, int case_of_exp_rect)
        {
            EllipseFigure ellipse = new EllipseFigure();

                EllipseFigureParameter figureParameter = new EllipseFigureParameter
                {
                    Center = StartPointMock(case_of_params)[0],
                    TemporaryPoint = CrntPointMock(case_of_params)
                };
            RectangleF actual = ellipse.GetRectangle(figureParameter);
            RectangleF expected = ExpectedRectangleMock(case_of_exp_rect);
            Assert.AreEqual(expected, actual);
        }

        public PointF CrntPointMock(int a)
        {
            PointF point;
            switch (a)
            {
                case 1:
                    point = new PointF(9, 6);
                    return point;
                case 2:
                    point = new PointF(25, 20);
                    return point;
                case 3:
                    point = new PointF(10, 20);
                    return point;
                case 4:
                    point = new PointF(10, 10);
                    return point;
                case 5:
                    point = new PointF(25, 10);
                    return point;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public PointF[] StartPointMock(int a)
        {
            PointF[] points;
            switch (a)
            {
                case 1:
                    points = new PointF[] { new PointF(0, 0) };
                    return points;
                case 2:
                    points = new PointF[] { new PointF(10, 10) };
                    return points;
                case 3:
                    points = new PointF[] { new PointF(25, 10) };
                    return points;
                case 4:
                    points = new PointF[] { new PointF(25, 20) };
                    return points;
                case 5:
                    points = new PointF[] { new PointF(10, 20) };
                    return points;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public RectangleF ExpectedRectangleMock(int a)
        {
            RectangleF rectangle;
            switch (a)
            {
                case 1:
                    rectangle = new RectangleF(new PointF(0, 0), new SizeF(9, 6));
                    return rectangle;
                case 2:
                    rectangle = new RectangleF(new PointF(10, 10), new SizeF(15, 10));
                    return rectangle;
                case 3:
                    rectangle = new RectangleF(new PointF(10, 10), new SizeF(15, 10));
                    return rectangle;
                case 4:
                    rectangle = new RectangleF(new PointF(10, 10), new SizeF(15, 10));
                    return rectangle;
                case 5:
                    rectangle = new RectangleF(new PointF(10, 10), new SizeF(15, 10));
                    return rectangle;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
