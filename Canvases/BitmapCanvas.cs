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
        private Dictionary<string, AbstractTool> _tools;
        private Color _backColor;


        public void Create(int width, int height)
        {
            Create(width, height, Color.White);
        }

        public void Create(int width, int height, Color backcolor)
        {
            _tools = new Dictionary<string, AbstractTool>();
            _mainBitmap = new Bitmap(width, height);
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
                _render = render;
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
            AddBuffer(tool);
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            Graphics graphics = Graphics.FromImage(_tmpBitmap);
            tool.Paint(graphics);

            _render?.Invoke(_tmpBitmap, _backColor);
        }

       
        public void FinishFigure()
        {
            _mainBitmap = _tmpBitmap;
        }
        
        public void Clear(int width, int height)
        {
            _tmpBitmap = new Bitmap(width, height);
            _mainBitmap = _tmpBitmap;
        }

        public override bool Equals(object obj)
        {
            if (obj is List<AbstractTool> tools)
            {
                if (tools.Count == _tools.Count)
                {
                    foreach (var tool in tools)
                    {
                        foreach (var localTool in _tools)
                        {
                            if (!tool.Equals(localTool.Value))
                            {
                                return false;
                            }
                        }
                    }

                    return true;
                }
            }
            return false;
        }

        private void AddBuffer(AbstractTool tool)
        {

            bool isFind = false;
            foreach (var t in _tools)
            {
                if (t.Key == tool.ID)
                {
                    isFind = true;
                }
            }

            if (!isFind)
            {
                _tools.Add(tool.ID,tool);
            }
        }
        
    }
}
