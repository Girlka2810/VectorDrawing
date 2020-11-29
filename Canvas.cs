using System;
using System.Collections.Generic;
using System.Drawing;


namespace VectorDrawing
{
    static class Canvas
    {


        public static Bitmap Bitmap { get; private set; }

        private static Action<Bitmap, Color> _render;
        private static Graphics _graphics;
        private static List<Tools.AbstractTool> _tools;
        private static Color _backColor;


        public static void Create(int width, int height)
        {
            Create(width, height, Color.White);
        }

        public static void Create(int width, int height, Color backcolor)
        {
            _tools = new List<Tools.AbstractTool>();
            Bitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(Bitmap);
            _graphics.Clear(Color.Transparent);
            _render?.Invoke(Bitmap, backcolor);
            _backColor = backcolor;
        }

        public static void SetRender(Action<Bitmap, Color> render)
        {
            if (_render == null)
            {
                _render += render;
            }
        }

        public static void Draw(Tools.AbstractTool tool)
        {
            if (_tools.Count == 100)
            {
                return;
            }

            _graphics.Clear(Color.Transparent);
            AddBuffer(tool);

            DrawPreviousItems();

            tool.Paint(_graphics);

            _render?.Invoke(Bitmap, _backColor);
        }


        // TODO: Этот метод максимально хреновый, надо будет переделать.
        private static void DrawPreviousItems()
        {
            foreach (var t in _tools)
            {
                t.Paint(_graphics);
            }
        }

        private static void AddBuffer(Tools.AbstractTool tool)
        {
            bool isFind = false;
            foreach (var t in _tools)
            {
                if (t == tool)
                {
                    isFind = true;
                }
            }

            if (!isFind)
            {
                _tools.Add(tool);
            }
        }
    }
}
