using System;
using System.Collections.Generic;
using System.Drawing;
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
        private AbstractTool _tool;

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

            _tool = tool;
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            Graphics graphics = Graphics.FromImage(_tmpBitmap);
            tool.Paint(graphics);

            _render?.Invoke(_tmpBitmap, _backColor);
        }

       
        public void FinishFigure()
        {
            if (_tool != null)
            {
               if (_tool is SquareTool) _tool.SavePoints();
                AddBuffer(_tool);
                _mainBitmap = _tmpBitmap;
                _tool = null;
            }
        }
        
        public List<AbstractTool> GetTools()
        {
            List<AbstractTool> abstractTools = new List<AbstractTool>();
            foreach(KeyValuePair<string, AbstractTool> keyValuePair in _tools)
            {
                abstractTools.Add(keyValuePair.Value);
            }
            return abstractTools;
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
        public void UpdateDictionary(List<AbstractTool> abstractTools)
        {
            _tools = new Dictionary<string, AbstractTool>();
            for (int i = 0; i < abstractTools.Count; i++)
            {
                _tools.Add(abstractTools[i].ID, abstractTools[i]);
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
