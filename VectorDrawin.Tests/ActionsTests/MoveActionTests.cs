using NUnit.Framework;
using System.Drawing;
using VectorDrawing.Actions;

namespace VectorDrawin.Tests.ActionsTests
{
    class MoveActionTests
    {
        [TestCase(1, 1, 1, 1)]
        public void MoveActionTest(int caseOfStartArr, int caseOfStartP, int caseOfEndP, int caseOfEndArr)
        {
            IAction action = new MoveAction();
            PointF[] actual = action.GetMove(
                MoveActionStartPointsArrayMock(caseOfStartArr), 
                MoveActionStartPointMock(caseOfStartP),
                MoveActionEndPointMock(caseOfEndP)
                );
            Assert.AreEqual(MoveActionEndPointsArrayMock(caseOfEndArr), actual);
        }
        public PointF[] MoveActionStartPointsArrayMock(int a)
        {
            PointF[] points;
            switch (a)
            {
                case 1:
                    points = new PointF[] { new PointF(5, 5), new PointF(15, 5), 
                        new PointF(15, 15), new PointF(5, 15) };
                    return points;
                default:
                    throw new System.Exception();
            }
        }
        public PointF MoveActionStartPointMock(int a)
        {
            PointF point;
            switch (a)
            {
                case 1:
                    point = new PointF(10, 10);
                    return point;
                default:
                    throw new System.Exception();
            }
        }
        public PointF MoveActionEndPointMock(int a)
        {
            PointF point;
            switch (a)
            {
                case 1:
                    point = new PointF(20, 20);
                    return point;
                default:
                    throw new System.Exception();
            }
        }
        public PointF[] MoveActionEndPointsArrayMock(int a)
        {
            PointF[] points;
            switch (a)
            {
                case 1:
                    points = new PointF[] { new PointF(15, 15), new PointF(25, 15), 
                        new PointF(25, 25), new PointF(15, 25) };
                    return points;
                default:
                    throw new System.Exception();
            }
        }
    }
}
