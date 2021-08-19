using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using FaceboolAuto;

namespace SeleniumConsole
{
    public static class FacebookSurf {

        //simple one...
        public static string LoginToFacebook() {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            //Maximize the browser window  
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);


            //identify the username text box  
            IWebElement ele = driver.FindElement(By.Id("email"));
            //enter the username value  
            ele.SendKeys("zuhra.khalikova");
            Thread.Sleep(2000);
            Console.Write("username value is entered");
            //identify the password text box  
            IWebElement ele1 = driver.FindElement(By.Name("pass"));
            //enter the password value  
            ele1.SendKeys("Kottabola123");

            Console.Write("password is entered");
            //click on the Login button  
            // IWebElement ele2 = driver.FindElement(By.Id("u_0_d_Z8"));
            IWebElement ele2 = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[2]/button"));

            ele2.Click();
            Thread.Sleep(3000);

            return "login button is clicked";

        }
    
    }

	public class Program
    {
        static void Main(string[] args)
        {

            //simple one! ver 1
           // Console.WriteLine(FacebookSurf.LoginToFacebook());


           
            //let's do a bit more advanced one!  ver 2
            var webDriver = LaunchBrowser();
            try
            {
                var facebookAuto = new FacebookAuto(webDriver);
                facebookAuto.Login("zuhra.khalikova", "Kottabola123");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while executing automation");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                webDriver.Quit();
            }
        }

        static IWebDriver LaunchBrowser()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");

            var driver = new ChromeDriver(Environment.CurrentDirectory, options);
            return driver;
        }

    }
}
