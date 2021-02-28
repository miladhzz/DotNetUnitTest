using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestLibraryDotNetFramework
{
    public class FakeWebCrawler : IWebCrawler
    {
        public string GetTitle(string url)
        {
            return "OK";
        }
    }
}
