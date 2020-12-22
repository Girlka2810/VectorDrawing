using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorDrawing.Actions;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Lines;
using System;

namespace VectorDrawin.Tests.ActionsTests
{
    class MoveActionTests
    {
        IAction action = new MoveAction();

        //[SetUp]

        [Test, TestCaseSource(typeof(MoveActionMock))]
        public void MoveActionTest(AbstractTool tool, PointF start, PointF end, PointF[] expected)
        {
            tool.SavePoints();
            action.UpdateToolPoints(tool, start, end);
            PointF[] actual = new PointF[tool.EndShapePoints.Length];
            for (int i = 0; i<actual.Length; i++)
            {
                actual[i].X = (float)Math.Round(tool.EndShapePoints[i].X);
                actual[i].Y = (float)Math.Round(tool.EndShapePoints[i].Y);
            }
            Assert.AreEqual(expected, actual);
        }
       
        
    }
    class MoveActionMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                CreateTool.Line(
                    new List<PointF>()
                    {
                        new PointF(5, 5),
                        new PointF(10, 5)
                    }, 
                    new Pen(Color.Aqua, 11)
                    ),
                new PointF(10, 10), new PointF(10, 20),
                new PointF[] {new PointF(5, 15), new PointF(10, 15)}
            };
            yield return new object[]
            {
                CreateTool.Square(
                    new List<PointF>()
                    {
                        new PointF(5, 5),
                        new PointF(10, 5),
                        new PointF(10, 10),
                        new PointF(5, 10)
                    },
                    new Pen(Color.Aqua, 11)
                    ),
                new PointF(10, 10), new PointF(10, 20),
                new PointF[] 
                {
                    new PointF(5, 15),
                    new PointF(10, 15),
                    new PointF(10, 20),
                    new PointF(5, 20)
                }
            };
            yield return new object[]
           {
                CreateTool.Triangle(
                    new List<PointF>()
                    {
                        new PointF(5, 5),
                        new PointF(10, 5),
                        new PointF(10, 10)
                    },
                    new Pen(Color.Aqua, 11)
                    ),
                new PointF(10, 10), new PointF(10, 20),
                new PointF[]
                {
                    new PointF(5, 15),
                    new PointF(10, 15),
                    new PointF(10, 20)
                }
           };
            yield return new object[]
          {
                CreateTool.Rectangle(
                    new List<PointF>()
                    {
                        new PointF(5, 5),
                        new PointF(10, 5),
                        new PointF(10, 10),
                        new PointF(5, 10)
                    },
                    new Pen(Color.Aqua, 11)
                    ),
                new PointF(10, 10), new PointF(10, 20),
                new PointF[]
                {
                    new PointF(5, 15),
                    new PointF(10, 15),
                    new PointF(10, 20),
                    new PointF(5, 20)
                }
          };
            yield return new object[]
          {
                CreateTool.RegularPolygon(
                    new List<PointF>()
                    {
                        new PointF(5, 5),
                        new PointF(10, 5)
                    },
                    new Pen(Color.Aqua, 11), 4
                    ),
                new PointF(10, 10), new PointF(10, 20),
                new PointF[]
                {
                    new PointF(5, 8),
                    new PointF(-2, 15),
                    new PointF(5, 22),
                    new PointF(12, 15)
                }
          };
        }
    }
}
