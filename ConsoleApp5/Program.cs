using ConsoleApp5.EmailService.Implementation;
using ConsoleApp5.EmailService.Interface;

public class Program
{
    private static readonly IEmail emailService = new EmailService();
    public static void Main(string[] args)
    {
        // Email Extractor Service
        string text = "Contact us at support@example.com or sales@example.com.";
        var emails = emailService.ExtractEmails(text);

        Console.WriteLine(string.Join(", ", emails));
    }
}