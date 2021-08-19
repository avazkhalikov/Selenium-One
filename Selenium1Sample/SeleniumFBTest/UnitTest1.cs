using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumFBTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          //  var webDriver = LaunchBrowser();
            try
            {
              //  var facebookAuto = new FacebookAuto(webDriver);
           //     facebookAuto.Login("zuhra.khalikova", "Kottabola123");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while executing automation");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
             //  webDriver.Quit();
            }
        }

        //static IWebDriver LaunchBrowser()
        //{
        //    var options = new ChromeOptions();
        //    options.AddArgument("--start-maximized");
        //    options.AddArgument("--disable-notifications");

        //    var driver = new ChromeDriver(Environment.CurrentDirectory, options);
        //    return driver;
        //}
    }
}
