using System;
using System.Drawing;
using System.Windows.Forms;
using VectorDrawing.Canvases;
using VectorDrawing.FactoriesTools;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;
using VectorDrawing.Tools.Polygons;
using VectorDrawing.Actions;
using VectorDrawing.Actions.ContainCalculater;
using System.Threading;


namespace VectorDrawing
{
    public partial class VectorDrawingForm : Form
    {

        private AbstractTool _tool;
        private IFactoryTool _factoryTool;
        private Pen _pen;
        private ICanvas _canvas;
        private bool _isMouseDown;
        private IAction _action;
        private IContaneCalculator _contaneCalculator;
        private bool pipetteButton;

        public VectorDrawingForm()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        private void OnVectorDrawingFormLoad(object sender, EventArgs e)
        {
            _canvas = new BitmapCanvas();
            _canvas.SetRender(OnRender);
            _canvas.Create(pictureBox.Width, pictureBox.Height);
            _pen = new Pen(Color.Black, 1);
            _contaneCalculator = new OnInside();        //тут выбор фигур - по граням или по всей фигуре
        }

        private void OnRender(Bitmap bitmap, Color color)
        {
            pictureBox.Image = bitmap;
            pictureBox.BackColor = color;
        }


        // Действия с мышкой на puctureBox'е
        private void OnPictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            Coordinates.Text = $"X = {e.Location.X} Y = {e.Location.Y}";
            if (_tool == null) return;

            if (_action == null)
            {
                if (_tool is IBrush && _isMouseDown && !pipetteButton)
                {
                    _tool.AddPoint(e.Location);
                    _canvas.Draw(_tool);
                    return;
                }

                if (!_tool.CheckPointsExist()) return;
                _tool.TemporaryPoint = e.Location;
                _canvas.Draw(_tool);
            }
            else if (_isMouseDown)
            {
                _action.UpdateToolPoints(_tool, _tool.TemporaryPoint, e.Location);
                _canvas.Draw(_tool);
            }
        }

        private void OnPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            if (pipetteButton)
            {
                PaletteButton1.BackColor = _canvas.GetColor(e.Location);
                _tool.Pen.Color = PaletteButton1.BackColor;
            }
            else if (_action == null)
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
                _tool = _canvas.SetToolOnMouse(_contaneCalculator, e.Location);
                _canvas.UpdateBitmap();
            }
        }
        private void OnPictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            if (_action!=null)
            {
                _canvas.FinishFigure();
            }
            else if (_tool is IBrush)
            {
                _canvas.FinishFigure();
                CreateFigure();
            }
        }

        private void CreateFigure()
        {
            pipetteButton = false;
            if (!(_factoryTool is RegularPolygonFactoryTool))
            {
                anglesForPolygonGroupBox.Visible = false;
            }
            HideSubMenu();
            _action = null;
            _pen = new Pen(_pen.Color, _pen.Width);
            _tool = _factoryTool.Create(_pen);
            if (_tool is RegularPolygonTool regularPolygonTool)
            {
                regularPolygonTool.QuantityOfCorners = (int)cornerNumericUpDown.Value;
            }
        }

        // Толщина линий
        private void OnThicknessValueChanged(object sender, EventArgs e)
        {
            _pen.Width = thicknessBar.Value;
            ThicknessValue.Text = $"{_pen.Width}";

        }
        //Выбор цвета
        private void OnCornersNumericUpDownValueChanged(object sender, EventArgs e)
        {
            RegularPolygonTool regularPolygonTool = (RegularPolygonTool)_tool;
            regularPolygonTool.QuantityOfCorners = (int)((NumericUpDown)sender).Value;
        }
        private void OnClearClick(object sender, EventArgs e)
        {
            _canvas.Create(pictureBox.Width, pictureBox.Height);
            GC.Collect();
        }
        private void OnMoveModeButtonClick(object sender, EventArgs e)
        {
            _action = new MoveAction();
            _tool = null;
            HideSubMenu();
        }
        private void OnRotateModeButtonClick(object sender, EventArgs e)
        {
            _action = new RotateAction();
            _tool = null;
            HideSubMenu();
        }
        private void OnChangeScaleModeButton_Click(object sender, EventArgs e)
        {
            _action = new ScaleAction();
            _tool = null;
            HideSubMenu();
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
            if (_action == null)
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
            _canvas.UpdateBitmap();
        }
        private void CustomizeDesing()
        {
            panelTools.Visible = false;
            panelVectorChanges.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelTools.Visible)
            {
                Thread.Sleep(150);
                panelTools.Visible = false; 
            }

            if (panelVectorChanges.Visible)
            {
                Thread.Sleep(150);
                panelVectorChanges.Visible = false; 
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (panelTools.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else if (panelVectorChanges.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void OnToolsButtonClick(object sender, EventArgs e)
        {
            if(panelTools.Visible==true)
            {
                HideSubMenu();
                return;
            }
            ShowSubMenu(panelTools);
        }

        private void OnChangeFigureButtonClick(object sender, EventArgs e)
        {
            ShowSubMenu(panelVectorChanges);
        }

        private void OnPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Coordinates.Text = "";
        }

        private void OnPaletteButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _pen.Color = colorDialog.Color;
                PaletteButton1.BackColor = colorDialog.Color;
            }
        }

        private void OnPaletteButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                PaletteButton2.BackColor = colorDialog.Color;
            }
        }

        private void OnChangeColorButton_Click(object sender, EventArgs e)
        {
            Color tmpColor = PaletteButton1.BackColor;
            PaletteButton1.BackColor = PaletteButton2.BackColor;
            PaletteButton2.BackColor = tmpColor;
            _pen.Color = PaletteButton1.BackColor;
        }

        private void PipetteButton_Click(object sender, EventArgs e)
        {
            pipetteButton = true;
        }
    }
}
