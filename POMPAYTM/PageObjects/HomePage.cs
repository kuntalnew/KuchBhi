using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace POMPAYTM.PageObjects
{
    public class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='app']/div/div[3]/div/div[1]/div/a")]
        public IList<IWebElement> paytmServices;

        [FindsBy(How = How.XPath, Using = "//img[@alt='Mobile ']")]
        private IWebElement _mobileRechargeButton;

        public HomePage()
        {
            PageFactory.InitElements(Configuration.DriverInstance.getDriverInstance(), this);
        }

        public MobileRechargePage ClickOnMobileRadioButton()
        {
            _mobileRechargeButton.Click();
            return new MobileRechargePage();
        }


        










    }
}
