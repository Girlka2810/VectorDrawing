using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    public class Brush : ITool
    {
        Bitmap  mainBm;
        Graphics  graphics;
        Pen brush = new Pen(Color.Black);
        public void Paint(int x, int y)
        {
           mainBm.SetPixel(x,y,Color.Black);
            
        }
        
    }
}
