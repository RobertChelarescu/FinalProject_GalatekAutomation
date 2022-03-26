using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.PageModels
{
    public class ProductsPage : BasePage
    {

        const string motofierastraieSelector= "#nav-menu-item-34908 > a"; //css
        const string motofierastrauSthilSelector = "//*[@id='content']/div[5]/ul/li[1]/div/div[3]/a/h3";//xpath
        const string numeMotofierastrauSelector = "//*[@id='pbt-product-title']/h2";//xpath
        const string pretSelector = "//*[@id='product-28983']/div/section[1]/div/div[2]/div/p/ins/span/bdi";//xpath
        const string monedaSelector = "//*[@id='product-28983']/div/section[1]/div/div[2]/div/p/ins/span/bdi/span";//xpath
        const string disponibilitateProdusSelector = "//*[@id='product-28983']/div/section[1]/div/div[2]/div/div[6]/p/span/span";//xpath
        const string codProdusSelector = "//*[@id='pbt-product-title']/span/span";//xpath


        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }
               
        public void ClickOnMotofierastraie()
        {
            var motofierastraie = driver.FindElement(By.CssSelector(motofierastraieSelector));
            Console.WriteLine(motofierastraie.Text);
            motofierastraie.Click();

        }

        public void ClickOnMotofierastrauSthil()
        {
            var motofierastrauSthil = driver.FindElement(By.XPath(motofierastrauSthilSelector));
            Console.WriteLine(motofierastrauSthil.Text);
            motofierastrauSthil.Click();

        }
        public string MarcaMotofierastrau()
        {
            var motofierastrau = driver.FindElement(By.XPath(numeMotofierastrauSelector));
            return motofierastrau.Text;
        }
        public string VerificarePret()
        {

            var pretElement = driver.FindElement(By.XPath(pretSelector));
            return pretElement.Text;
        }

        public string VerificareMonedaPret()
        {
            var monedaElement = driver.FindElement(By.XPath(monedaSelector));
            return monedaElement.Text;
        }
        public string VerificareDisponibilitateProdus()
        {
            var disponibilitateElement = driver.FindElement(By.XPath(disponibilitateProdusSelector));
            return disponibilitateElement.Text;

        }
        public string VerificareCodProdus()
        {
            var codElement = driver.FindElement(By.XPath(codProdusSelector));
            return codElement.Text;

        }


    }
}
