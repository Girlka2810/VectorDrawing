using System;
using System.Windows.Forms;
using VectorDrawing.Actions;
using VectorDrawing.Canvases;
using VectorDrawing.Tools;

namespace VectorDrawing.MouseHandlers
{
    public interface IMouseHandler
    {

        void OnMouseMove(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form);
        void OnMouseDown(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form);
        void OnMouseUp(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form);

      
    }
}