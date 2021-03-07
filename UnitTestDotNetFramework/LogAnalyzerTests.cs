using NUnit.Framework;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestLibraryDotNetFramework;

namespace UnitTestDotNetFramework
{
    //[TestFixture]
    public class LogAnalyzerTests
    {
        //[Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            var mockService = new ManualMockService();
            var log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            Assert.AreEqual("Filename too short:abc.ext", mockService.LastError);
        }

        //[Test]
        public void Analyze_TooShortFileName_ErrorLoggedToService()
        {
            var mocks = new MockRepository();
            var simulatedService = mocks.DynamicMock<IWebService>();

            using (mocks.Record())
            {
                simulatedService.LogError("Filename too short:abc.ext");
            }

            LogAnalyzer log = new LogAnalyzer(simulatedService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            mocks.Verify(simulatedService);
            
        }
    }
}
