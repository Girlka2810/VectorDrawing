using System;
using System.Windows.Forms;
using VectorDrawing.Actions;
using VectorDrawing.Canvases;
using VectorDrawing.Tools;

namespace VectorDrawing.MouseHandlers
{
    public class ActionMouseHandler : IMouseHandler
    {
        public void OnMouseMove(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                action.UpdateToolPoints(tool, tool.TemporaryPoint, e.Location);
                canvas.Draw(tool);
            }
        }

        public void OnMouseDown(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
            form.SetTool(canvas.SetToolOnMouse(form.ContaneCalculator, e.Location));
            canvas.UpdateBitmap();
            GC.Collect();
        }

        public void OnMouseUp(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
            if (action != null)
            {
                canvas.FinishFigure();
            }
        }
    }
}