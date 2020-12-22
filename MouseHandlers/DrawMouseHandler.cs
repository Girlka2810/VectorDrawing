using System.Windows.Forms;
using VectorDrawing.Actions;
using VectorDrawing.Canvases;
using VectorDrawing.Tools;

namespace VectorDrawing.MouseHandlers
{
    public class DrawMouseHandler : IMouseHandler
    {
        public void OnMouseMove(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
            if (!tool.CheckPointsExist()) return;
            tool.TemporaryPoint = e.Location;
            canvas.Draw(tool);
        }

        public void OnMouseDown(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
            tool?.AddPoint(e.Location);

            if (tool != null && tool.CheckMaxQuantityPoints())
            {
                canvas.Draw(tool);
                canvas.FinishFigure();
                form.CreateFigure();
            }
        }

        public void OnMouseUp(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
           
        }
    }
}