using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestLibraryDotNetFramework
{
    public class StubService : IWebService
    {
        public Exception ToThrow;
        public void LogError(string message)
        {
            if (ToThrow != null)
            {
                throw ToThrow;
            }
        }
    }
}
