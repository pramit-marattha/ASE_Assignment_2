using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PramitASEcomp2
{
    /// <summary>
    /// Circle class implements the "shape" interface
    /// </summary>
    class Circle : ShapeInterface
    {
        public void drawShape(string[] circlePos, Graphics shapeVector, int k, int l)
        {
            // int radius = 50;
            int inputRadius1 = Convert.ToInt32(circlePos[1]);
            int inputRadius2 = Convert.ToInt32(circlePos[1]);
            Pen p = new Pen(Color.Black, 5);
            //shapeVector.Drawcircle(p, k, l, inputRadius1, inputRadius2);
            shapeVector.DrawEllipse(p, k, l, inputRadius1, inputRadius2);
        }
    }
}
