using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.PageModels
{
    public class RegistrationPage : BasePage
    {
        const string inregistrareLabelSelector = "#customer_login > div.u-column2.col-2 > form > h3";//css
        const string emailInputSelector = "username"; // id
        const string parolaInputSelector = "password";//id
        const string inregistrareSelector = "#customer_login > div.u-column2.col-2 > form > p.woocommerce-form-row.form-row.mb-0 > button";//css
       

        public RegistrationPage(IWebDriver driver) : base(driver)
        {

        }

        public Boolean VerificareInregistrarePage(string label)
        {
           return String.Equals(label.ToLower(), driver.FindElement(By.CssSelector(inregistrareLabelSelector)).Text.ToLower());
        }

        public void Inregistrare( string email,string parola)

        {
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);

            var parolaInput = driver.FindElement(By.Id(parolaInputSelector));
            parolaInput.Clear();
            parolaInput.SendKeys(parola);

           var inregistrareButton = driver.FindElement(By.CssSelector(inregistrareSelector));
            inregistrareButton.Click();
        }
        public void MoveToLoginPage()
        {
            driver.FindElement(By.CssSelector("#header > div.header-main.header-has-center > div > div.header-col.header-right > a.my-account > i")).Click();

        }

    }
}
