using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Unit_Test_Library;

namespace NUnitTestProject1
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            ManualMockService mockService = new ManualMockService();
            LogAnalyzer log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            Assert.AreEqual("Filename too short:abc.ext",
            mockService.LastError);
        }
    }
}
