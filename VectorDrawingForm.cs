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
using VectorDrawing.Actions;

namespace VectorDrawing
{
    public partial class VectorDrawingForm : Form
    {

        private AbstractTool _tool;

        private IFactoryTool _factoryTool;
        private Pen _pen;
        private ICanvas _canvas;
        private bool _isMouseDown;
        private Mode _mode;
        private int _counter;



        public VectorDrawingForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void OnVectorDrawingFormLoad(object sender, EventArgs e)
        {
            _canvas = new BitmapCanvas();
            _canvas.SetRender(OnRender);
            _canvas.Create(pictureBox.Width, pictureBox.Height);
            _pen = new Pen(Color.Black, 1);
            _counter = 0;
        }

        private void OnRender(Bitmap bitmap, Color color)
        {
            pictureBox.Image = bitmap;
            pictureBox.BackColor = color;
        }

        private void OnPictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (_tool == null) return;
            switch (_mode)
            {
                case Mode.Draw:
                    {
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
                    if (_isMouseDown)
                    {
                        IAction action = new MoveAction();
                        action.UpdateToolPoints(_tool, _tool.TemporaryPoint, e.Location);
                        _canvas.Draw(_tool);
                        _counter++;
                    }
                    break;
                case Mode.Rotate:
                    if (_isMouseDown)
                    {
                        IAction action = new RotateAction();
                        action.UpdateToolPoints(_tool, _tool.TemporaryPoint, e.Location);
                        _canvas.Draw(_tool);
                        _counter++;
                    }
                    break;
            }
    }

        private void OnPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            if (_mode == Mode.Draw)
            {
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
                _tool = _canvas.SetToolOnMouse(e.Location);
                _canvas.UpdateBitmap();
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
            hideSubMenu();
        }

        private void CreateFigure()
        {
            _mode = Mode.Draw;
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
            hideSubMenu();
        }
        
        private void OnBrushButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new BrushFactoryTool();
            CreateFigure();
            hideSubMenu();
        }
        
        private void OnNlineButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new NLineFactoryTool();
            CreateFigure();
            hideSubMenu();
        }
        
        private void OnRectangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new RectangleFactoryTool();
            CreateFigure();
            hideSubMenu();
        }
        
        private void OnSquareButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new SquareFactoryTool();
            CreateFigure();
            hideSubMenu();
        }
        
        private void OnCircleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new CircleFactoryTool();
            CreateFigure();
            hideSubMenu();
        }
        
        private void OnEllipseButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new EllipseFactoryTool();
            CreateFigure();
            hideSubMenu();
        }
        
        private void OnRectangularTriangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new RectangularTriangleFactoryTool();
            CreateFigure();
            hideSubMenu();
        }
        
        private void OnTriangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new TriangleFactoryTool();
            CreateFigure();
            hideSubMenu();
        }
        
        private void OnIsoscelesTriangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new IsoscelesTriangleFactoryTool();
            CreateFigure();
            hideSubMenu();
        }

        private void OnPolygonButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new PolygonFactoryTool();
            CreateFigure();
            hideSubMenu();
        }
        
        private void OnRegularPolygonButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new RegularPolygonFactoryTool();
            CreateFigure();
            anglesForPolygonGroupBox.Visible = true;
            ((RegularPolygonTool)_tool).QuantityOfCorners = (int)cornerNumericUpDown.Value;
            hideSubMenu();
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
        private void customizeDesing()
        {
          panelTools.Visible = false;
            panelVectorChanges.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelTools.Visible == true)
             panelTools.Visible = false; 
            if (panelVectorChanges.Visible == true)
             panelVectorChanges.Visible = false; 
        }
        private void showSubMenu(Panel subMenu)
        {
            if (panelTools.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else if (panelVectorChanges.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void ToolsButton_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTools);
        }

        private void ChangeFigureButton_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVectorChanges);
        }

        private void RotateModeButton_Click(object sender, EventArgs e)
        {
            _mode = Mode.Rotate;
        }
    }
}
