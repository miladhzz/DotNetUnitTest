using NUnit.Framework;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestLibraryDotNetFramework;
using Rhino.Mocks.Constraints;


namespace UnitTestDotNetFramework
{
    [TestFixture]
    public class LogAnalyzer2Tests
    {
        [Test]
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

        [Test]
        public void Analyze_WebServiceThrows_SendsEmail2()
        {
            var mocks = new MockRepository();
            var stubService = mocks.Stub<IWebService>();
            var mockEmail = mocks.StrictMock<IEmailService>();

            using (mocks.Record())
            {
                stubService.LogError("whatever");
                LastCall.Constraints(new Anything());
                LastCall.Throw(new Exception("fake exception"));

                mockEmail.SendEmail("a", "subject", "fake exception");
            }

            LogAnalyzer2 log = new LogAnalyzer2(stubService, mockEmail);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            mocks.VerifyAll();

        }

    }
}
