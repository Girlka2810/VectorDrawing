using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawin.Tests.ToolsTests
{
    public class GetPointsMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List<PointF>
                {
                   
                }
            };
            yield return new object[]
            {
                new List<PointF>
                {
                    new PointF(1, 1),
                }
            };
            yield return new object[]
            {
                new List<PointF>
                {
                    new PointF(10, 10),
                    new PointF(1, 1)
                }
            };
        }
    }
}
