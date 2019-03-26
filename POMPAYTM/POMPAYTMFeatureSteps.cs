using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POMPAYTM.PageObjects;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace POMPAYTM
{
    [Binding]
    public class POMPAYTMFeatureSteps
    {

        IList<string> listOfServices = new List<string>();
        IList<string> newListOfServices = new List<string>();

        [BeforeScenario]
        public void TestSetUp()
        {
            DriverHelper.DriverFunctions.DriverMaximization();
            DriverHelper.DriverFunctions.ImpliciteTimingout();
        }

        [AfterScenario]
        public void TesTearDown()
        {
            DriverHelper.DriverFunctions.QuitingDriver();
        }

        [Given]
        public void Given_I_am_on_the_home_page_of_Paytm()
        {
            DriverHelper.DriverFunctions.NavigateToLinks(Configuration.Config.paytmHomepageUrl);
        }
        
        [When]
        public void When_I_click_on_the_radio_button_Mobile()
        {
            HomePage home = new HomePage();
            home.ClickOnMobileRadioButton();
        }
        
        [When]
        public void When_I_select_the_option_Mobile()
        {
            HomePage home = new HomePage();
            home.ClickOnMobileRadioButton();
        }
        
        [When]
        public void When_I_enter_valid_prepaid_mobile_number_and_amount()
        {
            HomePage home = new HomePage();
            MobileRechargePage mrp = home.ClickOnMobileRadioButton();
            mrp.EnterValidInfo();
            
        }
        
        [When]
        public void When_I_click_on_the_button_Proceed_to_recharge()
        {
            HomePage home = new HomePage();
            MobileRechargePage mrp = home.ClickOnMobileRadioButton();
            mrp.ClickOnProceedToRechargeButton();
        }
        
        [Then]
        public void Then_the_number_of_services_can_be_verified()
        {
            HomePage home = new HomePage();

            listOfServices.Add("Mobile");
            listOfServices.Add("Electricity");
            listOfServices.Add("Gold");
            listOfServices.Add("Fees");
            listOfServices.Add("Landline");
            listOfServices.Add("Broadband");
            listOfServices.Add("DTH");
            listOfServices.Add("CableTv");
            listOfServices.Add("Metro");
            listOfServices.Add("Forex");
            listOfServices.Add("Donation");

            IList<IWebElement> PTMServices = home.paytmServices;
            foreach (IWebElement service in PTMServices)
            {

                for (int i = 0; i < listOfServices.Count; i++)
                {
                    if (service.Text.Equals(listOfServices[i]))
                    {
                        Console.WriteLine(service.Text);
                        Console.WriteLine(listOfServices[i]);
                        newListOfServices.Add(service.Text);
                        break;
                    }

                }
            }
            Assert.AreEqual(listOfServices.Count, newListOfServices.Count);
        }
        
        [Then]
        public void Then_the_paytm_website_should_redirect_to_https_paytm_com_recharge()
        {
            Assert.AreEqual(Configuration.Config.paytmMobileRechargeUrl, DriverHelper.DriverFunctions.GetBrowserCurrentUrl());
        }
        
        [Then]
        public void Then_The_button_Proceed_to_Pay_the_amount_is_displayed()
        {
            HomePage home = new HomePage();
            MobileRechargePage mrp = home.ClickOnMobileRadioButton();
            MobileRechargeCouponsPage mrcp=mrp.ClickOnProceedToRechargeButton();
            Assert.AreEqual("Proceed to() pay Rs. " + Configuration.Config.amount, mrcp.GetElementText().Trim('0').Trim('.'));
        }
        
        [Then]
        public void Then_The_paytm_website_should_redirect_tos_https_paytm_com_coupons()
        {
            Assert.AreEqual(Configuration.Config.paytmMobileRechargeCouponUrl, DriverHelper.DriverFunctions.GetBrowserCurrentUrl());
        }
    }
}
