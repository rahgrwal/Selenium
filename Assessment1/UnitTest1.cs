using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace Assessment1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver myD;
            myD = new ChromeDriver("c:\\Selenium");
            myD.Url = "https://www.google.com/";
            myD.FindElement(By.Name("q")).SendKeys("DXC Technologies");
            Thread.Sleep(5000);
            myD.FindElement(By.ClassName("gNO89b")).Click();
            Thread.Sleep(4000);
            if(myD.Title.ToString()=="DXC Technologies")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.WriteLine(myD.Title.ToString());
            Console.WriteLine(myD.FindElement(By.Id("resultStats")).Text);
            myD.Close();
            

        }
    }
}
