using ConsoleApp5.EmailService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp5.EmailService.Implementation
{
    public class EmailService : IEmail
    {
        public List<string> ExtractEmails(string text)
        {
            var emailPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            var matches = Regex.Matches(text, emailPattern);
            var emails = new List<string>();

            foreach (Match match in matches)
            {
                emails.Add(match.Value);
            }

            return emails;
        }
    }
}
