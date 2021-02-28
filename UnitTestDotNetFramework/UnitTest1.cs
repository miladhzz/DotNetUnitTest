using NUnit.Framework;
using System;
using UnitTestLibraryDotNetFramework;

namespace UnitTestDotNetFramework
{
    [TestFixture]
    public class Tests
    {
        private LogAnalyzer _logAnalyzer = null;
        [SetUp]
        public void Setup()
        {
            _logAnalyzer = new LogAnalyzer(null);
        }

        [Test]
        [Category("milad")]
        public void CheckName()
        {
            Assert.IsTrue(_logAnalyzer.CheckName());
        }
        [Test]
        [Category("milad")]
        public void CheckLastSum()
        {
            var lastSum = _logAnalyzer.Sum();
            Assert.AreEqual(0, lastSum);
        }
        [Test]
        [Ignore("test ignore")]
        public void AddNumber()
        {
            _logAnalyzer.Add(5);
            var lastSum = _logAnalyzer.Sum();
            Assert.AreEqual(6, lastSum);
        }

        [Test]
        public void CheckUrl()
        {
            Assert.IsTrue(_logAnalyzer.CheckWeb("http://test.com"));
        }

        [Test]
        public void Analyse_NameLength()
        {
            var mockService = new MockService();
            var log = new LogAnalyzer(mockService);
            string short_name = "abc.ext";

            log.Analyze(short_name);
            Assert.AreEqual("Filename too short:abc.ext", mockService.LastError);
        }
    }
}
