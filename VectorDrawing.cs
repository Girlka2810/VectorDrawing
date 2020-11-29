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
    public partial class VectorDrawing : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Point prevPoint = new Point();
        ITool tool;
        AbstractTool tool1;
        bool mouseDown = false;

        public VectorDrawing()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            tool1 = new SquareTest(bitmap);
            //numericUpDown1.Value = 3;
        }


        private void BrushButton_Click(object sender, EventArgs e)
        {
            
        }
        private void for_paint()
        {

        }

      

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                //tool.Paint(prevPoint, e.Location);
                tool1.AddPoint(e.Location);
                pictureBox1.Image = bitmap;
            }
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Bitmap crnt = (Bitmap)bitmap.Clone();
            tool = new Square(crnt);
        }



        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            mouseDown = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tool.PenOfTool.Width = (int)(((NumericUpDown)sender).Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tool.PenOfTool.Color = colorDialog1.Color;

            }
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            tool = new StraightLine(bitmap);
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            tool1.AddPoint(e.Location);
            prevPoint = e.Location;
            mouseDown = true;
        }
    }
}
