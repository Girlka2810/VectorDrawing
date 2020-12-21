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
            PointF[] actual = tool.EndShapePoints;
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

            //yield return new object[]
            //{
            //    CreateTool.Square(
            //        new List<PointF>()
            //        {
            //            new PointF(5, 5),
            //            new PointF(10, 5),

            //        },
            //        new Pen(Color.Aqua, 11)
            //        ),
            //    new PointF(10, 10), new PointF(10, 20),
            //    new PointF[] {new PointF(5, 15), new PointF(10, 15)}
            //};

            //yield return new object[]
            //{
            //    new[]
            //    {
            //        CreateTool.Brush(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 12)),
            //        CreateTool.Line(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 11)),
            //        CreateTool.Rectangle(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 11)),
            //    },
            //};

            //yield return new object[]
            //{
            //    new[]
            //    {
            //        CreateTool.Square(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 12)),
            //        CreateTool.Line(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 11)),
            //        CreateTool.NLine(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 11)),
            //        CreateTool.Brush(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 12)),
            //        CreateTool.RectangularTriangle(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 11)),
            //        CreateTool.Rectangle(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 11)),
            //    },
            //};

            //yield return new object[]
            //{
            //    new[]
            //    {
            //        CreateTool.Circle(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 12)),
            //        CreateTool.RegularPolygon(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(6, 6),
            //            }, new Pen(Color.Aqua, 11), 100),
            //        CreateTool.Ellipse(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 11)),
            //    },
            //};

            //yield return new object[]
            //{
            //    new[]
            //    {
            //        CreateTool.Square(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 12)),
            //        CreateTool.Line(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 11)),
            //        CreateTool.Triangle(
            //            new List<PointF>()
            //            {
            //                new PointF(1, 1),
            //                new PointF(1, 1),
            //            }, new Pen(Color.Aqua, 11)),
            //    },
            //};

            //yield return new object[]
            //{
            //    new AbstractTool[] { },
            //};
        }
    }
}
