﻿using System;
using System.Drawing;

namespace VectorDrawing.Canvases
{
    interface ICanvas
    {
        void Create(int width, int height);
        void Create(int width, int height, Color backcolor);
        void SetRender(Action<Bitmap, Color> render);
        void Draw(Tools.AbstractTool tool);
        void DrawAll();
        void Update();
        void Clear(int width, int height);
        void FinishFigure();
        Dictionary<string, Tools.AbstractTool> GetDictionary();

    }
}
