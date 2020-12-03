using System;
using System.Drawing;
using NUnit.Framework;
using VectorDrawing;
using VectorDrawing.Figures;

namespace VectorDrawin.Tests.FiguresTests
{
    public class RectangularTriangleFigureTests
    {
     
        [TestCase(1,1)]
        [TestCase(2,1)]
        [TestCase(3,2)]
        [TestCase(4,2)]
        public void GetPointsTests(int parametersNumber, int expectedNumber)
        {
            Point[] expected = ExpectedPointsMock(expectedNumber);
            Point[] actual = new RectangularTriangleFigure().GetPoints(ActualParametrsMock(parametersNumber));
            Assert.AreEqual(expected,actual);
        }
        
        
        [TestCase(5)]
        public void GetPointsNegativeTests(int parametersNumber)
        {

            Assert.Throws<NullReferenceException>(() =>
            {
                Point[] actual = new RectangularTriangleFigure().GetPoints(ActualParametrsMock(parametersNumber));
            });
        }
        
        
        Point[] ExpectedPointsMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new Point[] {new Point(1, 2), new Point(1,4), new Point(3, 4)};
                case 2:
                    return new Point[] {new Point(3, 4), new Point(3,2), new Point(1, 2)};
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
        
        FigureParameter ActualParametrsMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new FigureParameter {Points = new Point[]
                    {
                        new Point(1, 2), new Point(3, 4)
                    }
                    };
                case 2:
                    return new FigureParameter {Points = new Point[]
                        {
                            new Point(1, 2)
                        },
                        TemporaryPoint = new Point(3,4)
                    };
                case 3:
                    return new FigureParameter {Points = new Point[]
                        {
                            new Point(3, 4), new Point(1, 2)
                        }
                    };
                case 4:
                    return new FigureParameter {Points = new Point[]
                        {
                            new Point(3, 4), 
                        },
                        TemporaryPoint = new Point(1, 2)
                    };
                case 5:
                    return new FigureParameter {
                    };
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
    }
}