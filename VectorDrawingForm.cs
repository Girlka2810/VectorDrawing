﻿using System;
using System.Drawing;
using System.Windows.Forms;
using VectorDrawing.Canvases;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;
using VectorDrawing.Tools.Ellipse;
using VectorDrawing.Tools.Polygons;

namespace VectorDrawing
{
    public partial class VectorDrawingForm : Form
    {

        private AbstractTool _tool;
        private Enums.ToolsName _toolName;
        private Pen _pen;
        private ICanvas _canvas;
        private bool _isMouseDown = false;


        public VectorDrawingForm()
        {
            InitializeComponent();
        }

        private void OnVectorDrawingFormLoad(object sender, EventArgs e)
        {
            _canvas = new Canvases.BitmapCanvas();
            _canvas.SetRender(OnRender);
            _canvas.Create(pictureBox.Width, pictureBox.Height);
            _pen = new Pen(Color.Black, 1);
        }

        private void OnRender(Bitmap bitmap, Color color)
        {
            pictureBox.Image = bitmap;
            pictureBox.BackColor = color;
        }


        private void SetTool()
        {
            groupBox1.Visible = false;
            switch (_toolName)
            {
                case Enums.ToolsName.Line:
                    _tool = new LineTool(_pen);
                    break;
                case Enums.ToolsName.Brush:
                    _tool =new BasicBrush(_pen);
                    break;
                case Enums.ToolsName.Nline:
                    _tool = new NLineTool(_pen);
                    break;
                case Enums.ToolsName.Rectangle:
                    _tool = new RectangleTool(_pen);
                    break;
                case Enums.ToolsName.Square:
                    _tool = new SquareTool(_pen);
                    break;
                case Enums.ToolsName.Circle:
                    _tool = new CircleTool(_pen);
                    break;
                case Enums.ToolsName.Ellipse:
                    _tool = new EllipseTool(_pen);
                    break;
                case Enums.ToolsName.Rectangular:
                    _tool = new RectangularTriangleTool(_pen);
                    break;
                case Enums.ToolsName.Triangle:
                    _tool = new TriangleTool(_pen);
                    break;
                case Enums.ToolsName.IsoscelesTriangle:
                    _tool = new IsoscelesTriangleTool(_pen);
                    break;
                case Enums.ToolsName.Polygon:
                    _tool = new PolygonTool(_pen);
                    break;
                case Enums.ToolsName.RegularPolygon:
                    groupBox1.Visible = true;
                    _tool = new RegularPolygonTool(_pen, Convert.ToInt32(CornerNumericUpDown.Value));
                    break;
            }

            
        }

        private void OnPictureBoxMouseMove(object sender, MouseEventArgs e)
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

        private void OnPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            _tool?.AddPoint(e.Location);

            if(_tool!=null && _tool.CheckMaxQuantityPoints())
            {
                _canvas.Draw(_tool);
                _canvas.FinishFigure();
                SetTool();
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
                SetTool();
            }
        }
        private void OnMoveModeButtonClick(object sender, EventArgs e)
        {

        }
        
        private void OnLineButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.Line;
            SetTool();
        }
        
        private void OnBrushButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.Brush;
            SetTool();
        }
        
        private void OnNlineButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.Nline;
            SetTool();
        }
        
        private void OnRectangleButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.Rectangle;
            SetTool();
        }
        
        private void OnSquareButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.Square;
            SetTool();
        }
        
        private void OnCircleButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.Circle;
            SetTool();
        }
        
        private void OnEllipseButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.Ellipse;
            SetTool();
        }
        
        private void OnRectangularTriangleButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.Rectangular;
            SetTool();
        }
        
        private void OnTriangleButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.Triangle;
            SetTool();
        }
        
        private void OnIsoscelesTriangleButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.IsoscelesTriangle;
            SetTool();
        }
        
        private void OnPolygonButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.Polygon;
            SetTool();
        }
        
        private void OnRegularPolygonButtonClick(object sender, EventArgs e)
        {
            _toolName = Enums.ToolsName.RegularPolygon;
            SetTool();
        }
        
    }
}
