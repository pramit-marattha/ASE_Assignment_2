using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PramitASEcomp2
{/// <summary>
/// class validator for validation
/// </summary>
    public class Check
    {
        /// <summary>
        /// Checking the syntax correctly and validating it.
        /// </summary>
        /// <param commands="a"></param>
        /// <returns></returns>
        public string[] getValidate(string a)
        {
            string[] methodArray = new string[100];

            string[] blockCommand = {};
           
            string[] send = a.Split(',',' ');

            if (send[0].ToUpper() == "MOVETO") //function that converts given lower case alphabets into upper case.
            {
                if (send.Length == 3)
                {
                    int x = Convert.ToInt32(send[1]);
                    int y = Convert.ToInt32(send[2]);
                    string a1 = Convert.ToString(x);
                    string b1 = Convert.ToString(y);
                    string[] k = { "moveto", a1, b1 };
                    blockCommand = k;
                }
                else
                {

                    string[] k = { "errormoveto" };
                    blockCommand = k;
                }
            }
            else if (send[0].ToUpper() == "DRAWTO")//function that converts given lower case alphabets into upper case.
            {
                if (send.Length == 3)
                {
                    int x = Convert.ToInt32(send[1]);
                    int y = Convert.ToInt32(send[2]);
                    string a1 = Convert.ToString(x);
                    string b1 = Convert.ToString(y);
                    string[] k = { "drawto", a1, b1 };
                    blockCommand = k;
                }
                else
                {//identifier 
                    string[] k = { "errordrawto" };
                    blockCommand = k;
                }
            }
            else if (send[0].ToUpper() == "RECTANGLE")//function that converts given lower case alphabets into upper case.
            {
                if (send.Length == 3)
                {
                    if (send[1].ToUpper() == "WIDTH" || send[1].ToUpper() == "HEIGHT")//function that converts given lower case alphabets into upper case.
                    {

                        if (send[2].ToUpper() == "WIDTH" || send[2].ToUpper() == "HEIGHT")//function that converts given lower case alphabets into upper case.
                        {
                            string[] side = { "rectangle3" };
                            blockCommand = side;
                        }
                        else
                        {
                            int y = Convert.ToInt32(send[2]);
                            string b1 = Convert.ToString(y);
                            string[] side = { "rectangle2", b1 };
                            blockCommand = side;
                        }
                    }
                    else if (send[2].ToUpper() == "WIDTH" || send[2].ToUpper() == "HEIGHT")
                    {

                        if (send[1].ToUpper() == "WIDTH" || send[1].ToUpper() == "HEIGHT")
                        {
                            string[] side = { "rectangle3" };
                            blockCommand = side;
                        }
                        else
                        {
                            int x = Convert.ToInt32(send[1]);
                            string a1 = Convert.ToString(x);
                            string[] side = { "rectangle4", a1 };
                            blockCommand = side;
                        }
                    }

                    else
                    {
                        int x = Convert.ToInt32(send[1]);
                        int y = Convert.ToInt32(send[2]);
                        string a1 = Convert.ToString(x);
                        string b1 = Convert.ToString(y);
                        string[] k = { "rectangle", a1, b1 };
                        blockCommand = k;
                    }

                }

                else
                { string[] k = { "rectangleerror" }; blockCommand = k; }
            }
            else if (send[0].ToUpper() == "WIDTH")//function that converts given lower case alphabets into upper case.
            {
                if (send.Length == 2)
                { int x = Convert.ToInt32(send[1]); string a1 = Convert.ToString(x); string[] k = { "width", a1 }; blockCommand = k; }
                else if (send.Length == 3)
                {
                    if (send[1] == "+")
                    { int x = Convert.ToInt32(send[2]); string a1 = Convert.ToString(x); string[] k = { "width2", a1 }; blockCommand = k; }
                    else
                    { string[] k = { "widtherror" }; blockCommand = k; }
                }
                else
                { string[] k = { "widtherror" }; blockCommand = k; }
            }
            else if (send[0].ToUpper() == "HEIGHT")
            {
                if (send.Length == 2)
                { int x = Convert.ToInt32(send[1]); string a1 = Convert.ToString(x); string[] k = { "height", a1 }; blockCommand = k; }
                else if (send.Length == 3)
                {
                    if (send[1] == "+")
                    { int x = Convert.ToInt32(send[2]); string a1 = Convert.ToString(x); string[] k = { "height2", a1 }; blockCommand = k; }
                    else
                    { string[] k = { "heighterror" }; blockCommand = k; }
                }
                else
                { string[] k = { "heighterror" }; blockCommand = k; }
            }
            else if (send[0].ToUpper() == "CIRCLE")//function that converts given lower case alphabets into upper case.
            {
                if (send.Length == 2)
                {
                    if (send[1].ToUpper() == "RADIUS")
                    { string[] radius2 = { "circle2" }; blockCommand = radius2; }
                    else
                    { int x = Convert.ToInt32(send[1]); string a1 = Convert.ToString(x + x); string[] radius2 = { "circle", a1 }; blockCommand = radius2; }
                }
                else
                { string[] k = { "circleerror" }; blockCommand = k; }
            }
            else if (send[0].ToUpper() == "RADIUS")//function that converts given lower case alphabets into upper case.
            {
                if (send.Length == 2)
                {
                    try
                    { int x = Convert.ToInt32(send[1]); string a1 = Convert.ToString(x); string[] k = { "radius", a1 }; blockCommand = k; }
                    catch
                    { MessageBox.Show("Somethings not right"); //message box pop up command
                    }
                }
                else if (send.Length == 3)
                {
                    if (send[1] == "+")
                    { int x = Convert.ToInt32(send[2]); string a1 = Convert.ToString(x); string[] k = { "radius2", a1 }; blockCommand = k; }
                    else
                    { string[] k = { "radiuserror" }; blockCommand = k; }
                }
                else
                { string[] k = { "radiuserror" }; blockCommand = k; }
            }
            else if (send[0].ToUpper() == "TRIANGLE")//function that converts given lower case alphabets into upper case.
                {
                if (send.Length == 4)
                { int x = Convert.ToInt32(send[1]); int y = Convert.ToInt32(send[2]); int z = Convert.ToInt32(send[3]); string a1 = Convert.ToString(x); string b1 = Convert.ToString(y); string c1 = Convert.ToString(z); string[] k = { "triangle", a1, b1, c1 }; blockCommand = k; }
                else
                { string[] k = { "triangleerror" }; blockCommand = k; }
            }
            else if (send[0].ToUpper() == "LOOP")//function that converts given lower case alphabets into upper case.
                {
                try
                {
                    if (send.Length == 2)
                    { int x = Convert.ToInt32(send[1]); string a1 = Convert.ToString(x); string[] k = { "loop", a1 }; blockCommand = k; }
                    else
                    { string[] k = { "looperror" }; blockCommand = k; }
                }
                catch
                { MessageBox.Show("Somethings not right");//message box popup command 
                }
            }



            else if (send[0].ToUpper() == "END")//function that converts given lower case alphabets into upper case.
            {
                string[] k = { "end" }; blockCommand = k;
            }
            else if (send[0].ToUpper() == "ENDIF")//function that converts given lower case alphabets into upper case.
            { string[] k = { "endif" }; blockCommand = k; }
            else if (send[0].ToUpper() == "ENDMETHOD")//function that converts given lower case alphabets into upper case.
            { string[] k = { "endmethod" }; blockCommand = k; }
            else if (send[0].ToUpper() == "IF")//function that converts given lower case alphabets into upper case.
            {
                if (send.Length == 4)
                {
                    if (send[2] == "=" || send[2] == "<" || send[2] == ">")
                    {
                        int x = Convert.ToInt32(send[3]); string a1 = send[1]; string a2 = send[2]; string a3 = Convert.ToString(x); if (a1.ToUpper() == "WIDTH")//function that converts given lower case alphabets into upper case.
                        { string[] k = { "ifw", a1, a2, a3 }; blockCommand = k; }
                        else if (a1.ToUpper() == "HEIGHT")//function that converts given lower case alphabets into upper case.
                        { string[] k = { "ifh", a1, a2, a3 }; blockCommand = k; }
                        else if (a1.ToUpper() == "RADIUS")//function that converts given lower case alphabets into upper case.
                        { string[] k = { "ifr", a1, a2, a3 }; blockCommand = k; }
                        else
                        { string[] k = { "iferror" }; blockCommand = k; }
                    }
                    else
                    { string[] k = { "iferror" }; blockCommand = k; }
                }
                else
                { string[] k = { "iferror" }; blockCommand = k; }
            }
            else if (send[0].ToUpper() == "METHOD" && send.Length >= 3)//function that converts given lower case alphabets into upper case.
            {
                string aa = "a"; int length = send.Length; length = length - 1; int methodCount = 1; aa = send[1]; methodArray[0] = "method"; methodArray[methodCount] = aa; if (send.Length == 3 || send.Length == 4)
                {
                    if (send.Length == 3 && send[2] == "()")
                    { blockCommand = methodArray; }
                    else if (send.Length == 4 && send[2] == "(" && send[3] == ")")
                    { blockCommand = methodArray; }
                    else
                    { string[] k = { "methoderror" }; blockCommand = k; }
                }
                else if (send[2] == "(" && send[length] == ")" && send.Length > 4)
                {
                    for (int li = 3; li < length; li++)
                    {
                        if (li % 2 == 0 && send[li] == ";")
                        { }
                        else if (li % 2 == 0 && send[li] != ";")
                        { string[] k = { "methoderror" }; blockCommand = k; }
                        else
                        { methodCount = methodCount + 1; methodArray[methodCount] = send[li]; blockCommand = methodArray; }
                    }
                }
                else
                { string[] k = { "methoderror" }; blockCommand = k; }
            }
            else
            {
                int length = send.Length; length = length - 1; int countmeth = 1; string aa = send[0]; methodArray[0] = "parameters"; methodArray[countmeth] = aa; if (send.Length >= 2)
                {
                    if (send.Length == 2 || send.Length == 3)
                    {
                        if (send.Length == 2 && send[1] == "()")
                        { blockCommand = methodArray; }
                        else if (send.Length == 3 && send[1] == "(" && send[2] == ")")
                        { blockCommand = methodArray; }
                        else
                        { string[] k = { "methoderror" }; blockCommand = k; }
                    }
                    else if (send[1] == "(" && send[length] == ")")
                    {
                        for (int li = 2; li < length; li++)
                        {
                            if (li % 2 == 1 && send[li] == ";")
                            { }
                            else if (li % 2 == 1 && send[li] != ";")
                            { string[] k = { "paramerror" }; blockCommand = k; }
                            else
                            { countmeth = countmeth + 1; methodArray[countmeth] = send[li]; blockCommand = methodArray; }
                        }
                    }
                    else
                    { string[] k = { "a" }; blockCommand = k; }
                }
                else
                { string[] k = { "a" }; blockCommand = k; }
            }
            blockCommand = blockCommand.Where(x => !string.IsNullOrEmpty(x)).ToArray(); return blockCommand;
        }
        internal string[] getValidate(TextBox runtextbox)
        { throw new NotImplementedException(); }
    }
}
