using FinalProject_GalatekAutomation.PageModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FinalProject_GalatekAutomation.Tests
{
    public class InregistrareTests : BaseTest
       {
        string url = Utils.FrameworkConstants.GetUrl();


        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            string path = "TestData\\testdatainregistrare.csv";

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

        [Test, TestCaseSource("TestData\\testdatainregistrare.csv")]
        
        public void Inregistrare(string email, string parola)

        {
            _driver.Navigate().GoToUrl(url);

            MainPage mp = new MainPage(_driver);
            mp.AcceptCookie();
            mp.MoveToLoginPage();
            RegistrationPage rp = new RegistrationPage(_driver);
             rp.Inregistrare(email, parola);


        }
    }
}





    

