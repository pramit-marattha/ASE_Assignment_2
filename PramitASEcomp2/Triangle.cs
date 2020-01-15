using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PramitASEcomp2
{
    /// <summary>
    /// Triangle class implements the "shape" interface
    /// </summary>
    class Triangle : ShapeInterface
    {
        public void drawShape(string[] inputpoint, Graphics objGraphic, int k, int l)
        {
            int base1 = Convert.ToInt32(inputpoint[1]);
            int adjacent = Convert.ToInt32(inputpoint[2]);
            int hypotenuse = Convert.ToInt32(inputpoint[3]);
            int trianglePosPoint = 0;
            int triSidePoint = 0;
            if (base1 + adjacent > hypotenuse && base1 + hypotenuse > adjacent && adjacent + hypotenuse > base1)
            {
                /// <summary>
                /// Triangle class implements the "shape" interface
                /// </summary>
                if (adjacent > base1)
                {
                    if (hypotenuse > adjacent)
                    {
                        triSidePoint = hypotenuse;
                        hypotenuse = base1;
                        base1 = triSidePoint;
                    }
                    else
                    {
                        triSidePoint = adjacent;
                        adjacent = base1;
                        base1 = triSidePoint;
                    }
                }
                if (hypotenuse > base1)
                {
                    triSidePoint = hypotenuse;
                    hypotenuse = base1;
                    base1 = triSidePoint;
                }
                double sides = (base1 + adjacent + hypotenuse) / 2; // formula of area of triangle
                double area = Math.Sqrt(sides * (sides - base1) * (sides - adjacent) * (sides - hypotenuse));    // aea of triangle(s(s-a)(s-b)(s-c))^1/2
                double h = 2 * area / base1;
                double point = (h * h) - (adjacent * adjacent);
                int sh = Convert.ToInt32(h);
                if (point < 0)
                {
                    point *= (-1);
                    double temp = Math.Sqrt(point);
                    trianglePosPoint = Convert.ToInt32(temp);
                }
                else
                {
                    double temp = Math.Sqrt(point);
                    trianglePosPoint = Convert.ToInt32(temp);
                }
                Point[] points = new Point[3];
                points[0] = new Point(k, l);
                points[1] = new Point(k, base1);
                points[2] = new Point(sh, trianglePosPoint);
                Pen pen = new Pen(Color.Black, 4);
                objGraphic.DrawLine(pen, points[0], points[1]);
                objGraphic.DrawLine(pen, points[1], points[2]);
                objGraphic.DrawLine(pen, points[0], points[2]);
            }
            else
            {
                MessageBox.Show("Triangle cannot be formed");
            }
        }

        // this.dispose(true);
    }
}


