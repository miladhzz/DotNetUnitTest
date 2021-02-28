using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestLibraryDotNetFramework
{
    public class MockService : IWebService
    {
        public string LastError;
        public void LogError(string message)
        {
            LastError = message;
        }
    }
}
