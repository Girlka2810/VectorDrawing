using System;
using System.Drawing;
using NUnit.Framework;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

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
            PointF[] expected = ExpectedPointsOfRectangularTriangleFigureMock(expectedNumber);
            PointF[] actual = ((CommonReturn)
                new RectangularTriangleFigure()
                    .Get(ActualParametrsOfRectangularTriangleFigureMock(parametersNumber))).Points;
            Assert.AreEqual(expected,actual);
        }
        
        
        [TestCase(5)]
        public void GetPointsNegativeTests(int parametersNumber)
        {

            Assert.Throws<NullReferenceException>(() =>
            {
                new RectangularTriangleFigure()
                    .Get(ActualParametrsOfRectangularTriangleFigureMock(parametersNumber));
            });
        }
        
        
        PointF[] ExpectedPointsOfRectangularTriangleFigureMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new [] {new PointF(1, 2), new PointF(1,4), new PointF(3, 4)};
                case 2:
                    return new [] {new PointF(3, 4), new PointF(3,2), new PointF(1, 2)};
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
        
        CommonParameter ActualParametrsOfRectangularTriangleFigureMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new CommonParameter {Points = new []
                    {
                        new PointF(1, 2), new PointF(3, 4)
                    }
                    };
                case 2:
                    return new CommonParameter {Points = new []
                        {
                            new PointF(1, 2)
                        },
                        TemporaryPoint = new PointF(3,4)
                    };
                case 3:
                    return new CommonParameter {Points = new []
                        {
                            new PointF(3, 4), new PointF(1, 2)
                        }
                    };
                case 4:
                    return new CommonParameter {Points = new []
                        {
                            new PointF(3, 4), 
                        },
                        TemporaryPoint = new PointF(1, 2)
                    };
                case 5:
                    return new CommonParameter();
                default:
                    throw new NullReferenceException("No n in the list");
            }
        }
    }
}