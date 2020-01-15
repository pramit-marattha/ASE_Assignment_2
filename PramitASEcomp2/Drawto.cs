using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PramitASEcomp2
{
    /// <summary>
    /// DrawTo class implements the "shape" interface
    /// </summary>
    class Drawto : ShapeInterface
    {
        public void drawShape(string[] res, Graphics shapeVector, int k, int l)
        {
            int point1 = Convert.ToInt32(res[1]);
            int point2 = Convert.ToInt32(res[2]);
            Pen drawpen = new Pen(Color.Black, 7);
            shapeVector.DrawLine(drawpen, k, l, point1, point2);
        }
    }
}
