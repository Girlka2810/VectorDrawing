using System;
using System.Drawing;
using System.Windows.Forms;
using VectorDrawing.Canvases;
using VectorDrawing.FactoriesTools;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;
using VectorDrawing.Tools.Polygons;
using VectorDrawing.Enums;
using System.Collections.Generic;

namespace VectorDrawing
{
    public partial class VectorDrawingForm : Form
    {

        private AbstractTool _tool;
        private List<AbstractTool> _tools;
        private IFactoryTool _factoryTool;
        private Pen _pen;
        private ICanvas _canvas;
        private bool _isMouseDown;
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
                    
                //    if (_tool != null)
                //    {
                //        PointF point = e.Location;
                //         PointF delta = new PointF(point.X - _tool.TmpMovePoint.X,
                //            point.Y - _tool.TmpMovePoint.Y );
                //        _tool.Move(delta);
                //       _tool.TemporaryPoint = e.Location;
                //        _canvas.Update();
                //        //_canvas.Draw(_tool);
                //    }
                    break;
            }
        }

        private void OnPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            if (_mode == Mode.Draw)
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
            else
            {
                switch (_mode)
                {
                    case Mode.Move:
                        _tool = null;
                        _tools = _canvas.GetTools();
                        foreach (AbstractTool tool in _tools)
                        {
                            if (tool.IsItYou(e.Location))
                            {
                                _tool = tool;
                                _tools.Remove(tool);
                                _canvas.UpdateDictionary(_tools);
                                _canvas.DrawAll();

                                _pen.Color = tool.Pen.Color;
                                _pen.Width = tool.Pen.Width;

                                break;
                            }
                        }
                        break;
                    case Mode.Rotate:
                        break;
                }
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
            _canvas.Clear();
            GC.Collect();
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
                regularPolygonTool.QuantityOfCorners = (int)cornerNumericUpDown.Value;
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
            _factoryTool = new RectangularTriangleFactoryTool();
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
            _factoryTool = new PolygonFactoryTool();
            CreateFigure();
        }
        
        private void OnRegularPolygonButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new RegularPolygonFactoryTool();
            CreateFigure();
            anglesForPolygonGroupBox.Visible = true;
            ((RegularPolygonTool)_tool).QuantityOfCorners = (int)cornerNumericUpDown.Value;
            
        }
        
        private void OnPictureBoxMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_mode == Mode.Draw)
            {
                _tool?.AddPoint(e.Location);
                _canvas.Draw(_tool);
                _canvas.FinishFigure();
                CreateFigure();
            }
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            if (pictureBox.Image!=null)
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Title = "Сохранить картинку как...";
                fileDialog.OverwritePrompt = true;
                fileDialog.CheckPathExists = true;
                fileDialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG| Image Files(*.PNG)|*.PNG|" +
                    "Image Files(*.SVG)|*.SVG|All Files(*.*)|*.*";
                fileDialog.ShowHelp = true;
                if(fileDialog.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        pictureBox.Image.Save(fileDialog.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        

        private void OnPictureBoxSizeChanged(object sender, EventArgs e)
        {
            _canvas.Create(pictureBox.Width, pictureBox.Height);
            _canvas.DrawAll();
        }
    }
}
