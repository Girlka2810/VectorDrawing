using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Figures;

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
            Point[] expected = ExpectedPointsMock(expectedNumber);
            Point[] actual = new NLineFigure().GetPoints(ActualParametrsMock(parametersNumber));
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5)]
        public void GetPointsNegativeTests(int parametersNumber)
        {

            Assert.Throws<NullReferenceException>(() =>
            {
                Point[] actual = new TriangleFigure().GetPoints(ActualParametrsMock(parametersNumber));
            });
        }

        Point[] ExpectedPointsMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new Point[] { new Point(1, 2), new Point(3, 4) };
                case 2:
                    return new Point[] { new Point(3, 4), new Point(5, 3), new Point(-23, 0), new Point(-3, 5), new Point(0, 0) };
                case 3:
                    return new Point[] { new Point(0, 2), new Point(3, 4), new Point(-3, -4), new Point(13, 24), new Point(31, 40), new Point(-30, -47) };
                case 4:
                    return new Point[] { new Point(10, -52), new Point(23, 44), new Point(-31, -48), new Point(13, 24), new Point(31, 40), new Point(-30, -47), new Point(-3, 7) };
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
        FigureParameter ActualParametrsMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new FigureParameter
                    {
                        Points = new Point[]
                    {
                        new Point(1, 2),
                    },
                    TemporaryPoint = new Point(3, 4)
                    };
                case 2:
                    return new FigureParameter
                    {
                        Points = new Point[]
                        {
                            new Point(3, 4),
                            new Point(5,3),
                            new Point(-23, 0), 
                            new Point(-3, 5),
                        },
                        TemporaryPoint = new Point(0, 0)
                    };
                case 3:
                    return new FigureParameter
                    {
                        Points = new Point[]
                        {
                            new Point(0, 2),
                            new Point(3, 4), 
                            new Point(-3, -4), 
                            new Point(13, 24), 
                            new Point(31, 40), 
                        },
                        TemporaryPoint = new Point(-30, -47)
                    };
                case 4:
                    return new FigureParameter
                    {
                        Points = new Point[]
                        {
                            new Point(10, -52),
                            new Point(23, 44),
                            new Point(-31, -48), 
                            new Point(13, 24),
                            new Point(31, 40), 
                            new Point(-30, -47),
                        },
                        TemporaryPoint = new Point(-3, 7)
                    };
                case 5:
                    return new FigureParameter
                    {
                    };
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
    }
}
