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
    class RectangleTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void GetPointsTests(int parametersNumber, int expectedNumber)
        {
            Point[] expected = ExpectedPointsMock(expectedNumber);
            Point[] actual = new RectangleFigure().GetPoints(ActualParametrsMock(parametersNumber));
            Assert.AreEqual(expected, actual);
        }


        [TestCase(4)]
        public void GetPointsNegativeTests(int parametersNumber)
        {

            Assert.Throws<NullReferenceException>(() =>
            {
                Point[] actual = new RectangleFigure().GetPoints(ActualParametrsMock(parametersNumber));
            });
        }


        Point[] ExpectedPointsMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new Point[] { new Point(1, 2), new Point(1, 6), new Point(5, 6), new Point(5, 2) };
                case 2:
                    return new Point[] { new Point(3, 4), new Point(3, 8), new Point(6, 8), new Point(6, 4) };
                case 3:
                    return new Point[] { new Point(3, 4), new Point(3, 4), new Point(3, 4), new Point(3, 4) };
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
                        new Point(1, 2), new Point(5, 6)
                    }
                    };
                case 2:
                    return new FigureParameter
                    {
                        Points = new Point[]
                        {
                            new Point(3, 4)                         
                        },
                        TemporaryPoint = new Point(6, 8)
                    };
                case 3:
                    return new FigureParameter
                    {
                        Points = new Point[]
                        {
                            new Point(3, 4),
                            new Point(3, 4),                          
                        }
                    };              
                case 4:
                    return new FigureParameter
                    {
                    };
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
    }
}
