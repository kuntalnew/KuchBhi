using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMPAYTM.DriverHelper
{
    public class DriverFunctions
    {
        private static IWebDriver driver = Configuration.DriverInstance.getDriverInstance();


        public static string GetBrowserCurrentUrl()
        {
            return driver.Url;
        }

        public static void DriverMaximization()
        {
            driver.Manage().Window.Maximize();
        }

        public static void ImpliciteTimingout()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public static void QuitingDriver()
        {
            driver.Dispose();
        }

        public static void NavigateToLinks(string url)
        {
            driver.Navigate().GoToUrl(url);
        }





    }
}
