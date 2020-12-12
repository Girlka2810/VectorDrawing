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
            PointF[] expected = ExpectedPointsMock(expectedNumber);
            PointF[] actual = new TriangleFigure().GetPoints(ActualParametrsMock(parametersNumber));
            Assert.AreEqual(expected,actual);
        }
        
        
        [TestCase(5)]
        public void GetPointsNegativeTests(int parametersNumber)
        {

            Assert.Throws<NullReferenceException>(() =>
            {
                PointF[] actual = new TriangleFigure().GetPoints(ActualParametrsMock(parametersNumber));
            });
        }
        
        
        PointF[] ExpectedPointsMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new PointF[] {new PointF(1, 2), new PointF(3, 4),  new PointF(0,0),};
                case 2:
                    return new PointF[] {new PointF(3, 4), new PointF(3,3), new PointF(1, 2)};
                case 3:
                    return new PointF[] {new PointF(1, 2), new PointF(3, 4),  };
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
        
        FigureParameter ActualParametrsMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new FigureParameter {Points = new PointF[]
                    {
                        new PointF(1, 2), new PointF(3, 4)
                    }
                    };
                case 2:
                    return new FigureParameter {Points = new PointF[]
                        {
                            new PointF(3, 4), 
                            new PointF(3,3)
                        },
                        TemporaryPoint = new PointF(1,2)
                    };
                case 3:
                    return new FigureParameter {Points = new PointF[]
                        {
                            new PointF(3, 4), 
                            new PointF(3,3),
                            new PointF(1,2)
                        }
                    };
                case 4:
                    return new FigureParameter {Points = new PointF[]
                        {
                            new PointF(1, 2)
                        },
                        TemporaryPoint = new PointF(3, 4)
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