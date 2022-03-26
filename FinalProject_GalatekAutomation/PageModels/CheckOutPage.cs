using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProject_GalatekAutomation.PageModels
{
    public class CheckOutPage : BasePage
    {

        
        const string detaliiFacturareLabelSelector = "#customer_details > div.woocommerce-billing-fields.clearfix > h3";//css
        const string numeLabelSelector = "#billing_last_name_field > label";//css
        const string numeInputSelector = "billing_last_name";//id
        const string prenumeLabelSelector = "#billing_first_name_field > label";//css
        const string prenumeInputSelector = "billing_first_name";//id
        const string adresaEmailLabelSelector = "#billing_email_field > label";//css
        const string adresaEmailInputSelector = "billing_email";//id
        const string telefonLabelSelector = "#billing_phone_field > label";//css
        const string telefonInputSelector = "billing_phone";//id
        const string formaJuridicaLabelSelector = "#billing_type_field > label";//css
        const string judetLabelSelector = "#billing_state_field > label";//css
        const string selecteazaOptiuneJudetSelector = "#select2-billing_state-container > span";//css
        const string numeJudetInputSelector = "body > span > span > span.select2-search.select2-search--dropdown > input";//css
        const string orasLabelSelector = "#billing_city_field > label";//css
        const string selecteazaOptinuneOrasSelector = "#select2-billing_city-container";//css
        const string numeOrasSelector = "body > span > span > span.select2-search.select2-search--dropdown > input";//css
        const string stradaLabelSelector = "#billing_address_1_field > label";//css
        const string stradaInputSelector = "billing_address_1";//id
        const string optionalApartamentInputSelector = "billing_address_2";//id
        const string creazaParolaContLabelSelector = "#account_password_field > label";//css
        const string creazaParolaContInputSelector = "account_password";//id
        const string alegeMetodaDePlataSelector = "/html/body/div[1]/div[4]/div/div/div[1]/div/article/div/div/form[2]/div/div[2]/div/div/div[2]/div/ul/li[2]";//xpath
        const string termeniSiconditiiLabelSelector = "#payment > div.form-row.place-order > div > p > label > span.woocommerce-terms-and-conditions-checkbox-text";//css
        const string termeniSiconditiiSelector = "#payment > div.form-row.place-order > div > p > label > span.woocommerce-terms-and-conditions-checkbox-text";//css
        const string plaseazaComandaButtonSelector = "#place_order";//css

        public CheckOutPage(IWebDriver driver) : base(driver)
        {
        }

        public Boolean CheckIfCheckOut(string label)
        {
            return String.Equals(label.ToLower(), driver.FindElement(By.CssSelector(detaliiFacturareLabelSelector)).Text.ToLower());
        }

       
        public void DetaliiFacturare(string nume,string prenume,string email,string telefon,string numejudet,string numeoras,string strada,string apartament,string parola)
        {
            var numeInput = driver.FindElement(By.Id(numeInputSelector));
            numeInput.Clear();
            numeInput.SendKeys(nume);

            var prenumeInput = driver.FindElement(By.Id(prenumeInputSelector));
            prenumeInput.Clear();
            prenumeInput.SendKeys(prenume);

            var emailInput = driver.FindElement(By.Id(adresaEmailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);

            var telefonInput = driver.FindElement(By.Id(telefonInputSelector));
            telefonInput.Clear();
            telefonInput.SendKeys(telefon);

            var selecteazaJudet = driver.FindElement(By.CssSelector(selecteazaOptiuneJudetSelector));
            selecteazaJudet.Click();
            var NumeJudet = driver.FindElement(By.CssSelector(numeJudetInputSelector));
            NumeJudet.Clear();
            NumeJudet.SendKeys(numejudet);
            NumeJudet.SendKeys(Keys.Enter);
           
                           
            var selecteazaOras = driver.FindElement(By.CssSelector(selecteazaOptinuneOrasSelector));
            selecteazaOras.Click();
            var NumeOras = driver.FindElement(By.CssSelector(numeOrasSelector));
            NumeOras.Clear();
            NumeOras.SendKeys(numeoras);
            NumeOras.SendKeys(Keys.Enter);
          
            var stradaInput = driver.FindElement(By.Id(stradaInputSelector));
            stradaInput.Clear();
            stradaInput.SendKeys(strada);

            var apartamentInput = driver.FindElement(By.Id(optionalApartamentInputSelector));
            apartamentInput.Clear();
            apartamentInput.SendKeys(apartament);

            var parolaInput = driver.FindElement(By.Id(creazaParolaContInputSelector));
            parolaInput.Clear();
            parolaInput.SendKeys(parola);
            


            var alegeMetodaDeplata = driver.FindElement(By.XPath(alegeMetodaDePlataSelector));
            alegeMetodaDeplata.Click();
            

            var termeniSiconditii = driver.FindElement(By.CssSelector(termeniSiconditiiSelector));
            termeniSiconditii.Click();
            

            var plaseazaComandaButton = driver.FindElement(By.CssSelector(plaseazaComandaButtonSelector));
            plaseazaComandaButton.Click();
           

        }


    }
}
