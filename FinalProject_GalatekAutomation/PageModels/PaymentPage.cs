using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.PageModels
{
    public class PaymentPage : BasePage
    {
        const string descriereaComenziiLabelSelector = "description";//id
        const string numarDeCardLabelSelector = "#formPayment > table > tbody > tr > td:nth-child(1) > div > div:nth-child(1) > div";//css
        const string numarDeCardInputSelector = "#pan_visible";//css
        const string dataDeExpirareLabelSelector = "#formPayment > table > tbody > tr > td:nth-child(1) > div > div:nth-child(3) > span";//css
        const string lunaDeExpirareSelector = "month";//id
        const string selecteazaLunaDeExpirareMartieSelector = "#month > option:nth-child(4)";//css;
        const string anulDeExpirareSelector = "year";//id
        const string selecteazaAnulDeExpirareSelector = "#year > option:nth-child(4)";//css
        const string numePeCardLabelSelector = "#formPayment > table > tbody > tr > td:nth-child(1) > div > div:nth-child(5) > span";//css
        const string numeInputSelector = "iTEXT";//id
        const string plataButtonSelector = "buttonPayment";//id

        
        public PaymentPage(IWebDriver driver) : base(driver)
        {
        }

        public Boolean CheckIfIsPaymentPage(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.CssSelector(descriereaComenziiLabelSelector)).Text.ToLower());
        }

        public void DetaliiPayment(string numarcard,string numecard)
        {

            var numarDeCardInput = driver.FindElement(By.CssSelector(numarDeCardInputSelector));
            numarDeCardInput.Clear();
            numarDeCardInput.SendKeys(numarcard);

            var numeCardInput = driver.FindElement(By.Id(numeInputSelector));
            numeCardInput.Clear();
            numeCardInput.SendKeys(numecard);

            var selectLunaExpirare = driver.FindElement(By.Id(lunaDeExpirareSelector));
            selectLunaExpirare.Click();
            var selectLunaDeExpirareMartie = driver.FindElement(By.CssSelector(selecteazaLunaDeExpirareMartieSelector));
            selectLunaDeExpirareMartie.Click();

            var selectAnulDeExpirare = driver.FindElement(By.Id(anulDeExpirareSelector));
            selectAnulDeExpirare.Click();
            var selecteazaAnulDeExpirareCorect = driver.FindElement(By.Id(selecteazaAnulDeExpirareSelector));
            selecteazaAnulDeExpirareCorect.Click();

            var clickOnPlataButton = driver.FindElement(By.Id(plataButtonSelector));
            clickOnPlataButton.Click();


        }
    }
}
