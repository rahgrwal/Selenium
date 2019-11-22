using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTestDemo1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver myD;
            myD = new ChromeDriver("c:\\Selenium");
            myD.Url="https://www.google.com/";
            Thread.Sleep(4000);
            myD.Close();
            Console.WriteLine("Executed Successfully");
        }
    }
}
