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
using VectorDrawing.MouseHandlers;


namespace VectorDrawing
{
    public partial class VectorDrawingForm : Form
    {

        private AbstractTool _tool;
        private IFactoryTool _factoryTool;
        private Pen _pen;
        private ICanvas _canvas;
        private IAction _action;
        public IContaneCalculator ContaneCalculator;
        private IMouseHandler _mouseHandler;

        public VectorDrawingForm()
        {
            InitializeComponent();
            CustomizeDesing();
        }


        public void CreateFigure()
        {
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

        public void SetTool(AbstractTool tool)
        {
            _tool = tool;
        }
        

        private void OnVectorDrawingFormLoad(object sender, EventArgs e)
        {
            _canvas = new BitmapCanvas();
            _canvas.SetRender(OnRender);
            _canvas.Create(pictureBox.Width, pictureBox.Height);
            _pen = new Pen(Color.Black, 1);
            ContaneCalculator = new OnInside();        //тут выбор фигур - по граням или по всей фигуре
            _mouseHandler = new DrawMouseHandler();        }

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

            _mouseHandler.OnMouseMove(_canvas, e, _action, _tool, this);
        }

        private void OnPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            _mouseHandler.OnMouseDown(_canvas, e, _action, _tool, this);
           
        }
        private void OnPictureBoxMouseUp(object sender, MouseEventArgs e)
        {

            _mouseHandler.OnMouseUp(_canvas, e, _action, _tool, this);
           
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
            _mouseHandler = new ActionMouseHandler();
            HideSubMenu();
        }
        private void OnRotateModeButtonClick(object sender, EventArgs e)
        {
            _action = new RotateAction();
            _mouseHandler = new ActionMouseHandler();
            _tool = null;
            HideSubMenu();
        }
        private void OnChangeScaleModeButton_Click(object sender, EventArgs e)
        {
            _action = new ScaleAction();
            _mouseHandler = new ActionMouseHandler();
            _tool = null;
            HideSubMenu();
        }
        private void OnLineButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new LineFactoryTool();
            _mouseHandler = new DrawMouseHandler();
            CreateFigure();
        }
        private void OnBrushButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new BrushFactoryTool();
            CreateFigure();
            _mouseHandler = new BrushMouseHandler();
        }
        private void OnNlineButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new NLineFactoryTool();
            _mouseHandler = new DrawMouseHandler();
            CreateFigure();
        }
        private void OnRectangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new RectangleFactoryTool();
            _mouseHandler = new DrawMouseHandler();
            CreateFigure();
        }
        private void OnSquareButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new SquareFactoryTool();
            _mouseHandler = new DrawMouseHandler();
            CreateFigure();
        }
        private void OnCircleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new CircleFactoryTool();
            _mouseHandler = new DrawMouseHandler();
            CreateFigure();
        }
        private void OnEllipseButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new EllipseFactoryTool();
            _mouseHandler = new DrawMouseHandler();
            CreateFigure();
        }
        private void OnRectangularTriangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new RectangularTriangleFactoryTool();
            _mouseHandler = new DrawMouseHandler();
            CreateFigure();
        }
        private void OnTriangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new TriangleFactoryTool();
            _mouseHandler = new DrawMouseHandler();
            CreateFigure();
        }
        private void OnIsoscelesTriangleButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new IsoscelesTriangleFactoryTool();
            _mouseHandler = new DrawMouseHandler();
            CreateFigure();
        }
        private void OnPolygonButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new PolygonFactoryTool();
            _mouseHandler = new DrawMouseHandler();
            CreateFigure();
        }
        private void OnRegularPolygonButtonClick(object sender, EventArgs e)
        {
            _factoryTool = new RegularPolygonFactoryTool();
            _mouseHandler = new DrawMouseHandler();
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
                panelTools.Visible = false;
            }

            if (panelVectorChanges.Visible)
            {
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
            if(panelTools.Visible)
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
            _mouseHandler = new PipetteMouseHandler();
        }

        private void OnOpenButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.SVG;| *.BMP; *.JPG; *.PNG; *.SVG;|All Files(*.*)| *.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _canvas.LoadImage(new Bitmap(fileDialog.FileName));
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
