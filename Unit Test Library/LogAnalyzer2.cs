using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_Test_Library
{
    public class LogAnalyzer2
    {
        private IWebService _service;
        private IEmailService _email;
        public LogAnalyzer2(IWebService webService, IEmailService emailService)
        {
            _service = webService;
            _email = emailService;
        }
        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                try
                {
                    _service.LogError("Filename too short:" + fileName);
                }
                catch (Exception e)
                {
                    _email.SendEmail("a", "subject", e.Message);
                }
            }
        }
    }
}
