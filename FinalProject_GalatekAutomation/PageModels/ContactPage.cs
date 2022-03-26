using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.PageModels
{
    class ContactPage : BasePage
    {

        const string contactButtonSelector = "#nav-menu-item-2267 > a";//css
        const string contactatiLabelSelector = "#wpcf7-f74-p73-o1 > form > h2 > strong";//css
        const string numeInputSelector = "contact-name";//id
        const string numeLabelSelector = "#wpcf7-f74-p73-o1 > form > div.row > div:nth-child(1) > div > label";//css
        const string adresaEmailInputSelector = "contact-email";//id
        const string adresaEmailLabelSelector="#wpcf7-f74-p73-o1 > form > div.row > div:nth-child(2) > div > label";//css
        const string subiectInputSelector = "contact-subject";//id
        const string subiectLabelSelector = "#wpcf7-f74-p73-o1 > form > div.row > div:nth-child(3) > div > label";//css
        const string mesajInputSelector = "contact-message";//id
        const string mesajLabelSelector = "#wpcf7-f74-p73-o1 > form > div.row > div:nth-child(4) > div > label";//css
        const string trimitetiButtonSelector = "#wpcf7-f74-p73-o1 > form > div.row > div:nth-child(5) > div > input";//css
        public ContactPage(IWebDriver driver) : base(driver)
        {
        }

        public Boolean CheckContactLabel(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.CssSelector(contactatiLabelSelector)).Text.ToLower());
        }

        public void ClickOnContactButton()
        {
            var contactButtonElement = driver.FindElement(By.CssSelector(contactButtonSelector));
            contactButtonElement.Click();
            
        }

        public void Contact(string nume, string email,string subiect,string mesaj)
        {
            var numeInput = driver.FindElement(By.Id(numeInputSelector));
            numeInput.Clear();
            numeInput.SendKeys(nume);

            var emailInput = driver.FindElement(By.Id(adresaEmailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);

            var subiectInput = driver.FindElement(By.Id(subiectInputSelector));
            subiectInput.Clear();
            subiectInput.SendKeys(subiect);

            var mesajInput = driver.FindElement(By.Id(mesajInputSelector));
            mesajInput.Clear();
            mesajInput.SendKeys(mesaj);
        }


    }
}
