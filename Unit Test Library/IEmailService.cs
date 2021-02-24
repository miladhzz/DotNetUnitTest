using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_Test_Library
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
