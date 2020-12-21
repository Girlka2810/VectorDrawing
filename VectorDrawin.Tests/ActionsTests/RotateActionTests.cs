using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Actions;
using VectorDrawing.Tools;

namespace VectorDrawin.Tests.ActionsTests
{
    class RotateActionTests
    {
        IAction action = new RotateAction();

        //[SetUp]

        [Test, TestCaseSource(typeof(RotateActionMock))]
        public void RotateActionTest(AbstractTool tool, PointF start, PointF end, PointF[] expected)
        {
            tool.SavePoints();
            action.UpdateToolPoints(tool, start, end);
            for (int i = 0; i < tool.EndShapePoints.Length; i++)
            {
                tool.EndShapePoints[i].X = (float)Math.Round(tool.EndShapePoints[i].X);
                tool.EndShapePoints[i].Y = (float)Math.Round(tool.EndShapePoints[i].Y);
            }
            PointF[] actual = tool.EndShapePoints;
            Assert.AreEqual(expected, actual);
        }
    }

    class RotateActionMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            Pen pen = new Pen(Color.Aqua, 11);

            yield return new object[]
            {
                CreateTool.Line(
                    new List<PointF>()
                    {
                        new PointF(6, 5),
                        new PointF(10, 5)
                    },
                    pen
                    ),
                new PointF(10, 5), new PointF(8, 0),
                new PointF[] {new PointF(8, 7), new PointF(8, 3)}
            };
            yield return new object[] 
            {
                CreateTool.Square(
                    new List<PointF>()
                    {
                        new PointF(10,10), new PointF(16, 10),
                    new PointF(16, 16), new PointF(10, 16)
                    },
                    pen
                    ),
                new PointF(16, 10), new PointF(10, 10),
                new PointF[] {
                   new PointF(16, 10), new PointF(16, 16), 
                    new PointF(10, 16), new PointF(10,10)
                }
            };
        }
    }
}
    //class PointsMock : IEnumerable
    //{
    //    public IEnumerator GetEnumerator()
    //    {
    //        yield return new object[] { 
    //            new PointF[] { 
    //                new PointF(10,10), new PointF(15, 10), 
    //                new PointF(15, 15), new PointF(10, 15) 
    //            },
    //            new PointF(), new PointF(),
    //            new PointF[] {
    //                new PointF(10,10), new PointF(15, 10),
    //                new PointF(15, 15), new PointF(10, 15)
    //            }
    //        };
    //        yield return new object[] {
    //            new PointF[] {
    //                new PointF(10,10), new PointF(16, 10),
    //                new PointF(16, 16), new PointF(10, 16)
    //            },
    //            new PointF(16, 10), new PointF(10, 10),
    //            new PointF[] {
    //                new PointF(10,10), new PointF(16, 16),
    //                new PointF(10, 16),  new PointF(16, 10)
    //            }
    //        };
    //    }

    //}
    

