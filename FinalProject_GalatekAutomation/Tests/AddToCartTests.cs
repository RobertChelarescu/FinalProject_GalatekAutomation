using FinalProject_GalatekAutomation.PageModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.Tests
{
    class AddToCartTests:BaseTest
    {
        string url = Utils.FrameworkConstants.GetUrl();

        [TestCase("Motofierastraie")]

        [Test, Order(5)]

       public void AddToCartTest(string expectedCategorieProdus)
        {
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.AcceptCookie();
            mp.ClickToMotofierastraie();

            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);

            ProductsPage pp = new ProductsPage(_driver);
            Assert.AreEqual(expectedCategorieProdus, "Motofierastraie");
            pp.ClickOnMotofierastrauSthil();

            AddToCartPage productToCart = new AddToCartPage(_driver);
            productToCart.AdaugaInCosButtonElement();
            productToCart.VeziCosul();
            productToCart.FinalizareaComenzii();
        }

    }
}
