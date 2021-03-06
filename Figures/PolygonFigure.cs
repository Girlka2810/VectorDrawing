﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    public class PolygonFigure : IFigure
    {
        public FigureReturn Get(FigureParameter parameter)
        {
            if(parameter is CommonParameter figureParameter)
            {
                PointF[] tmp = new PointF[figureParameter.Points.Length + 1];
                Array.Copy(figureParameter.Points, tmp, figureParameter.Points.Length);
                tmp[tmp.Length - 1] = parameter.TemporaryPoint;
                return new CommonReturn() { Points = tmp };
            }
            return new FigureReturn();
        }
    }
}
