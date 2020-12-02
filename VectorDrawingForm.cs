using System;
using System.Drawing;
using System.Windows.Forms;
using VectorDrawing.Tools;

namespace VectorDrawing
{
    public partial class VectorDrawingForm : Form
    {

        private AbstractTool _tool;
        private string _toolName;
        private Pen _pen;
        private Canvases.ICanvas _canvas;


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
            switch (_toolName)
            {
                case "Line":
                    _tool = new LineTool(_pen);
                    break;
                case "Brush":
                    _tool = null;
                    break;
                case "Nline":
                    _tool = null;
                    break;
                case "Rectangle":
                    _tool = null;
                    break;
                case "Square":
                    _tool = null;
                    break;
                case "Circle":
                    _tool = null;
                    break;
                case "Ellipse":
                    _tool = null;
                    break;
                case "Rectangular":
                    _tool = null;
                    break;
                case "Triangle":
                    _tool = null;
                    break;
                case "Polygon":
                    _tool = null;
                    break;
                case "RegularPolygon":
                    _tool = null;
                    break;
            }

            
        }


        private void OnSelectToolButtonsClick(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            switch (name)
            {
                case "LineButton":
                    _toolName = "Line";
                    break;
                case "BrushButton":
                    _toolName = "Brush";
                    break;
                case "NlineButton":
                    _toolName = "Nline";
                    break;
                case "RectangleButton":
                    _toolName = "Rectangle";
                    break;
                case "SquareButton":
                    _toolName = "Square";
                    break;
                case "CircleButton":
                    _toolName = "Circle";
                    break;
                case "EllipseButton":
                    _toolName = "Ellipse";
                    break;
                case "RectangularTriangleButton":
                    _toolName = "Rectangular";
                    break;
                case "TriangleButton":
                    _toolName = "Triangle";
                    break;
                case "AlpelesTriangleButton":
                    _toolName = "AlpelesTriangle";
                    break;
                case "PolygonButton":
                    _toolName = "Polygon";
                    break;
                case "RegularPolygonButton":
                    _toolName = "RegularPolygon";
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
            if (!_tool.CheckPointsExist()) return;
            _tool.TemporaryPoint = e.Location;
            _canvas.Draw(_tool);
        }

        private void OnPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            _tool?.AddPoint(e.Location);
            if(_tool!=null && _tool.CheckMaxQuantityPoints())
            {
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

     


        
    }
}
