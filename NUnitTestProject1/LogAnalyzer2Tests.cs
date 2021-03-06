using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Unit_Test_Library;

namespace NUnitTestProject1
{
    //[TestFixture]
    public class LogAnalyzer2Tests
    {
        //[Test]
        public void Analyze_WebServiceThrows_SendsEmail()
        {
            var stubService = new StubService();
            stubService.ToThrow = new Exception("fake exception");

            var mockEmail = new MockEmailService();

            var log = new LogAnalyzer2(stubService, mockEmail);

            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            Assert.AreEqual("a", mockEmail.To);
            Assert.AreEqual("fake exception", mockEmail.Body);
            Assert.AreEqual("subject", mockEmail.Subject);

        }

    }
}
