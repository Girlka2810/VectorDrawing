using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

using VectorDrawing.Tools;
using VectorDrawing.Tools.Ellipse;

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
                new CircleTool(new List<PointF>{ new PointF(0,0), new PointF(10,10)}, pen),
                new PointF(0,0)
            };
            yield return new object[]
            {
                new EllipseTool(new List<PointF>{ new PointF(0,0), new PointF(12,12)}, pen),
                new PointF(0,0)
            };
            yield return new object[]
            {
                new RectangularTriangleTool(new List<PointF>{ new PointF(0,0), new PointF(10,10)}, pen),
                new PointF(3, 7)
            };
            yield return new object[]
            {
                new SquareTool(new List<PointF>{ new PointF(0,0), new PointF(10,10)}, pen),
                new PointF(5, 5)
            };
        }
    }
}
