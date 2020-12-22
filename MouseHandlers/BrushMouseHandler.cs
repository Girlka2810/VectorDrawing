using System.Windows.Forms;
using VectorDrawing.Actions;
using VectorDrawing.Canvases;
using VectorDrawing.Tools;

namespace VectorDrawing.MouseHandlers
{
    public class BrushMouseHandler : IMouseHandler
    {
        public void OnMouseMove(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                tool.AddPoint(e.Location);
                canvas.Draw(tool);
            }

        }

        public void OnMouseDown(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
            
        }

        public  void OnMouseUp(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
            canvas.FinishFigure();
            form.CreateFigure();
        }
    }
}