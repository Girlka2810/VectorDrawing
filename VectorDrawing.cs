using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorDrawing
{
    public partial class VectorDrawing : Form
    {
        Bitmap mainBm;
        Graphics graphics;
        Pen brush = new Pen(Color.Black, 4);
        Color CurrentColor = Color.Black;
        Point currentPoint;
        Point prevPoint;
        bool isPressed = false;
        public VectorDrawing()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void BrushButton_Click(object sender, EventArgs e)
        {
            Pen brush = new Pen(CurrentColor);
        }
        private void for_paint()
        {
            Pen brush = new Pen(CurrentColor);
            graphics.DrawLine(brush, prevPoint, currentPoint);
        }

        private void BrushButton_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            currentPoint = e.Location;


        }

        private void BrushButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                prevPoint = currentPoint;
                currentPoint = e.Location;
                for_paint();
            }
        }

        private void BrushButton_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }
    }
}
