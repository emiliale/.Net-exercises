using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ad4;
using static System.Console;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;

namespace TestAd4
{
    [TestClass]
    public class UnitTest1
    {
        private string _consoleOutput;

        [TestInitialize]
        public void Initialize()
        {
            var w = new System.IO.StringWriter();
            SetOut(w);
            Program.Main(new string[0]);
            _consoleOutput = w.GetStringBuilder().ToString().Trim();
        }

        [TestMethod]
        public void TestWitaj2()
        {
            Assert.AreEqual("Hello World!", _consoleOutput);
        }
    }
}

