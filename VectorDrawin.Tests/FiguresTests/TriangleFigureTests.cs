using System;
using System.Drawing;
using NUnit.Framework;
using VectorDrawing.Figures;

namespace VectorDrawin.Tests.FiguresTests
{
    public class TriangleFigureTests
    {
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(3,2)]
        [TestCase(4,3)]
        public void GetPointsTests(int parametersNumber, int expectedNumber)
        {
            Point[] expected = ExpectedPointsMock(expectedNumber);
            Point[] actual = new TriangleFigure().GetPoints(ActualParametrsMock(parametersNumber));
            Assert.AreEqual(expected,actual);
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
                    return new Point[] {new Point(1, 2), new Point(3, 4),  new Point(0,0),};
                case 2:
                    return new Point[] {new Point(3, 4), new Point(3,3), new Point(1, 2)};
                case 3:
                    return new Point[] {new Point(1, 2), new Point(3, 4),  };
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
                            new Point(3, 4), 
                            new Point(3,3)
                        },
                        TemporaryPoint = new Point(1,2)
                    };
                case 3:
                    return new FigureParameter {Points = new Point[]
                        {
                            new Point(3, 4), 
                            new Point(3,3),
                            new Point(1,2)
                        }
                    };
                case 4:
                    return new FigureParameter {Points = new Point[]
                        {
                            new Point(1, 2)
                        },
                        TemporaryPoint = new Point(3, 4)
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