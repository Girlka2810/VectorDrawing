using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Tools;
using VectorDrawing.Actions.ContainCalculater;

namespace VectorDrawing.Canvases
{
    interface ICanvas
    {
        void Create(int width, int height);
        void Create(int width, int height, Color backcolor);
        void SetRender(Action<Bitmap, Color> render);
        void Draw(Tools.AbstractTool tool);
        void FinishFigure();
        void UpdateBitmap();
        AbstractTool SetToolOnMouse(IContaneCalculator contaneCalculator, PointF point);
        Color GetColor(PointF pointF);
    }
}
