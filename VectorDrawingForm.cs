using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorDrawing.Tools;

namespace VectorDrawing
{
    public partial class VectorDrawingForm : Form
    {

        private AbstractTool _tool;
        private Pen _pen;
        private bool _canDraw;

        public VectorDrawingForm()
        {
            InitializeComponent();
        }

        private void OnVectorDrawingFormLoad(object sender, EventArgs e)
        {
            Canvas.SetRender(OnRender);
            Canvas.Create(pictureBox.Width, pictureBox.Height);
            _pen = new Pen(Color.Black, 1);
        }

        private void OnRender(Bitmap bitmap, Color color)
        {
            pictureBox.Image = bitmap;
            pictureBox.BackColor = color;
        }

        private void OnSelectToolButtonsClick(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            switch(name)
            {
                case "LineButton":
                    _tool = new Line(_pen);
                    break;
                default:
                    _tool = null;
                    break;
            }
        }

        private void OnPictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if(_tool!=null && _canDraw)
            {
                _tool.AddPoint(e.Location);
                Canvas.Draw(_tool);
            }
        }

        private void OnPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            _canDraw = true;
            _tool?.ClearPoints();
            _tool?.AddPoint(e.Location);
        }

        private void OnThicknessValueChanged(object sender, EventArgs e)
        {
            _pen.Width = (int)((NumericUpDown)sender).Value;
            _tool?.SetPen(_pen);
            if (_tool != null)
            {
                Canvas.Draw(_tool);
            }
        }

        private void OnColorFrontButtonClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _pen.Color = colorDialog.Color;
                _tool?.SetPen(_pen);
                if(_tool!=null)
                {
                    Canvas.Draw(_tool);
                }    
            }
        }

        private void OnPictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            _canDraw = false;
        }
    }
}
