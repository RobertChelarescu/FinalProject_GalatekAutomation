using FinalProject_GalatekAutomation.PageModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_GalatekAutomation.Tests
{
    public class DezautentificareTests:BaseTest
    {

        string url = Utils.FrameworkConstants.GetUrl();
        [TestCase("teodor.paladi@yahoo.com","teodorpaladi")]
        [TestCase("florina.maria@yahoo.com", "parolatest1")]
        [Test]

        public void Dezautentificare(string expectedEmail,string expectedParola)
        {
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.AcceptCookie();
            mp.MoveToLoginPage();
            LoginPage lp = new LoginPage(_driver);
            Assert.AreEqual("Autentificare", lp.CheckPage());
            lp.Autentificare(expectedEmail, expectedParola);

            LogOutPage lop = new LogOutPage(_driver);
            lop.ClickOnLogOut();
            //lop.ClickOnDezautentificare();



        }

    }
}
