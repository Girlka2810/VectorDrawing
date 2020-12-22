using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawin.Tests.ToolsTests.Mocks;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Ellipse;

namespace VectorDrawin.Tests.ToolsTests
{
    class CalculateCenterTests
    {
        [Test, TestCaseSource(typeof(GetToolMock))]
        public void CalculateCenterTest(AbstractTool tool, PointF expected)
        {        
            tool.SavePoints();
            tool.CalculateCenter();
            PointF actual = tool.Center;         
            actual.X = (float)Math.Round(actual.X);
            actual.Y = (float)Math.Round(actual.Y);
            Assert.AreEqual(expected, actual);
        }
    }
}
