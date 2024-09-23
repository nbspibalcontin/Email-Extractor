using ConsoleApp5.EmailService.Implementation;
using ConsoleApp5.EmailService.Interface;

public class Program
{
    private static readonly IEmail emailService = new EmailService();

    public static void Main(string[] args)
    {        
        string text = "Contact us at support@example.com or sales@example.com.";

        // Email Extractor Service
        var emails = emailService.ExtractEmails(text);

        Console.WriteLine(string.Join(", ", emails));
    }
}