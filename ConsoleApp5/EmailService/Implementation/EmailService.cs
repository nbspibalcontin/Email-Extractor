﻿using ConsoleApp5.EmailService.Interface;
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
            // Text Validation
            TextValidation(text);

            var emailPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

            return Regex.Matches(text, emailPattern)
                        .Cast<Match>()
                        .Select(m => m.Value)
                        .ToList();
        }

        private static void TextValidation(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Text cannot be null or whitespace.", nameof(text));
            }
        }
    }
}
