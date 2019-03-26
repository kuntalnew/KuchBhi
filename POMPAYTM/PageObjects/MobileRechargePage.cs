using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMPAYTM.PageObjects
{
    public class MobileRechargePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@type='tel']")]
        private IWebElement _mobileNumberTextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div[4]/div[1]/div[1]/div/div[2]/div[2]/ul/li[4]/div[1]/div/input")]
        private IWebElement _amountToRechargeTextBox;

        [FindsBy(How = How.XPath, Using = "//button[text()='Proceed to Recharge']")]
        private IWebElement _proceedToRechargeButton;

        public void EnterValidInfo()
        {
            _mobileNumberTextBox.SendKeys(Configuration.Config.mobileNumber);
            _amountToRechargeTextBox.SendKeys(Configuration.Config.amount);
        }


        public MobileRechargeCouponsPage ClickOnProceedToRechargeButton()
        {
            _proceedToRechargeButton.Click();
            return new MobileRechargeCouponsPage();

        }

    }
}
