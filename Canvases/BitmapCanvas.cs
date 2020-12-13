using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorDrawing.Tools;

namespace VectorDrawing.Canvases
{
    public class BitmapCanvas : ICanvas
    {
        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;
        private Action<Bitmap, Color> _render;
        private Dictionary<string, AbstractTool> _tools;
        private Color _backColor;

        public BitmapCanvas()
        {
            
        }
        
        public BitmapCanvas(AbstractTool[] tools)
        {
            _tools = new Dictionary<string, AbstractTool>();
            for (int i = 0; i < tools.Length; i++)
            {
                _tools.Add(tools[i].ID, tools[i]);
            }
        }
        
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
            FinishFigure();
        }

        public override bool Equals(object obj)
        {
            if (obj is BitmapCanvas canvas)
            {
                if (canvas._tools.Count == _tools.Count)
                {
                    foreach (var value in _tools)
                    {
                        if (!canvas._tools.ContainsKey(value.Key))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public Dictionary<string, AbstractTool> GetDictionary()
        {
            return _tools;
        }

        public void DrawAll()
        {
            _mainBitmap = new Bitmap(_mainBitmap.Width, _mainBitmap.Height);
            Graphics graphics = Graphics.FromImage(_mainBitmap);
            foreach(KeyValuePair<string, AbstractTool> keyValuePair in _tools)
            {
                keyValuePair.Value.Paint(graphics);
            }
        }
        public void Update()
        {
            Graphics graphics = Graphics.FromImage(_mainBitmap);
            foreach (KeyValuePair<string, AbstractTool> keyValuePair in _tools)
            {
                keyValuePair.Value.Update(graphics);
            }
        }
        private void AddBuffer(AbstractTool tool)
        {
            if (!_tools.ContainsKey(tool.ID))
            {
                _tools.Add(tool.ID,tool);
            }
        }
        
    }
}
