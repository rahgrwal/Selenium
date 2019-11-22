using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{

    [TestClass]
    public class youcandoit
    {

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver myD;
            myD = new ChromeDriver("C:\\Selenium jas\\chromedriver_win32");
            myD.Url = "http://www.youcandealwithit.com/";
            string CalRes = "Calculators & Resources";
            string cal = "Calculators";
            string BudCal = "Budget Calculator";
            IWebElement vBorrow = myD.FindElement(By.XPath("//a[text()='Borrowers']"));
            Actions act = new Actions(myD);
            act.MoveToElement(vBorrow).Build().Perform();
            myD.FindElement(By.LinkText(CalRes)).Click();
            if (myD.Title == CalRes)
            {
                Console.WriteLine(CalRes + " Passed");
            }
            else
            {
                Console.WriteLine(CalRes + " Failed");
            }
            Thread.Sleep(4000);
            myD.FindElement(By.LinkText(cal)).Click();
            if (myD.Title == cal)
            {
                Console.WriteLine(cal + " Passed");
            }
            else
            {
                Console.WriteLine(cal + " Failed");
            }
            Thread.Sleep(4000);
            myD.FindElement(By.LinkText(BudCal)).Click();

            if (myD.Title == BudCal)
            {
                Console.WriteLine(BudCal + " Passed");
            }
            else
            {
                Console.WriteLine(BudCal + " Failed");
            }
            Thread.Sleep(4000);
            myD.FindElement(By.Id("food")).SendKeys("500");
            myD.FindElement(By.Id("clothing")).SendKeys("1000");
            myD.FindElement(By.Id("shelter")).SendKeys("500");
            myD.FindElement(By.Id("monthlyPay")).SendKeys("5000");
            myD.FindElement(By.Id("monthlyOther")).SendKeys("200");
            Thread.Sleep(4000);
            double monthly_budget = double.Parse(myD.FindElement(By.Id("underOverBudget")).GetAttribute("value"));
            Console.WriteLine(monthly_budget.ToString());
            double Monthly_Expense = double.Parse(myD.FindElement(By.Id("totalMonthlyExpenses")).GetAttribute("value"));
            Console.WriteLine(Monthly_Expense.ToString());
            double monthly_pay = double.Parse(myD.FindElement(By.Id("monthlyPay")).GetAttribute("value"));
            Console.WriteLine(monthly_pay.ToString());
            if (Monthly_Expense >= monthly_pay)
            {
                Console.WriteLine("You are WB");
            }
            else
            {
                Console.WriteLine("You are VM");
            }



        }
    }
}
