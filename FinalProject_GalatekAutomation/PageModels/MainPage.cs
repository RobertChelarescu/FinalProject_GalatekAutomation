using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.PageModels
{
    class MainPage : BasePage
    {
        const string acceptCookiesSelector = "ct-ultimate-gdpr-cookie-accept"; // id
        const string loginButtonSelector = "#header > div.header-main.header-has-center > div > div.header-col.header-right > a.my-account > i"; // css
        const string motofierastraieButtonSelector = "#nav-menu-item-34908 > a";//css

        public MainPage(IWebDriver driver) : base(driver)
        {

        }

        public void AcceptCookie()
        {
            driver.FindElement(By.Id(acceptCookiesSelector)).Click();
        }

        public void MoveToLoginPage()
        {
            driver.FindElement(By.CssSelector(loginButtonSelector)).Click();
          
        }
        public void ClickToMotofierastraie()
        {
            driver.FindElement(By.CssSelector(motofierastraieButtonSelector)).Click();
        }

    }
}
