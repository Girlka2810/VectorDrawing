using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing
{
    class Bitmap123
    {

        private Bitmap bitmap;

        private Bitmap123 _instance = null;
        private Action<Bitmap> _render;

        public Bitmap123(Action render)
        {
            // 
        }

        public void RenderBitmap(Bitmap s)
        {
            _render?.Invoke(s);
        }



    }
}
