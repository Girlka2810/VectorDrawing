using NUnit.Framework;
using System.Collections;
using System.Drawing;
using VectorDrawing.Actions;
using VectorDrawing.Tools;

namespace VectorDrawin.Tests.ActionsTests
{
    class RotateActionTests
    {
        [Test, TestCaseSource(typeof(PointsMock))]
        public void RotateActionTest(PointF[] toolPoints, PointF start, PointF end, PointF[] expected)
        {
            IAction action = new RotateAction();
            AbstractTool tool = new PolygonTool(new Pen(Color.Black));
            tool.EndShapePoints = toolPoints;
            tool.CenterForTests();
            action.UpdateToolPoints(tool, start, end);
            PointF[] actual = tool.EndShapePoints;
            Assert.AreEqual(expected, actual);
        }
       
    }
    class PointsMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 
                new PointF[] { 
                    new PointF(10,10), new PointF(15, 10), 
                    new PointF(15, 15), new PointF(10, 15) 
                },
                new PointF(), new PointF(),
                new PointF[] {
                    new PointF(10,10), new PointF(15, 10),
                    new PointF(15, 15), new PointF(10, 15)
                }
            };
            yield return new object[] {
                new PointF[] {
                    new PointF(10,10), new PointF(16, 10),
                    new PointF(16, 16), new PointF(10, 16)
                },
                new PointF(16, 10), new PointF(10, 10),
                new PointF[] {
                    new PointF(10,10), new PointF(16, 16),
                    new PointF(10, 16),  new PointF(16, 10)
                }
            };
        }

    }
    
}
