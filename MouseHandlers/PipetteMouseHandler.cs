using System.Windows.Forms;
using VectorDrawing.Actions;
using VectorDrawing.Canvases;
using VectorDrawing.Tools;

namespace VectorDrawing.MouseHandlers
{
    public class PipetteMouseHandler : IMouseHandler
    {
        public void OnMouseMove(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
        }

        public void OnMouseDown(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
            form.PaletteButton1.BackColor = canvas.GetColor(e.Location);
            tool.Pen.Color = form.PaletteButton1.BackColor;
        }

        public void OnMouseUp(ICanvas canvas, MouseEventArgs e, IAction action, AbstractTool tool, VectorDrawingForm form)
        {
       
        }
    }
}