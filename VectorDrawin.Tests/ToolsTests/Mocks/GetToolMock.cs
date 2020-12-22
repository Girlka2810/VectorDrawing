using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

using VectorDrawing.Tools;
using VectorDrawing.Tools.Ellipse;
using VectorDrawing.Tools.Lines;

namespace VectorDrawin.Tests.ToolsTests.Mocks
{
    public class GetToolMock : IEnumerable
    {
        Pen pen = new Pen(Color.Black, 1);
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new RectangleTool(new List<PointF>{ new PointF(0,0), new PointF(10,10)}, pen),
                new PointF(5,5)
            };

            yield return new object[]
            {
                new RectangularTriangleTool(new List<PointF>{ new PointF(0,0), new PointF(10,10)}, pen),
                new PointF(3, 7)
            };
            yield return new object[]
            {
                new TriangleTool(new List<PointF>{ new PointF(0,0), new PointF(10,10), new PointF(20,0)}, pen),
                new PointF(10, 3)
            };
            yield return new object[]
            {
                new SingleLine(new List<PointF>{ new PointF(0,0), new PointF(10,0)}, pen),
                new PointF(5, 0)
            };
            yield return new object[]
            {
                new NLine(new List<PointF>{ new PointF(0,0), new PointF(10,0), new PointF(20,20)}, pen),
                new PointF(8, 5)
            };
        }
    }
}
