using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Canvases
{
    interface ICanvas
    {
        void Create(int width, int height);
        void Create(int width, int height, Color backcolor);
        void SetRender(Action<Bitmap, Color> render);
        void Draw(Tools.AbstractTool tool);

    }
}
