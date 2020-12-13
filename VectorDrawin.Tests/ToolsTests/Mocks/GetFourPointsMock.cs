using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace VectorDrawin.Tests.ToolsTests.Mocks
{
    class GetFourPointsMock: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
          {
                new List<PointF>
                {
                    new PointF(21, 68),
                    new PointF(20, 20),
                    new PointF(20, 20),
                    new PointF(3, 45)
                }
          };
        }
    }
}
