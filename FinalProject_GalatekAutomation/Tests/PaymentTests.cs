using Docker.DotNet.Models;
using FinalProject_GalatekAutomation.PageModels;
using FinalProject_GalatekAutomation.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProject_GalatekAutomation.Tests
{
    class PaymentTests : BaseTest
    {

        string url = FrameworkConstants.GetUrl();

        [TestCase("pal", "teodor", "td.ema", "00000", "dambovita", "targoviste", "Ibanesti", "2", "parolapaladi28","6422841256332220","TEODOR PALADI")]
        [Test]
        public void Payments(string nume, string prenume, string email, string telefon, string numejudet, string numeoras, string strada, string apartament, string parola)
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

            cop.DetaliiFacturare(nume, prenume, email, telefon, numejudet, numeoras, strada, apartament, parola);
          


            PaymentPage ipay = new PaymentPage(_driver);
            ipay.DetaliiPayment(Utils.Utils.GenerateRandomStringCount(10) , Utils.Utils.GenerateRandomStringCountNumber(16));
            


            


        }
    }
}
