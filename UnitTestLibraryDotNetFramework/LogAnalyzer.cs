﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestLibraryDotNetFramework
{
    public class LogAnalyzer
    {
        private IWebService _webService;
        public LogAnalyzer(IWebService webService)
        {
            _webService = webService;
            FirstName = "Ali";
        }
        public void Analyze(string name)
        {
            if (name.Length < 8)
            {
                _webService.LogError("Filename too short:" + name);
            }
        }
        public int Id { get; set; }        
        public string FirstName { get; set; }
        public bool CheckName()
        {
            if (FirstName != "Ali")
                return false;
            return true;
        }

        private int sum = 0;
        public void Add(int number)
        {
            sum += number;
        }
        public int Sum()
        {
            var temp = sum;
            sum = 0;
            return temp;
        }

        public bool CheckWeb(string url)
        {
#if TEST
            return string.IsNullOrEmpty(new FakeWebCrawler().GetTitle(url)) ? false : true;
#else            
            return string.IsNullOrEmpty(new WebCrawler().GetTitle(url)) ? false : true;
#endif
        }
    }
}
