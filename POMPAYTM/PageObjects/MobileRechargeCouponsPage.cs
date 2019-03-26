using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMPAYTM.PageObjects
{
    public class MobileRechargeCouponsPage
    {
        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Proceed to pay')]")]
        private IWebElement _proceedToPayButton;

        public string GetElementText()
        {
            return _proceedToPayButton.Text;
        }
            


    }
}
