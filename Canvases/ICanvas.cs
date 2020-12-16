using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.Canvases
{
    interface ICanvas
    {
        void Create(int width, int height);
        void Create(int width, int height, Color backcolor);
        void SetRender(Action<Bitmap, Color> render);
        void Draw(Tools.AbstractTool tool);
        void Clear();
        void FinishFigure();
        void DrawAll();
        void UpdateDictionary(List<Tools.AbstractTool> list);
        void LoadBitMap(Bitmap bitmap);
        void Update(AbstractTool tool, PointF[] points);
        void UpdateBitmap();
        AbstractTool SetToolOnMouse(PointF point);


        List<Tools.AbstractTool> GetTools();
       // Dictionary<string, Tools.AbstractTool> GetDictionary();

    }
}
