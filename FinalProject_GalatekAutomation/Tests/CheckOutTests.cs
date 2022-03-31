using FinalProject_GalatekAutomation.PageModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace FinalProject_GalatekAutomation.Tests
{
    class CheckOutTests : BaseTest
    {

        string url = Utils.FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv3()
        {
            var csvData = Utils.Utils.GetDataTableFromCsv("TestData\\testdatacheckout.csv");
            for (int i = 0; i < csvData.Rows.Count; i++)
            {
                yield return new TestCaseData(csvData.Rows[i].ItemArray);
            }
        }


        [Test, Order(6),TestCaseSource("GetCredentialsDataCsv3")]

        public void CheckOutTest(string nume, string prenume, string email, string telefon,string numejudet,string numeoras, string strada, string apartament, string parola)
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.AcceptCookie();
            mp.ClickToMotofierastraie();

            ProductsPage pp = new ProductsPage(_driver);
            pp.ClickOnMotofierastrauSthil();

            AddToCartPage productToCart = new AddToCartPage(_driver);
            productToCart.AdaugaInCosButtonElement();
            productToCart.VeziCosul();
            productToCart.FinalizareaComenzii();



            CheckOutPage cop = new CheckOutPage(_driver);
            Assert.IsTrue(cop.CheckIfCheckOut("Detalii de facturare"));

           
           
            cop.DetaliiFacturare(nume, prenume,email,telefon,numejudet,numeoras,strada,apartament,parola);
           
                      

        }
        public CheckOutTests()
        {
        }
    }
}
