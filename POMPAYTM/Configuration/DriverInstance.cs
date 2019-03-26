using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMPAYTM.Configuration
{
    public class DriverInstance
    {
        private static IWebDriver driver;
        public static IWebDriver getDriverInstance()
        {
            switch (Configuration.Config.browserName)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;

                case "Firefox":
                    driver = new FirefoxDriver();
                    break;

                case "IE":
                    driver = new InternetExplorerDriver();
                    break;

            }
            driver = new ChromeDriver();
            return driver;


        }
        
    }
}
