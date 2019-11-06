#r "SendGrid"

using System;
using SendGrid.Helpers.Mail;

public static void Run(string input, ILogger log, out SendGridMessage message)
{
    message = new SendGridMessage()
    {
        Subject = "Demo Dry Run"
    };
    
    message.AddContent("text/plain", $"{input}");
}
