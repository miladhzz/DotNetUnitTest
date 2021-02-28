using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_Test_Library
{
    public class ManualMockService: IWebService
    {
        public string LastError;
        public void LogError(string message)
        {
            LastError = message;
        }
    }
}
