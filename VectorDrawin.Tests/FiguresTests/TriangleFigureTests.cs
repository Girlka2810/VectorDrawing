using System;
using System.Drawing;
using NUnit.Framework;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

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
            PointF[] expected = ExpectedPointsOfTriangleFigureMock(expectedNumber);
            PointF[] actual = ((CommonReturn)
                new TriangleFigure().Get(ActualParametrsOfTriangleFigureMock(parametersNumber))).Points;
            Assert.AreEqual(expected,actual);
        }
        
        
        [TestCase(5)]
        public void GetPointsNegativeTests(int parametersNumber)
        {

            Assert.Throws<NullReferenceException>(() =>
            {
                PointF[] actual = ((CommonReturn)
                    new TriangleFigure().Get(ActualParametrsOfTriangleFigureMock(parametersNumber))).Points;
            });
        }
        
        
        PointF[] ExpectedPointsOfTriangleFigureMock(int n)
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
        
        CommonParameter ActualParametrsOfTriangleFigureMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new CommonParameter {Points = new PointF[]
                    {
                        new PointF(1, 2), new PointF(3, 4)
                    }
                    };
                case 2:
                    return new CommonParameter {Points = new PointF[]
                        {
                            new PointF(3, 4), 
                            new PointF(3,3)
                        },
                        TemporaryPoint = new PointF(1,2)
                    };
                case 3:
                    return new CommonParameter {Points = new PointF[]
                        {
                            new PointF(3, 4), 
                            new PointF(3,3),
                            new PointF(1,2)
                        }
                    };
                case 4:
                    return new CommonParameter {Points = new PointF[]
                        {
                            new PointF(1, 2)
                        },
                        TemporaryPoint = new PointF(3, 4)
                    };
                case 5:
                    return new CommonParameter {
                    };
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
    }
}