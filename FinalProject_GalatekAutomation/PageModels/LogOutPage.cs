using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.PageModels
{
   public class LogOutPage : BasePage
    {
        public LogOutPage(IWebDriver driver) : base(driver)
        {
        }

        const string dezautentificareButtonSelector = "#content > article > div > div > nav > ul > li.woocommerce-MyAccount-navigation-link.woocommerce-MyAccount-navigation-link--customer-logout > a";//css
        const string logOutButtonSelector = "#content > article > div > div > form.login.global-login > div > div > div.form-row.clearfix > button";//css


        public void ClickOnLogOut()
        {
            var logoutElement = driver.FindElement(By.CssSelector(logOutButtonSelector));
            logoutElement.Click();
        }

        public void ClickOnDezautentificare()

        {
            var dezautentificareElement = driver.FindElement(By.CssSelector(dezautentificareButtonSelector));
            dezautentificareElement.Click();
        }

    }


}
