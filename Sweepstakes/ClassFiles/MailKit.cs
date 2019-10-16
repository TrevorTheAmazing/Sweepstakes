using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Sweepstakes
{
    public static class MailKit
    {
        //member methods
        public static void SendMessage(string contestantNameIn, string sweepstakesNameIn, string emailAddressIn)
        {
            var message = new MimeMessage();

            //header
            message.From.Add(new MailboxAddress("Sweepstakes Manager", "NoReply@Sweepstakes.com"));
            message.To.Add(new MailboxAddress(contestantNameIn, emailAddressIn));
            message.Subject = "CONGRATULATIONS, YOU'VE WON!";

            //body
            message.Body = new TextPart("plain")
            {
                Text = @"Hey " + contestantNameIn + ", " + Environment.NewLine + 
                "I just wanted to let you know that you are the winner of the " + sweepstakesNameIn + " sweepstakes!"
            };

            //get the SMTP server name from the winner's email address
            string tempServer = "smtp.";
            for (int i = 1; i < emailAddressIn.Length - 1; i++)
            {
                if (emailAddressIn[i-1] == 64)
                {
                    tempServer += emailAddressIn.Substring(i);
                    break;
                }
            }

            //send the message
            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                try
                {
                    client.Connect(tempServer, 587, false);
                
                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate("NoReply", "password");

                    client.Send(message);
                    client.Disconnect(true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
