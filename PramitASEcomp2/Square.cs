using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PramitASEcomp2
{
    /// <summary>
    /// Square class implements the "shape" interface
    /// </summary>
    class Square : ShapeInterface
    {
        public void drawShape(string[] pointvec, Graphics shapeVector, int i, int j)
        {
            int pointPos1 = Convert.ToInt32(pointvec[1]);
            int pointPos2 = Convert.ToInt32(pointvec[2]);
            Pen pen = new Pen(Color.Black, 3);
            shapeVector.DrawRectangle(pen, i, j, pointPos1, pointPos2); //Draws Square according to the given user input
        }
    }
}
