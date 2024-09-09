using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.EmailService.Interface
{
    public interface IEmail
    {
        List<string> ExtractEmails(string text);
    }
}
