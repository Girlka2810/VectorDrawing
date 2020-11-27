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
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            graphics = Graphics.FromImage(bitmap);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
