using System;
using System.Drawing;
using System.Windows.Forms;
using VectorDrawing.Canvases;
using VectorDrawing.FactoriesTools;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;
using VectorDrawing.Tools.Ellipse;
using VectorDrawing.Tools.Polygons;
using VectorDrawing.Enums;
using System.Collections.Generic;

namespace VectorDrawing
{
    public partial class VectorDrawingForm : Form
    {

        private AbstractTool _tool;
        private IFactoryTool _factoryTool;
        private Pen _pen;
        private ICanvas _canvas;
        private bool _isMouseDown = false;
        private Mode _mode;
        


        public VectorDrawingForm()
        {
            InitializeComponent();
        }

        private void OnVectorDrawingFormLoad(object sender, EventArgs e)
        {
            _canvas = new BitmapCanvas();
            _canvas.SetRender(OnRender);
            _canvas.Create(pictureBox.Width, pictureBox.Height);
            _pen = new Pen(Color.Black, 1);
            _mode = Mode.Draw;
        }

        private void OnRender(Bitmap bitmap, Color color)
        {
            pictureBox.Image = bitmap;
            pictureBox.BackColor = color;
        }




        private void OnPictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            switch (_mode)
            {

                case Mode.Draw:
                    {
                        if (_tool == null) return;
                        if (_tool is IBrush && _isMouseDown)
                        {
                            _tool.AddPoint(e.Location);
                            _canvas.Draw(_tool);
                            return;
                        }

                        if (!_tool.CheckPointsExist()) return;
                        _tool.TemporaryPoint = e.Location;
                        _canvas.Draw(_tool);
                    }
                    break;
                case Mode.Move:
                    if (_tool != null)
                    {
                        PointF point = e.Location;
                         PointF delta = new PointF(point.X - _tool.TemporaryPoint.X,
                            point.Y - _tool.TemporaryPoint.Y );
                        _tool.Move(delta);
                        _canvas.Draw(_tool);
                       _tool.TemporaryPoint = e.Location;
                    }
                    break;
            }
        }

        private void OnPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            switch(_mode)
            {
                case Mode.Draw:
                    {
                        _isMouseDown = true;
                        _tool?.AddPoint(e.Location);

                        if (_tool != null && _tool.CheckMaxQuantityPoints())
                        {
                            _canvas.Draw(_tool);
                            _canvas.FinishFigure();
                            CreateFigure();
                        }
                    }
                    break;
                case Mode.Move:
                    _tool = null;
                    Dictionary<string, AbstractTool> dict = _canvas.GetDictionary();
                    AbstractTool currentTool;
                    List<string> IDS = new List<string>();
                    foreach(KeyValuePair<string, AbstractTool> keyValue in dict)
                    {
                        IDS.Add(keyValue.Key);
                    }
                    for (int i = 0; i < dict.Count; i++)
                    {
                        currentTool = dict[IDS[i]];
                        if (currentTool.IsItYou(e.Location))
                        {
                            _tool = currentTool;
                            _tool.TemporaryPoint = e.Location;
                            dict.Remove(IDS[i]);
                        }
                    }
                    break;
            }
        }

        private void OnThicknessValueChanged(object sender, EventArgs e)
        {
            _pen.Width = (int) ((NumericUpDown) sender).Value;
          
        }

        private void OnColorFrontButtonClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _pen.Color = colorDialog.Color;
            }
        }

        private void OnCornersNumericUpDownValueChanged(object sender, EventArgs e)
        {
            RegularPolygonTool regularPolygonTool = (RegularPolygonTool)_tool;
            regularPolygonTool.QuantityOfCorners = (int)((NumericUpDown)sender).Value;
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            _canvas.Clear(pictureBox.Width, pictureBox.Height);
        }

        private void OnPictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            if (_tool is IBrush)
            {
                _canvas.FinishFigure();
                CreateFigure();
            }
        }

        private void OnMoveModeButtonClick(object sender, EventArgs e)
        {
            _mode = Mode.Move;
            _tool = null;
        }

        private void CreateFigure()
        {
            _pen = new Pen(_pen.Color, _pen.Width);
            _tool = _factoryTool.Create(_pen);
            if (_tool is RegularPolygonTool regularPolygonTool)
            {
                regularPolygonTool.QuantityOfCorners = (int)CornerNumericUpDown.Value;
            }
        }
        
        
        private void OnLineButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new LineFactoryTool();
            CreateFigure();
        }
        
        private void OnBrushButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new BrushFactoryTool();
            CreateFigure();
        }
        
        private void OnNlineButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new NLineFactoryTool();
            CreateFigure();
        }
        
        private void OnRectangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new RectangleFactoryTool();
            CreateFigure();
        }
        
        private void OnSquareButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new SquareFactoryTool();
            CreateFigure();
        }
        
        private void OnCircleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new CircleFactoryTool();
            CreateFigure();
        }
        
        private void OnEllipseButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new EllipseFactoryTool();
            CreateFigure();
        }
        
        private void OnRectangularTriangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new RectangleFactoryTool();
            CreateFigure();
        }
        
        private void OnTriangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new TriangleFactoryTool();
            CreateFigure();
        }
        
        private void OnIsoscelesTriangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new IsoscelesTriangleFactoryTool();
            CreateFigure();
        }
        
        private void OnPolygonButtonClick(object sender, EventArgs e)
        {
         
        }
        
        private void OnRegularPolygonButtonClick(object sender, EventArgs e)
        {
            anglesForPolygonGroupBox.Visible = true;
            _factoryTool = new RegularPolygonFactoryTool();
            CreateFigure();
        }
        
    }
}
