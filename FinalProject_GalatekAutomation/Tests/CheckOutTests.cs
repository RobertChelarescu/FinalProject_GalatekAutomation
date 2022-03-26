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

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            string path = "TestData\\testdatacheckout.csv";

            var index = 0;
            using var reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (index > 0)
                {
                    yield return new TestCaseData(values[0].Trim(), values[1].Trim(),values[2].Trim(), values[3].Trim(), values[4].Trim(), values[5].Trim(), values[6].Trim(), values[7].Trim(), values[8].Trim());
                }
                index++;
            }
        }


        [Test, TestCaseSource("GetCredentialsDataCsv")]

        public void CheckOutTest(string nume, string prenume, string email, string telefon,string numejudet,string numeoras, string strada, string apartament, string parola)
        {
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
