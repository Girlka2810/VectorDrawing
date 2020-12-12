using System;
using System.Drawing;
using System.Windows.Forms;
using VectorDrawing.Canvases;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;

namespace VectorDrawing
{
    public partial class VectorDrawingForm : Form
    {

        private AbstractTool _tool;
        private Enums.ToolsName _toolName;
        private Pen _pen;
        private Canvases.ICanvas _canvas;
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
                    _tool = null;
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
                    _tool = null;
                    break;
                case Enums.ToolsName.RegularPolygon:
                    groupBox1.Visible = true;
                    _tool = new RegularPolygonTool(_pen, Convert.ToInt32(CornerNumericUpDown.Value));
                    break;
            }

            
        }


        private void OnSelectToolButtonsClick(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            switch (name)
            {
                case "LineButton":
                    _toolName = Enums.ToolsName.Line;
                    break;
                case "BrushButton":
                    _toolName = Enums.ToolsName.Brush;
                    break;
                case "NlineButton":
                    _toolName = Enums.ToolsName.Nline;
                    break;
                case "RectangleButton":
                    _toolName = Enums.ToolsName.Rectangle;
                    break;
                case "SquareButton":
                    _toolName = Enums.ToolsName.Square;
                    break;
                case "CircleButton":
                    _toolName = Enums.ToolsName.Circle;
                    break;
                case "EllipseButton":
                    _toolName = Enums.ToolsName.Ellipse;
                    break;
                case "RectangularTriangleButton":
                    _toolName = Enums.ToolsName.Rectangular;
                    break;
                case "TriangleButton":
                    _toolName = Enums.ToolsName.Triangle;
                    break;
                case "IsoscelesTriangleButton":
                    _toolName = Enums.ToolsName.IsoscelesTriangle;
                    break;
                case "PolygonButton":
                    _toolName = Enums.ToolsName.Polygon;
                    break;
                case "RegularPolygonButton":
                    _toolName = Enums.ToolsName.RegularPolygon;
                    break;
                default:
                    _tool = null;
                    break;
                    
            }
            SetTool();
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
            _pen = new Pen(_pen.Color)
            {
                Width = (int) ((NumericUpDown) sender).Value
            };
        }

        private void OnColorFrontButtonClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                float width = _pen.Width;
                _pen = new Pen(colorDialog.Color)
                {
                    Width = width
                };
            }
        }

        private void CornerNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RegularPolygonTool regularPolygonTool = (RegularPolygonTool)_tool;
            regularPolygonTool.QuantityOfCorners = (int)((NumericUpDown)sender).Value;
        }

        private void Clear_Click(object sender, EventArgs e)
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
        private void MoveModeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
