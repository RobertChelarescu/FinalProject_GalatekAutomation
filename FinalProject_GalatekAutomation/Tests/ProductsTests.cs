using FinalProject_GalatekAutomation.PageModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.Tests
{
    class ProductsTests : BaseTest
    {
        string url = Utils.FrameworkConstants.GetUrl();

        [TestCase("Motofierastraie", "MOTOFERASTRAU STIHL MS 500I 50CM 1,6MM 3/8″", "6,027.00 lei", "lei", "DOAR 1 PRODUS RAMAS IN STOC", "11472000000")]
        [Test]

        public void ProductsPage(string expectedCategorieProdus,string expectedMarca,string expectedPret,string expectedMoneda,string expectedStoc,string expectedCodProdus)
        {
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.AcceptCookie();
            mp.ClickToMotofierastraie();

            ProductsPage pp = new ProductsPage(_driver);
            Assert.AreEqual(expectedCategorieProdus, "Motofierastraie");
            pp.ClickOnMotofierastrauSthil();

            Assert.AreEqual(expectedMarca, pp.MarcaMotofierastrau());
            Console.WriteLine(pp.MarcaMotofierastrau());

            Assert.AreEqual(expectedPret, pp.VerificarePret());
            Console.WriteLine(pp.VerificarePret());

            Assert.AreEqual(expectedMoneda, pp.VerificareMonedaPret());
            Console.WriteLine(pp.VerificareMonedaPret());

            Assert.AreEqual(expectedStoc, pp.VerificareDisponibilitateProdus());
            Console.WriteLine(pp.VerificareDisponibilitateProdus());

            Assert.AreEqual(expectedCodProdus, pp.VerificareCodProdus());
            Console.WriteLine(pp.VerificareCodProdus());
        }
    }
}
