using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestLibraryDotNetFramework
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
