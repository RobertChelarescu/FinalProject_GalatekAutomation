using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.PageModels
{
    public class LoginPage : BasePage
    {

        const string numeUtilizatorSelector = "username"; // id
        const string parolaSelector = "password"; // id
        const string tineMaMinteSelector = "#customer_login > div.u-column1.col-1 > form > div > div > label"; //css
        const string forgotPasswordSelector = "#customer_login > div.u-column1.col-1 > form > div > a"; // css
        const string autentificareSelector = "#customer_login > div.u-column1.col-1 > form > p.form-row.mb-3.mb-lg-0.pb-1.pb-lg-0 > button"; // css
        const string autentificareLabelSelector = "#customer_login > div.u-column1.col-1 > form > h3"; // css
        const string errorMesageSelector = "#content > article > div > div > div > ul > li";//css

        public LoginPage(IWebDriver driver) : base(driver)
        {

        }


        public string CheckPage()
        {
            var loginText = driver.FindElement(By.CssSelector(autentificareLabelSelector));
            return loginText.Text;
        }

        public Dictionary<string, string> Autentificare(string nume, string parola)
        {
            var numeInput = driver.FindElement(By.Id(numeUtilizatorSelector));
            numeInput.Clear();
            numeInput.SendKeys(nume);

            var parolaInput = driver.FindElement(By.Id(parolaSelector));
            parolaInput.Clear();
            parolaInput.SendKeys(parola);

            var tineMinte = driver.FindElement(By.CssSelector(tineMaMinteSelector));
            tineMinte.Click();

            var autentificareButton = driver.FindElement(By.CssSelector(autentificareSelector));
            autentificareButton.Click();

            return new Dictionary<string, string>() { { "credentialsError",CredentialsErrorMsg() } };
        }
        public string CredentialsErrorMsg()
        {
            var credentialsError = driver.FindElement(By.CssSelector(errorMesageSelector));
            return credentialsError.Text;
        }


    }
}
