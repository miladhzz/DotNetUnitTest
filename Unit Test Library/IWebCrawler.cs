using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_Test_Library
{
    public interface IWebCrawler
    {
        public string GetTitle(string url);
    }
}
