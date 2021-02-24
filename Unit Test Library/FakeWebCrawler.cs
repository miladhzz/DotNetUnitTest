using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_Test_Library
{
    public class FakeWebCrawler : IWebCrawler
    {
        public string GetTitle(string url)
        {
            return "OK";
        }
    }
}
