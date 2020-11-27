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
        Pen brush=new Pen(Color.Black,4);
        Color color = Color.DeepPink;
        Point prevPoint;
        public VectorDrawing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainBm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(mainBm);
            brush = new Pen(color, 3);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            graphics.DrawLine(brush, prevPoint, e.Location);
            pictureBox1.Image = mainBm;
            prevPoint = e.Location;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            graphics.DrawLine(brush, prevPoint, e.Location);
            pictureBox1.Image = mainBm;
            prevPoint = e.Location;
        }
    }
}
