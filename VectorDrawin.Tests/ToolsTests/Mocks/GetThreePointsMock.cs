using System.Collections;
using System.Collections.Generic;
using System.Drawing;


namespace VectorDrawin.Tests.ToolsTests
{
    class GetThreePointsMock: IEnumerable
    {
        public IEnumerator GetEnumerator() 
        {
            yield return new object[]
          {
                new List<PointF>
                {
                    new PointF(20, 50),
                    new PointF(30, 15),
                    new PointF(20, 20)
                }
          };
           
        }
    }
}
