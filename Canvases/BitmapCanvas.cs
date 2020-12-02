using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.Canvases
{
    class BitmapCanvas : ICanvas
    {
        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;
        private Action<Bitmap, Color> _render;
        private Graphics _graphics;
        private List<AbstractTool> _tools;
        private Color _backColor;


        public void Create(int width, int height)
        {
            Create(width, height, Color.White);
        }

        public void Create(int width, int height, Color backcolor)
        {
            _tools = new List<Tools.AbstractTool>();
            _mainBitmap = new Bitmap(width, height);
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            _graphics.Clear(Color.Transparent);
            _render?.Invoke(_tmpBitmap, backcolor);
            _backColor = backcolor;
        }

        public void SetRender(Action<Bitmap, Color> render)
        {
            if (render == null)
            {
                throw new NullReferenceException("Render cannot be null.");
            }

            if (_render == null)
            {
                _render += render;
            }
        }

        public void Draw(AbstractTool tool)
        {
            if(tool==null)
            {
                throw new NullReferenceException("Tool cannot be null.");
            }

            if (_tools.Count == 100)
            {
                return;
            }

            _graphics.Clear(Color.Transparent);
            
            AddBuffer(tool);

            DrawPreviousItems();

            tool.Paint(_graphics);

            _render?.Invoke(_tmpBitmap, _backColor);
        }

        // TODO: Этот метод максимально хреновый, надо будет переделать.
        public void RefreshMainBM()
        {
            _mainBitmap = (Bitmap)_tmpBitmap.Clone();
        }
        // TODO: Этот метод максимально хреновый, надо будет переделать.
        private void DrawPreviousItems()
        {
            foreach (var t in _tools)
            {
                t.Paint(_graphics);
            }
        }

        private void AddBuffer(Tools.AbstractTool tool)
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

        void ICanvas.AddBuffer(AbstractTool tool)
        {
            throw new NotImplementedException();
        }
    }
}
