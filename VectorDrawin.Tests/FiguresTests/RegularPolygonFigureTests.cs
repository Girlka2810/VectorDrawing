using NUnit.Framework;
using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing;
using VectorDrawing.Figures;

namespace VectorDrawin.Tests.FiguresTests
{
    class RegularPolygonFigureTests
    {
        [Test, TestCaseSource(typeof(GetPointMock))]
        public void RegularPolygonFigureTest()
        {

        }
    }
    class GetPointMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {4, new Point(10, 10), new Point(20, 10), new Point[] { new Point(0, 0), new Point(20, 0),
            new Point(20,20), new Point(0, 20)} };
        }
    }
}
