using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using NUnit.Framework;
using VectorDrawing.Canvases;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;

namespace VectorDrawin.Tests.CanvasesTests
{
    public class BitmapCanvasTests
    {
        [Test, TestCaseSource(typeof(GetFiguresOnBitmapMock))]
        public void BitmapCanvasFigureSavingTests(AbstractTool[] tools)
        {
            BitmapCanvas expected = new BitmapCanvas(tools);
            BitmapCanvas actual = new BitmapCanvas();
            actual.Create(100, 100);
            for (int i = 0; i < tools.Length; i++)
            {
                actual.Draw(tools[i]);
            }

            Assert.AreEqual(expected, actual);
        }
    }

    class GetFiguresOnBitmapMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new[]
                {
                    CreateTool.Line(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                    CreateTool.Line(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                },
            };

            yield return new object[]
            {
                new[]
                {
                    CreateTool.Brush(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 12)),
                    CreateTool.Line(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                    CreateTool.Rectangle(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                },
            };

            yield return new object[]
            {
                new[]
                {
                    CreateTool.Square(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 12)),
                    CreateTool.Line(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                    CreateTool.NLine(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                    CreateTool.Brush(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 12)),
                    CreateTool.RectangularTriangle(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                    CreateTool.Rectangle(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                },
            };
            
            yield return new object[]
            {
                new[]
                {
                    CreateTool.Circle(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 12)),
                    CreateTool.RegularPolygon(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(6, 6),
                        }, new Pen(Color.Aqua, 11), 100),
                    CreateTool.Ellipse(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                },
            };

            yield return new object[]
            {
                new[]
                {
                    CreateTool.Square(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 12)),
                    CreateTool.Line(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                    CreateTool.Triangle(
                        new List<PointF>()
                        {
                            new PointF(1, 1),
                            new PointF(1, 1),
                        }, new Pen(Color.Aqua, 11)),
                },
            };

            yield return new object[]
            {
                new AbstractTool[] { },
            };
        }
    }
}