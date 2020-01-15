using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PramitASEcomp2
{
    class ShapeFactory
    {/// <summary>
     ///Shape factory is created
     /// </summary>
     /// <param shape_identifier="shadeshape"></param>
     /// <returns></returns>
        public ShapeInterface getShape(string shadeShape)
        {
            shadeShape = shadeShape.ToUpper().Trim(); //function that converts given lower case alphabets into upper case ..and trim cut the spaces.

            if (shadeShape.Equals("CIRCLE"))
            {
                return new Circle(); //constructor
            }
            else if (shadeShape.Equals("DRAWTO"))
            {
                return new Drawto(); //constructor
            }
            else if (shadeShape.Equals("RECTANGLE"))
            {
                return new Rectangle(); //constructor
            }
            else if (shadeShape.Equals("TRIANGLE"))
            {
                return new Triangle(); //constructor
            }
            else if (shadeShape.Equals("POLYGON"))
            {
                return new Polygon(); //constructor
            }
            else
            {
                System.ArgumentException argEx = new System.ArgumentException("ERROR!! : " + shadeShape + " ");
                throw argEx;
            }
        }
    }
}
