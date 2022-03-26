using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.PageModels
{
    public class AddToCartPage : BasePage
    {
        public AddToCartPage(IWebDriver driver) : base(driver)
        {
        }

        const string adaugaInCosButtonSelector = "//*[@id='product-28983']/div/section[1]/div/div[2]/div/form/button";//xpath
        const string veziCosulButtonSelector = "//*[@id='product-28983']/div/section[1]/div/div[2]/div/form/a";//xpath
        const string totalDePlataSelector = "#panel-cart-total > div > table > tbody > tr.order-total > td > strong > span > bdi";//css
        const string continuaCuFinalizareComenziiButtonSelector = "#panel-cart-total > div > div > a";//css

        public void AdaugaInCosButtonElement()
        {
            var adaugaInCosButtonElement = driver.FindElement(By.XPath(adaugaInCosButtonSelector));
            adaugaInCosButtonElement.Click();
        }

        public void VeziCosul()
        {
            var veziCosulButtonElement = driver.FindElement(By.XPath(veziCosulButtonSelector));
            veziCosulButtonElement.Click();

        }
        public string CheckTotaldePlata()
        {
            var totalDePlataElement = driver.FindElement(By.CssSelector(totalDePlataSelector));
            return totalDePlataElement.Text;
        }


        public void FinalizareaComenzii()
        {
            var continuaCufinalizareComanda = driver.FindElement(By.CssSelector(continuaCuFinalizareComenziiButtonSelector));
            continuaCufinalizareComanda.Click();
        }

    }
}
