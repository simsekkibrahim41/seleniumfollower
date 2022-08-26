using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace seleniumfollower
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Siteye gidildi");

            Thread.Sleep(3000);

            IWebElement userName = driver.FindElement(By.Name("username"));
            IWebElement password = driver.FindElement(By.Name("password"));
            IWebElement loginBtn = driver.FindElement(By.CssSelector(".sqdOP.L3NKy.y3zKF"));
            
            



            userName.SendKeys("ibomois41");
            password.SendKeys("Ibrahim.4125");
            loginBtn.Click();
            Console.WriteLine("Hesap Bilgileri Girildi");
            Thread.Sleep(3000);


            driver.Navigate().GoToUrl("https://www.instagram.com/alisari.41");
            Console.WriteLine("Profile Yönlendirme Yapıldı");
            Thread.Sleep(2500);


            /*IWebElement followerLink =*/ driver.FindElement(By.XPath("//*[@class='_aa_7']/li/div")).Click();
            //followerLink.Click();







        }
    }
}
