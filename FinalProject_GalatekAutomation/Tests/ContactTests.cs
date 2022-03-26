using FinalProject_GalatekAutomation.PageModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FinalProject_GalatekAutomation.Tests
{
    public class ContactTests : BaseTest
    {

        string url = Utils.FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            string path = "TestData\\testdatacontact.csv";

            var index = 0;
            using var reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (index > 0)
                {
                    yield return new TestCaseData(values[0].Trim(), values[1].Trim(), values[2].Trim(), values[3].Trim(), values[4].Trim());
                }
                index++;
            }
        }


        [Test, TestCaseSource("GetCredentialsDataCsv")]

        public void ContactTest(string expectedContactatiLabelSelector,string nume,string email,string subiect,string mesaj)
        {
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.AcceptCookie();


            ContactPage cp = new ContactPage(_driver);
            Assert.AreEqual(expectedContactatiLabelSelector, "Contactati-ne");
            cp.ClickOnContactButton();
            cp.Contact(nume,email,subiect,mesaj);


        }
    }
}
