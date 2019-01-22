using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string email, string text)
        {
            Console.WriteLine($"Sending email to: {email} with text: {text}");
        }
    }
}
