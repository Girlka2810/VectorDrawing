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
            PointF[] expected = ExpectedPointsMock(expectedNumber);
            PointF[] actual = new RectangleFigure().GetPoints(ActualParametrsMock(parametersNumber));
            Assert.AreEqual(expected, actual);
        }


        [TestCase(4)]
        public void GetPointsNegativeTests(int parametersNumber)
        {

            Assert.Throws<NullReferenceException>(() =>
            {
                PointF[] actual = new RectangleFigure().GetPoints(ActualParametrsMock(parametersNumber));
            });
        }


        PointF[] ExpectedPointsMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new PointF[] { new PointF(1, 2), new PointF(1, 6), new PointF(5, 6), new PointF(5, 2) };
                case 2:
                    return new PointF[] { new PointF(3, 4), new PointF(3, 8), new PointF(6, 8), new PointF(6, 4) };
                case 3:
                    return new PointF[] { new PointF(3, 4), new PointF(3, 4), new PointF(3, 4), new PointF(3, 4) };
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
                        Points = new PointF[]
                    {
                        new PointF(1, 2), new PointF(5, 6)
                    }
                    };
                case 2:
                    return new FigureParameter
                    {
                        Points = new PointF[]
                        {
                            new PointF(3, 4)                         
                        },
                        TemporaryPoint = new PointF(6, 8)
                    };
                case 3:
                    return new FigureParameter
                    {
                        Points = new PointF[]
                        {
                            new PointF(3, 4),
                            new PointF(3, 4),                          
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
