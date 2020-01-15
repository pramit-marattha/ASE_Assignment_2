using System;
using PramitASEcomp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
    /// Testing rectangle by giving correct parameter
    /// </summary>
        [TestMethod]
        
        public void RectangleCorrectValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("rectangle 40 20");
            Assert.AreEqual(result[0], "rectangle", result[1], "40", result[2], "20");

        }
        /// <summary>
        /// testing rectangle by giving wrong parameter
        /// </summary>
        [TestMethod]
        public void RectangleWrongValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("rectangle 20 30 40");
            Assert.AreEqual(result[0], "rectangleerror");

        }
        /// <summary>
        /// testing circle by giving correct parameter
        /// </summary>
        [TestMethod]
        public void CircleCorrectValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("circle 50");
            Assert.AreEqual(result[0], "circle", result[1], "50");

        }
        /// <summary>
        /// tetsing circle by giving wrong parameter
        /// </summary>
        [TestMethod]
        public void CircleWrongValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("circle 50 10");
            Assert.AreEqual(result[0], "circleerror");

        }
        /// <summary>
        /// Testing triangle by giving correct parameter
        /// </summary>
        [TestMethod]
        public void TriangleCorrectValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("triangle 30 30 30");
            Assert.AreEqual(result[0], "triangle", result[1], "30", result[2], "30", result[3], "30");

        }
        /// <summary>
        /// testing triangle by giving wrong parameter
        /// </summary>
        [TestMethod]
        public void TriangleWrongValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("triangle 10 10");
            Assert.AreEqual(result[0], "triangleerror");

        }

        /// <summary>
        /// tetsing moveto by giving right parameter
        /// </summary>
        [TestMethod]
        public void MoveToCorrectValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("moveto 70 70");
            Assert.AreEqual(result[0], "moveto", result[1], "70", result[2], "70");
        }

        /// <summary>
        /// testing moveto by giving wrong parameter
        /// </summary>
        [TestMethod]
        public void MoveToWrongValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("moveto 70");
            Assert.AreEqual(result[0], "errormoveto");

        }
        /// <summary>
        /// testing drawto by giving correct parameter
        /// </summary>
        [TestMethod]
        public void DrawToCorrectValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("drawto 80 80");
            Assert.AreEqual(result[0], "drawto", result[1], "80", result[2], "80");

        }
        /// <summary>
        /// tetsing drawto by giving wrong value
        /// </summary>
        [TestMethod]
        public void DrawToWrongValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("drawto 90");
            Assert.AreEqual(result[0], "errordrawto");

        }
       /// <summary>
       /// 
       /// tetsing loop by giving wrong value
       /// </summary>
        [TestMethod]
        public void LoopWrongValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("loop 20 20");
            Assert.AreEqual(result[0], "looperror");

        }

        /// <summary>
        /// tetsing loop by giving right value
        /// </summary>
        [TestMethod]
        public void LoopCorrectValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("loop 20");
            Assert.AreEqual(result[0], "loop");

        }
        /// <summary>
        /// testing if by giving wrong value
        /// </summary>
        [TestMethod]
        public void IfStatementWrongValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("if 40 40");
            Assert.AreEqual(result[0], "iferror");

        }
        /// <summary>
        /// testing if by giving correct value
        /// </summary>
        [TestMethod]
        public void IfStatementCorrectValueCheck()
        {
            var v = new Check();
            string[] result = v.getValidate("if radius = 10");
            Assert.AreEqual(result[0], "ifr");
        }
        
        
        
        
    }
}
