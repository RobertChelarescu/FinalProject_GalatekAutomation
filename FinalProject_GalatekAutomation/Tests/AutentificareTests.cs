using FinalProject_GalatekAutomation.PageModels;
using FinalProject_GalatekAutomation.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace FinalProject_GalatekAutomation.Tests.Authentication
{
    class AutentificareTests : BaseTest
    {

        string url = FrameworkConstants.GetUrl();


        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            string path = "TestData\\testdataautentificare.csv";

            var index = 0;
            using var reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (index > 0)
                {
                    yield return new TestCaseData(values[0].Trim(), values[1].Trim());
                }
                index++;
            }
        }
        
        [Category("Smoke")]
        [Test, Order(1),TestCaseSource("GetCredentialsDataCsv")]
        
        public void Autentificarea(string nume, string parola)

        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);

            MainPage mp = new MainPage(_driver);
            mp.AcceptCookie();
            mp.MoveToLoginPage();
            LoginPage lp = new LoginPage(_driver);
            Assert.AreEqual("Autentificare", lp.CheckPage());
            var errors = lp.Autentificare(nume,parola);
           // Assert.AreEqual(credentialError,errors["ERROR: The username or password you entered is incorrect. Lost your password?"]);           

        }

    }
}
