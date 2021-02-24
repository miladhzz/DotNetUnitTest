using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_Test_Library
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
