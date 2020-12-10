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
    class LineFigureTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void GetPointsTests(int parametersNumber, int expectedNumber)
        {
            PointF[] expected = ExpectedPointsMock(expectedNumber);
            PointF[] actual = new LineFigure().GetPoints(ActualParametrsMock(parametersNumber));
            Assert.AreEqual(expected, actual);
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
                    return new PointF[] { new PointF(1, 2), new PointF(3, 4) };
                case 2:
                    return new PointF[] { new PointF(3, 4), new PointF(5, 3) };
                case 3:
                    return new PointF[] { new PointF(0, 2), new PointF(3, 4) };
                case 4:
                    return new PointF[] { new PointF(-10, 21), new PointF(30, 40) };
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
                        new PointF(1, 2),
                        new PointF(3, 4)
                    }
                    };
                case 2:
                    return new FigureParameter
                    {
                        Points = new PointF[]
                        {
                            new PointF(3, 4),
                            new PointF(5,3)
                        },
                    };
                case 3:
                    return new FigureParameter
                    {
                        Points = new PointF[]
                        {
                            new PointF(0, 2),
                            new PointF(3,4),
                           
                        }
                    };
                case 4:
                    return new FigureParameter
                    {
                        Points = new PointF[]
                        {
                            new PointF(-10, 21),
                            new PointF(30, 40)
                        },
                        
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

