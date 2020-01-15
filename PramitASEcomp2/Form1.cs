using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PramitASEcomp2
{
    public partial class Form1 : Form
    {

        int radius = 0;
        int width = 0;
        int height = 0;
        int countmethod = 0;      
        int pointpos1 = 0;
        int pointpos2 = 0;
        int x = -1;
        int y = -1;
        Graphics g;
        Pen paint = new Pen(Color.Black, 2);
        Point paintpoint1 = new Point(0, 0);
        Point paintpoint2 = new Point(0, 0);
        int prampaint = 0;

        string startmethod;
        string[] paramaters = new string[100];

       
        public object Validator
        {
           // get;
           // set;
        }
        /// <summary>
        /// Initializing the form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            g = Artboard.CreateGraphics();

        }

        /// <summary>
        /// About Menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Graphical programming language application \r\n created by Pramit marattha");

        }
        /// <summary>
        /// Picture box to select the color of the brush
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void red_Click(object sender, EventArgs e)
        {
            paint.Color = red.BackColor;
            black.BackColor = red.BackColor;
        }

        private void green_Click(object sender, EventArgs e)
        {
            paint.Color = green.BackColor;
            black.BackColor = green.BackColor;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            paint.Color = blue.BackColor;
            black.BackColor = blue.BackColor;
        }


        /// <summary>
        /// mouse move location 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            paintpoint1 = e.Location;
            if (e.Button == MouseButtons.Left)
                prampaint = 1;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (prampaint == 1)
            {
                paintpoint2 = e.Location;
                g = this.CreateGraphics();
                g.DrawLine(paint, paintpoint1, paintpoint2);
            }
            paintpoint1 = paintpoint2;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            prampaint = 0;
        }

        private void Artboard_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Artboard_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Artboard_MouseUp(object sender, MouseEventArgs e)
        {
            prampaint = 0;
        }
        /// <summary>
        /// Pannel for drawing / painting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            paintpoint1 = e.Location;
            if (e.Button == MouseButtons.Left)
                prampaint = 1;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (prampaint == 1)
            {
                paintpoint2 = e.Location;
                g = this.CreateGraphics();
                g.DrawLine(paint, paintpoint1, paintpoint2);
            }
            paintpoint1 = paintpoint2;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            prampaint = 0;
        }

        private void black_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Single line command to draw shapes
        /// </summary>
        ///     
        public void Runboxmethod()
        {
            String fetchtext = Runtextbox.Text;
            Check v = new Check();
            String[] result = v.getValidate(fetchtext);
            if (result[0] == "moveto")
            {
                int a = Convert.ToInt32(result[1]);
                int b = Convert.ToInt32(result[2]);
                pointpos1 = a;
                pointpos2 = b;
            }
            else if (result[0] == "drawto")
            {
                ShapeFactory s1 = new ShapeFactory();
                ShapeInterface sh = s1.getShape(result[0]);
                sh.drawShape(result, g, pointpos1, pointpos2);
            }
            else if (result[0] == "rectangle")
            {
                ShapeFactory s1 = new ShapeFactory();
                ShapeInterface sh = s1.getShape(result[0]);
                sh.drawShape(result, g, pointpos1, pointpos2);
            }
            else if (result[0] == "circle")
            {
                ShapeFactory s1 = new ShapeFactory();
                ShapeInterface sh = s1.getShape(result[0]);
                sh.drawShape(result, g, pointpos1, pointpos2);

            }
            else if (result[0] == "triangle")
            {
                ShapeFactory s1 = new ShapeFactory();
                ShapeInterface sh = s1.getShape(result[0]);
                sh.drawShape(result, g, pointpos1, pointpos2);
            }
            else if (result[0] == "a")
            {
              MessageBox.Show("Error!!! Please give valid command");

            }

            else
            {
                if (result[0] == "errormoveto")
                { MessageBox.Show("MoveTo command incorrect"); }
                if (result[0] == "errordrawto")
                { MessageBox.Show("DrawTo command incorrect"); }
                if (result[0] == "rectangleerror")
                { MessageBox.Show("please enter a correct rectangle command"); }
                if (result[0] == "circleerror")
                { MessageBox.Show("please enter a correct circle command"); }
                if (result[0] == "triangleerror")
                { MessageBox.Show("please enter a correct triangle command"); }
                if (result[0] == "radiuserror")
                { MessageBox.Show("Please eneter a valid radius command"); }
                if (result[0] == "widtherror")
                { MessageBox.Show("Please eneter a valid width"); }
                if (result[0] == "heighterror")
                { MessageBox.Show("Please enter valid height command"); }
            }

        } /// <summary>
          /// Compile command in loop
          /// </summary>
          /// <param no_of_times_to_loop="loopvalue"></param>
          /// <param current_index_in_array="counter"></param>
          /// <returns></returns>


        public int looper(int loopvalue, int counter)
        {
            int countcheck = 0; int temp = counter + loopvalue; for (int j2 = counter; j2 < temp; j2++)
            {
                int numb3 = 0; int temp2 = counter; String[] result; countcheck = 0;
                do
                {
                    countcheck = countcheck + 1; string fetchtext = string.Format("textbox"); fetchtext = Grouptextcmd.Lines[temp2]; Check v = new Check(); result = v.getValidate(fetchtext); if (result[0] == "moveto")
                    { int a = Convert.ToInt32(result[1]); int b = Convert.ToInt32(result[2]); pointpos1 = a; pointpos2 = b; }
                    else if (result[0] == "drawto")
                    { ShapeFactory s1 = new ShapeFactory(); ShapeInterface sh = s1.getShape(result[0]); sh.drawShape(result, g, pointpos1, pointpos2); }
                    else if (result[0] == "rectangle")
                    { ShapeFactory s1 = new ShapeFactory(); ShapeInterface sh = s1.getShape(result[0]); sh.drawShape(result, g, pointpos1, pointpos2); }
                    else if (result[0] == "rectangle3")
                    { ShapeFactory s1 = new ShapeFactory(); String width2 = Convert.ToString(width); String height2 = Convert.ToString(height); String[] tempresult = { "rectangle", width2, height2 }; ShapeInterface sh = s1.getShape(tempresult[0]); sh.drawShape(tempresult, g, pointpos1, pointpos2); }
                    else if (result[0] == "rectangle4")
                    { ShapeFactory s1 = new ShapeFactory(); String width2 = result[1]; String height2 = Convert.ToString(height); String[] tempresult = { "rectangle", width2, height2 }; ShapeInterface sh = s1.getShape(tempresult[0]); sh.drawShape(tempresult, g, pointpos1, pointpos2); }
                    else if (result[0] == "rectangle2")
                    { ShapeFactory s1 = new ShapeFactory(); String width2 = Convert.ToString(width); String height2 = result[1]; String[] tempresult = { "rectangle", width2, height2 }; ShapeInterface sh = s1.getShape(tempresult[0]); sh.drawShape(tempresult, g, pointpos1, pointpos2); }
                    else if (result[0] == "width")
                    { int a = Convert.ToInt32(result[1]); width = a; }
                    else if (result[0] == "width2")
                    { int a = Convert.ToInt32(result[1]); width = width + a; }
                    else if (result[0] == "height")
                    { int a = Convert.ToInt32(result[1]); height = a; }
                    else if (result[0] == "height2")
                    { int a = Convert.ToInt32(result[1]); height = height + a; }
                    else if (result[0] == "circle")
                    { ShapeFactory s1 = new ShapeFactory(); ShapeInterface sh = s1.getShape(result[0]); sh.drawShape(result, g, pointpos1, pointpos2); }
                    else if (result[0] == "circle2")
                    { ShapeFactory s1 = new ShapeFactory(); radius = radius + radius; String radius2 = Convert.ToString(radius); radius = radius / 2; String[] tempresult = { "circle", radius2 }; ShapeInterface sh = s1.getShape(tempresult[0]); sh.drawShape(tempresult, g, pointpos1, pointpos2); }
                    else if (result[0] == "radius")
                    { int a = Convert.ToInt32(result[1]); radius = a; }
                    else if (result[0] == "radius2")
                    { int a = Convert.ToInt32(result[1]); radius = radius + a; }
                    else if (result[0] == "triangle")
                    { ShapeFactory s1 = new ShapeFactory(); ShapeInterface sh = s1.getShape(result[0]); sh.drawShape(result, g, pointpos1, pointpos2); }
                    else if (result[0] == "ifw")
                    { int numb2 = Convert.ToInt32(result[3]); numb3 = ifmethodw(width, result[2], numb2, temp2 + 1); temp2 = numb3; }
                    else if (result[0] == "ifh")
                    { int numb2 = Convert.ToInt32(result[3]); numb3 = ifmethodw(height, result[2], numb2, temp2 + 1); temp2 = numb3; }
                    else if (result[0] == "ifr")
                    { int numb2 = Convert.ToInt32(result[3]); numb3 = ifmethodw(radius, result[2], numb2, temp2 + 1); temp2 = numb3; }
                    else if (result[0] == "a")
                    { MessageBox.Show("loop command"); }

                    else
                    {
                        int j = j2 + 1; if (result[0] == "errormoveto")
                        { MessageBox.Show("Moveto eror in line" + " " + j + " " + "::"); }
                        if (result[0] == "errordrawto")
                        { MessageBox.Show("Draw to error in line" + " " + j + " " + ":::"); }
                        if (result[0] == "rectangleerror")
                        { MessageBox.Show("rectangle error in line" + " " + j + " " + ":::"); }
                        if (result[0] == "circleerror")
                        { MessageBox.Show("circle error in line " + " " + j + " " + ":::"); }
                        if (result[0] == "triangleerror")
                        { MessageBox.Show("triangle error in line " + " " + j + " " + ":::"); }
                        if (result[0] == "radiuserror")
                        { MessageBox.Show("Enter valid radius "); }
                        if (result[0] == "widtherror")
                        { MessageBox.Show("Enter a valid width"); }
                        if (result[0] == "heighterror")
                        { MessageBox.Show("Enter a valid height"); }


                        if (result[0] == "looperror")
                        {
                            if (result.Length > 1)
                            {
                                string[] result2;
                                do
                                {
                                    string fetchtext5 = string.Format("textbox");
                                    fetchtext5 = Grouptextcmd.Lines[temp2];
                                    Check v2 = new Check();
                                    result2 = v2.getValidate(fetchtext5);
                                    temp2 = temp2 + 1;
                                } while (result2[0] != "end");
                                temp2 = temp2 - 1;
                            }
                            MessageBox.Show("Looping error");


                        }
                        if (result[0] == "iferror")
                        {
                            if (result.Length > 1)
                            {
                                string[] result2;
                                do
                                {
                                    string fetchtext5 = string.Format("textbox");
                                    fetchtext5 = Grouptextcmd.Lines[temp2];
                                    Check v2 = new Check();
                                    result2 = v2.getValidate(fetchtext5);
                                    temp2 = temp2 + 1;
                                } while (result2[0] != "endif");
                                temp2 = temp2 - 1;
                            }
                            MessageBox.Show("enter a valid if statement");


                        }
                        if (result[0] == "methoderror")
                        {
                            if (result.Length > 1)
                            {
                                string[] result2;
                                do
                                {
                                    string fetchtext6 = string.Format("textbox");
                                    fetchtext6 = Grouptextcmd.Lines[temp2];
                                    Check v2 = new Check();
                                    result2 = v2.getValidate(fetchtext6);
                                    temp2 = temp2 + 1;
                                } while (result2[0] != "endmethod");
                                temp2 = temp2 - 1;
                            }
                           MessageBox.Show("Enter a valid method ");

                        }



                    }
                    temp2 = temp2 + 1;

                } while (result[0] != "end");

            }
            return countcheck;
        } /// <summary>
          /// To check if paramater
          /// </summary>
          /// <param variable_to_compare ="variable"></param>
          /// <param symbol="symb"></param>
          /// <param number_to_compare="numb"></param>
          /// <param index_in_array="lineno"></param>
          /// <returns></returns>

        public int ifmethodw(int variable, string symb, int numb, int lineno)
        {
            int counter = lineno;
            if (symb == "=")
            {
                if (variable == numb)
                {
                    counter = ifmethod(lineno);


                }
                else
                {
                    string[] result2;
                    do
                    {
                        string fetchtext = string.Format("textbox");
                        fetchtext = Grouptextcmd.Lines[counter];
                        Check v = new Check();
                        result2 = v.getValidate(fetchtext);
                        counter = counter + 1;
                    } while (result2[0] != "endif");
                    counter = counter - 1;

                }
            }
            else if (symb == ">")
            {
                if (variable > numb)
                {
                    counter = ifmethod(lineno);

                }
                else
                {
                    string[] result2;
                    do
                    {
                        string fetchtext = string.Format("textbox");
                        fetchtext = Grouptextcmd.Lines[counter];
                        Check v = new Check();
                        result2 = v.getValidate(fetchtext);
                        counter = counter + 1;
                    } while (result2[0] != "endif");
                    counter = counter - 1;


                }
            }
            else if (symb == "<")
            {
                if (variable < numb)
                {
                    counter = ifmethod(lineno);

                }
                else
                {
                    string[] result2;
                    do
                    {
                        string fetchtext = string.Format("textbox");
                        fetchtext = Grouptextcmd.Lines[counter];
                        Check v = new Check();
                        result2 = v.getValidate(fetchtext);
                        counter = counter + 1;
                    } while (result2[0] != "endif");
                    counter = counter - 1;


                }
            }
            else
            {



            }
            return counter;
        } /// <summary>
          /// to run command inside if
          /// </summary>
          /// <param index_in_array="lineno"></param>
          /// <returns></returns>

        public int ifmethod(int lineno)
        {
            String[] result;
            int counterr = lineno;
            do
            {
                string fetchtext = string.Format("textbox");
                fetchtext = Grouptextcmd.Lines[counterr];
                Check v = new Check();
                result = v.getValidate(fetchtext);
                if (result[0] == "moveto")
                {
                    int a = Convert.ToInt32(result[1]);
                    int b = Convert.ToInt32(result[2]);
                    pointpos1 = a;
                    pointpos2 = b;
                }
                else if (result[0] == "drawto")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);
                }
                else if (result[0] == "rectangle")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);
                }
                else if (result[0] == "rectangle3")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    String width2 = Convert.ToString(width);
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };

                    ShapeInterface sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pointpos1, pointpos2);

                }
                else if (result[0] == "rectangle4")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    String width2 = result[1];
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };

                    ShapeInterface sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pointpos1, pointpos2);

                }
                else if (result[0] == "rectangle2")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    String width2 = Convert.ToString(width);
                    String height2 = result[1];
                    String[] tempresult = { "rectangle", width2, height2 };

                    ShapeInterface sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pointpos1, pointpos2);

                }
                else if (result[0] == "width")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = a;

                }
                else if (result[0] == "width2")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = width + a;

                }
                else if (result[0] == "height")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = a;
                }
                else if (result[0] == "height2")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = height + a;

                }
                else if (result[0] == "circle")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);

                }
                else if (result[0] == "circle2")
                {


                    ShapeFactory s1 = new ShapeFactory();
                    radius = radius + radius;
                    String radius2 = Convert.ToString(radius);
                    String[] tempresult = { "circle", radius2 };


                    radius = radius / 2;
                    ShapeInterface sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pointpos1, pointpos2);


                }
                else if (result[0] == "radius")
                {
                    int a2 = Convert.ToInt32(result[1]);
                    radius = a2;

                }
                else if (result[0] == "radius2")
                {
                    int a2 = Convert.ToInt32(result[1]);
                    radius = radius + a2;

                }
                else if (result[0] == "triangle")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);
                }
                else if (result[0] == "loop")
                {
                    int a = Convert.ToInt32(result[1]);
                    int counter2 = looper(a, counterr + 1);

                    counterr = counterr + counter2;

                }
                else if (result[0] == "a")
                {
                    MessageBox.Show("loop Check command");

                }

                else
                {
                    int j = counterr + 1; if (result[0] == "errormoveto")
                    { MessageBox.Show("Moveto eror in line" + " " + j + " " + "::"); }
                    if (result[0] == "errordrawto")
                    { MessageBox.Show("drawto eror in line" + " " + j + " " + "::"); }
                    if (result[0] == "rectangleerror")
                    { MessageBox.Show("rectangle eror in line" + " " + j + " " + "::"); }
                    if (result[0] == "circleerror")
                    { MessageBox.Show("circle eror in line" + " " + j + " " + "::"); }
                    if (result[0] == "triangleerror")
                    { MessageBox.Show("Triangle eror in line" + " " + j + " " + "::"); }
                    if (result[0] == "radiuserror")
                    { MessageBox.Show("Enter valid radius "); }
                    if (result[0] == "widtherror")
                    { MessageBox.Show("Enter valid width"); }
                    if (result[0] == "heighterror")
                    { MessageBox.Show("Enter valid height"); }


                    if (result[0] == "looperror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[counterr];
                                Check v2 = new Check();
                                result2 = v2.getValidate(fetchtext5);
                                counterr = counterr + 1;
                            } while (result2[0] != "end");
                            counterr = counterr - 1;
                        }
                        MessageBox.Show("Looping error");


                    }
                    if (result[0] == "iferror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[counterr];
                                Check v2 = new Check();
                                result2 = v2.getValidate(fetchtext5);
                                counterr = counterr + 1;
                            } while (result2[0] != "endif");
                            counterr = counterr - 1;
                        }
                        MessageBox.Show("IF variable syntax number");


                    }
                    if (result[0] == "methoderror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext6 = string.Format("textbox");
                                fetchtext6 = Grouptextcmd.Lines[counterr];
                                Check valid = new Check();
                                result2 = valid.getValidate(fetchtext6);
                                counterr = counterr + 1;
                            } while (result2[0] != "endmethod");
                            counterr = counterr - 1;
                        }
                        System.Windows.Forms.MessageBox.Show("Error!! while defining a");


                    }
                }
                counterr = counterr + 1;
            } while (result[0].ToUpper() != "ENDIF");
            return counterr - 1;
        } /// <summary>
          /// method creation
          /// </summary>
          /// <param index_in_array="lineno"></param>
        public void methodmethod(int lineno)
        {
            String[] result;
            int counterr = lineno;
            do
            {
                string fetchtext = string.Format("textbox");
                fetchtext = Grouptextcmd.Lines[counterr];
                Check v = new Check();
                result = v.getValidate(fetchtext);
                if (result[0] == "moveto")
                {
                    int a = Convert.ToInt32(result[1]);
                    int b = Convert.ToInt32(result[2]);
                    pointpos1 = a;
                    pointpos2 = b;
                }
                else if (result[0] == "drawto")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);
                }
                else if (result[0] == "rectangle")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);
                }
                else if (result[0] == "rectangle3")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    String width2 = Convert.ToString(width);
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };


                    ShapeInterface sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pointpos1, pointpos2);

                }
                else if (result[0] == "rectangle4")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    String width2 = result[1];
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };


                    ShapeInterface sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pointpos1, pointpos2);

                }
                else if (result[0] == "rectangle2")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    String width2 = Convert.ToString(width);
                    String height2 = result[1];
                    String[] tempresult = { "rectangle", width2, height2 };


                    ShapeInterface sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pointpos1, pointpos2);

                }
                else if (result[0] == "width")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = a;

                }
                else if (result[0] == "width2")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = width + a;

                }
                else if (result[0] == "height")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = a;
                }
                else if (result[0] == "height2")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = height + a;

                }
                else if (result[0] == "circle")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);

                }
                else if (result[0] == "circle2")
                {


                    ShapeFactory s1 = new ShapeFactory();
                    radius = radius + radius;
                    String radius2 = Convert.ToString(radius);
                    String[] tempresult = { "circle", radius2 };


                    radius = radius / 2;
                    ShapeInterface sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pointpos1, pointpos2);


                }
                else if (result[0] == "radius")
                {
                    int a2 = Convert.ToInt32(result[1]);
                    radius = a2;

                }
                else if (result[0] == "radius2")
                {
                    int a2 = Convert.ToInt32(result[1]);
                    radius = radius + a2;

                }
                else if (result[0] == "triangle")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);
                }
                else if (result[0] == "loop")
                {
                    int a = Convert.ToInt32(result[1]);
                    int counter2 = looper(a, counterr + 1);

                    counterr = counterr + counter2;

                }
                else if (result[0] == "ifw")
                {

                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(width, result[2], numb2, counterr + 1);
                    counterr = counter2;
                }
                else if (result[0] == "ifh")
                {
                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(height, result[2], numb2, counterr + 1);
                    counterr = counter2;
                }
                else if (result[0] == "ifr")
                {
                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(radius, result[2], numb2, counterr + 1);
                    counterr = counter2;
                }
                else if (result[0] == "a")
                {
                  MessageBox.Show("Method processed");

                }


                else
                {
                    int j = counterr + 1; if (result[0] == "errormoveto")
                    { MessageBox.Show("Moveto error in line" + " " + j + " " + "::"); }
                    if (result[0] == "errordrawto")
                    { MessageBox.Show("Drawto error in line" + " " + j + " " + "::"); }
                    if (result[0] == "rectangleerror")
                    { MessageBox.Show("rectangle error in line" + " " + j + " " + "::"); }
                    if (result[0] == "circleerror")
                    { MessageBox.Show("Circle error in line" + " " + j + " " + "::"); }
                    if (result[0] == "triangleerror")
                    { MessageBox.Show("triangle error in line" + " " + j + " " + "::"); }
                    if (result[0] == "radiuserror")
                    { MessageBox.Show("Enter valid radius "); }
                    if (result[0] == "widtherror")
                    { MessageBox.Show("Enter valid width"); }
                    if (result[0] == "heighterror")
                    { MessageBox.Show("Enter valid height"); }
                    if (result[0] == "looperror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[counterr];
                                Check v2 = new Check();
                                result2 = v2.getValidate(fetchtext5);
                                counterr = counterr + 1;
                            } while (result2[0] != "end");
                            counterr = counterr - 1;

                        }
                        MessageBox.Show("Looping Error ");

                    }
                    if (result[0] == "iferror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[counterr];
                                Check v2 = new Check();
                                result2 = v2.getValidate(fetchtext5);
                                counterr = counterr + 1;
                            } while (result2[0] != "endif");
                            counterr = counterr - 1;
                        }
                        MessageBox.Show("IF variable syntax number");


                    }
                    if (result[0] == "methoderror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext6 = string.Format("textbox");
                                fetchtext6 = Grouptextcmd.Lines[counterr];
                                Check v2 = new Check();
                                result2 = v2.getValidate(fetchtext6);
                                counterr = counterr + 1;
                            } while (result2[0] != "endmethod");
                            counterr = counterr - 1;

                        }
                       MessageBox.Show("Invalid!! Method");


                    }

                }
                counterr = counterr + 1;
            } while (result[0].ToUpper() != "ENDMETHOD");
        }



        private void Runtextbox_TextChanged(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// Run command in group
        /// </summary>

        public void GrouptextboxMethod()
        {
            int counttext = Grouptextcmd.Lines.Length;
            for (int i = 0; i < counttext; i++)
            {
                string fetchtext = string.Format("textbox");
                fetchtext = Grouptextcmd.Lines[i];




                Check v = new Check();
                String[] result = v.getValidate(fetchtext);
                if (result[0] == "moveto")
                {
                    int a = Convert.ToInt32(result[1]);
                    int b = Convert.ToInt32(result[2]);
                    pointpos1 = a;
                    pointpos2 = b;
                }
                else if (result[0] == "drawto")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);
                }
                else if (result[0] == "rectangle")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);
                }
                else if (result[0] == "rectangle3")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    String width2 = Convert.ToString(width);
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };

                    ShapeInterface sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pointpos1, pointpos2);

                }
                else if (result[0] == "rectangle4")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    String width2 = result[1];
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };


                    ShapeInterface sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pointpos1, pointpos2);

                }
                else if (result[0] == "rectangle2")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    String width2 = Convert.ToString(width);
                    String height2 = result[1];
                    String[] tempresult = { "rectangle", width2, height2 };

                    ShapeInterface sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pointpos1, pointpos2);

                }
                else if (result[0] == "width")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = a;

                }
                else if (result[0] == "width2")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = width + a;

                }
                else if (result[0] == "height")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = a;
                }
                else if (result[0] == "height2")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = height + a;

                }
                else if (result[0] == "circle")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);

                }
                else if (result[0] == "circle2")
                {


                    ShapeFactory s1 = new ShapeFactory();
                    radius = radius + radius;
                    String radius2 = Convert.ToString(radius);
                    String[] tempresult = { "circle", radius2 };

                    radius = radius / 2;
                    ShapeInterface sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pointpos1, pointpos2);

                }
                else if (result[0] == "radius")
                {
                    int a = Convert.ToInt32(result[1]);
                    radius = a;

                }
                else if (result[0] == "radius2")
                {
                    int a = Convert.ToInt32(result[1]);
                    radius = radius + a;

                }
                else if (result[0] == "triangle")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    ShapeInterface sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pointpos1, pointpos2);
                }
                else if (result[0] == "loop")
                {
                    int a = Convert.ToInt32(result[1]);
                    int counter2 = looper(a, i + 1);

                    i = i + counter2;

                }
                else if (result[0] == "ifw")
                {

                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(width, result[2], numb2, i + 1);
                    i = counter2;
                }
                else if (result[0] == "ifh")
                {
                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(height, result[2], numb2, i + 1);
                    i = counter2;
                }
                else if (result[0] == "ifr")
                {
                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(radius, result[2], numb2, i + 1);
                    i = counter2;
                }
                else if (result[0] == "method")
                {
                    int lengthres = result.Length;
                    countmethod = i;

                    startmethod = result[1];
                    int countpara = 0;

                    //string tempres;


                    for (int lii = 2; lii < lengthres; lii++)
                    {
                        paramaters[countpara] = result[lii];
                        countpara = countpara + 1;

                    }

                    string[] result2;
                    paramaters = paramaters.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                    do
                    {
                        string fetchtext6 = string.Format("textbox");
                        fetchtext6 = Grouptextcmd.Lines[i];
                        Check v2 = new Check();
                        result2 = v2.getValidate(fetchtext6);
                        i = i + 1;
                    } while (result2[0] != "endmethod");


                    i = i - 1;
                }
                else if (result[0] == "parameters")
                {

                    if (result[1] == startmethod && paramaters.Length == result.Length - 2)
                    {
                        int lengthres = result.Length;
                        int countmethod2 = countmethod + 1;

                        for (int lii = 2; lii < lengthres; lii++)
                        {

                            if (result[lii].ToUpper() == "RADIUS")
                            {
                                result[lii] = Convert.ToString(radius);


                            }
                            else if (result[lii].ToUpper() == "WIDTH")
                            {
                                result[lii] = Convert.ToString(width);
                            }
                            else if (result[lii].ToUpper() == "HEIGHT")
                            {
                                result[lii] = Convert.ToString(height);
                            }
                            else
                            {

                            }

                        }

                        methodmethod(countmethod2);

                    }
                    else
                    {
                       MessageBox.Show("Method doesnot exist");

                    }

                }
                else if (result[0] == "a")
                {
                  MessageBox.Show("Method declared");

                }

                else
                {
                    int j = i + 1; if (result[0] == "errormoveto")
                    { MessageBox.Show("Moveto error in line" + " " + j + " " + "::"); }
                    if (result[0] == "errordrawto")
                    { MessageBox.Show("drawto error in line" + " " + j + " " + "::"); }
                    if (result[0] == "rectangleerror")
                    { MessageBox.Show("rectangle error in line" + " " + j + " " + "::"); }
                    if (result[0] == "circleerror")
                    { MessageBox.Show("circle error in line" + " " + j + " " + "::"); }
                    if (result[0] == "triangleerror")
                    { MessageBox.Show("traingle error in line" + " " + j + " " + "::"); }
                    if (result[0] == "radiuserror")
                    { MessageBox.Show("Enter valid radius"); }
                    if (result[0] == "widtherror")
                    { MessageBox.Show("Enter Valid Width"); }
                    if (result[0] == "heighterror")
                    { MessageBox.Show("Enter Valid height"); }



                    if (result[0] == "looperror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[i];
                                Check v2 = new Check();
                                result2 = v2.getValidate(fetchtext5);
                                i = i + 1;
                            } while (result2[0] != "end");

                            i = i - 1;
                        }
                        MessageBox.Show("Looping error");
                    }
                    if (result[0] == "iferror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[i];
                                Check v2 = new Check();
                                result2 = v2.getValidate(fetchtext5);
                                i = i + 1;
                            } while (result2[0] != "endif");
                            i = i - 1;
                        }
                        MessageBox.Show("IF variable syntax number");


                    }
                    if (result[0] == "methoderror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext6 = string.Format("textbox");
                                fetchtext6 = Grouptextcmd.Lines[i];
                                Check v2 = new Check();
                                result2 = v2.getValidate(fetchtext6);
                                i = i + 1;
                            } while (result2[0] != "endmethod");
                            i = i - 1;
                        }
                        MessageBox.Show("Method declared");

                    }
                }
            }
        }
        private void Cleargrouptext_Click(object sender, EventArgs e)
        {
            Artboard.Refresh();
            Refresh();
            MessageBox.Show("Everything is Cleared");

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Runboxmethod();
        }
        /// <summary>
        /// Saving the Command in text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveDial = new SaveFileDialog();
            saveDial.Title = "Pramit";
            saveDial.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";
            if (saveDial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter saveStream = new StreamWriter(File.Create(saveDial.FileName));
                saveStream.Write(Grouptextcmd.Text);
                saveStream.Dispose();
            }
        }
        /// <summary>
        /// Loading the file into the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDial = new OpenFileDialog();
            openDial.Title = "Pramit";
            openDial.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";
            if (openDial.ShowDialog() == DialogResult.OK)
            {
                StreamReader openStream = new StreamReader(File.OpenRead(openDial.FileName));
                Grouptextcmd.Text = openStream.ReadToEnd();
                openStream.Dispose();
            }
        }
        /// <summary>
        /// exit menu item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Reset button to reset the position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            pointpos1 = 0;
            pointpos2 = 0;
            MessageBox.Show("Everything is reset");
        }

        private void Artboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Grouptextcmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grouptextrunbutton_Click(object sender, EventArgs e)
        {
            GrouptextboxMethod();
        }
        /// <summary>
        /// Save button to save the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDial = new SaveFileDialog();
            saveDial.Title = "Pramit";
            saveDial.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";
            if (saveDial.ShowDialog() == DialogResult.OK)
            {
                StreamWriter saveStream = new StreamWriter(File.Create(saveDial.FileName));
                saveStream.Write(Grouptextcmd.Text);

                saveStream.Dispose();
            }
        }
        private void variableListToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void variableCommandToolStripMenuItem_Click(object sender, EventArgs e) { }

        /// <summary>
        /// making a paint in artboard 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Artboard_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            x = p.X;
            y = p.Y;
            panel2.Invalidate();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// clearing group command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Grouptextcmd.Text = "";
            MessageBox.Show("Code is cleared");

        }
        /// <summary>
        /// exit menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Runtextbox.Text = "";
        }
        /// <summary>
        /// moving shapes by clicking the shapes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Graphics g;
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black);
            if (listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(Color.Red);
                g.DrawEllipse(p, x - 20, y - 20, 40, 40);
                g.FillEllipse(sb, x - 20, y - 20, 40, 40);
            }
            if (listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(Color.Green);
                g.DrawRectangle(p, x - 20, y - 20, 40, 20);
                g.FillRectangle(sb, x - 20, y - 20, 40, 20);

            }
            if (listBox1.SelectedIndex == 2)
            {
                SolidBrush sb = new SolidBrush(Color.Green);
                g.DrawRectangle(p, x - 20, y - 20, 40, 40);
                g.FillRectangle(sb, x - 20, y - 20, 40, 40);

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Paint += new PaintEventHandler(panel2_Paint);
            panel2.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// open button to load the file in application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDial = new OpenFileDialog();
            openDial.Title = "Pramit";
            openDial.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";

            if (openDial.ShowDialog() == DialogResult.OK)
            {
                StreamReader openStream = new StreamReader(File.OpenRead(openDial.FileName));
                Grouptextcmd.Text = openStream.ReadToEnd();
                openStream.Dispose();
            }
        }

      
    }
}
