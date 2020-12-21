using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Tools;
using VectorDrawing.Actions.ContainCalculater;

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
            _render?.Invoke(_mainBitmap, backcolor);
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
                AddBuffer(_tool);
                _tool.SavePoints();
                _mainBitmap = _tmpBitmap;
                _render?.Invoke(_tmpBitmap, _backColor);
                _tool = null;
            }
        }

        public void UpdateBitmap()
        {
            _mainBitmap = new Bitmap(_mainBitmap.Width, _mainBitmap.Height);
            Graphics graphics = Graphics.FromImage(_mainBitmap);
            foreach (KeyValuePair<string, AbstractTool> keyValuePair in _tools)
            {
                keyValuePair.Value.Paint(graphics);
            }
            _render?.Invoke(_tmpBitmap, _backColor);
        }
        

        public AbstractTool SetToolOnMouse(IContaneCalculator contaneCalculator, PointF point)
        {
            foreach (var tool in _tools)
            {
                if (contaneCalculator.IsContain(tool.Value, point))
                {
                    _tool = tool.Value;
                    _tool.TemporaryPoint = point;
                }
            }
            MarkVertexes(_tool);
            ReplaceTool(_tool);
            return _tool;
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
        
        private void AddBuffer(AbstractTool tool)
        {
            if (!_tools.ContainsKey(tool.ID))
            {
                _tools.Add(tool.ID,tool);
            }
        }
        
        private void ReplaceTool(AbstractTool tool)
        {
            if (tool != null && _tools.ContainsKey(tool.ID))
            {
                _tools.Remove(tool.ID);
            }
        }
        public Color GetColor(PointF pointF)
        {
            return
            _mainBitmap.GetPixel((int)pointF.X,(int)pointF.Y);
        }
      
        private void MarkVertexes(AbstractTool tool)
        {
            if (tool == null) return;
            Graphics graphics = Graphics.FromImage(_mainBitmap);
            RectangleF rectangle = new RectangleF();
            Size size = new Size(4, 4);
            rectangle.Size = size;
            for (int i = 0; i < tool.EndShapePoints.Length; i++)
            {
                rectangle.X = tool.EndShapePoints[i].X - 2;
                rectangle.Y = tool.EndShapePoints[i].Y - 2;
                graphics.DrawEllipse(tool.PenForVertexes, rectangle);
            }
        }
    }
}
